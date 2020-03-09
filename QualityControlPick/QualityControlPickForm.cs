using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Com.SharpZebra.Printing;
using Com.SharpZebra.Commands;
using Com.SharpZebra;
using QualityControlPick.Models;

namespace QualityControlPick
{
    public partial class QualityControl : Form
    {

        private SqlConnection conn;
        private SqlCommand query;
        private SqlDataAdapter adapter;
        private DataTable grid;
        public string conString = @"Data Source=192.168.1.109\SIXBITDBSERVER;Initial Catalog=SixBit_BT;Persist Security Info=True;User ID=sa;Password=Comcast1!";
        //public string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SixBit_BT;Persist Security Info=True;User ID=sa;Password=123456789";
        private string Query;
        //private string FieldName;

        public QualityControl()
        {
            InitializeComponent();

            //Populate List of Storage Bins
            //Query = @"SELECT DISTINCT(StorageLocation) FROM Items WHERE StorageLocation NOT LIKE '%/%' AND StorageLocation NOT IN ('none','') ORDER BY StorageLocation";
            //FieldName = "StorageLocation";
            //ProductBin.DataSource = SQLQuery(Query, FieldName);

            //Populate List of Users
            Query = @"SELECT [UserID],[UserName] FROM CCC.dbo.SixBit_BT_UserLogins ORDER BY [Priority],[UserID]";
            UserID.DataSource = SQLQuery(Query, "UserName");
            //UserID.DataSource = new List<string>(new string[] { "<Enter User Name>", "Eric", "Test" });
        }

        private void UserID_TextChanged(object sender, EventArgs e)
        {
            if (this.UserID.Text != "<Enter User Name>")
            {
                ScannedBarcode.Enabled = true;
                UserID.Enabled = false;
            }
            //UserID.Enabled = false;
            ScannedBarcode.Focus();
        }
        private void ChangeUserID(object sender, EventArgs e)
        {
            UserID.Text = "<Enter User Name>";
            ScannedBarcode.Enabled = false;
            UserID.Enabled = true;
            ResetFrom();
            UserID.Focus();
        }
        private void ScannedBarcode_TextChanged(object sender, EventArgs e)
        {
            string barcode = ScannedBarcode.Text.ToUpper();
            //barcode = "124353\n";
            if (barcode.Length > 1)
            {
                char lastChar = barcode[barcode.Length - 1];
                if (lastChar == '\n')
                {
                    barcode = barcode.Substring(0, barcode.Length - 2);
                    ScannedBarcode.Text = barcode;
                    ScannedBarcode.Enabled = false;
                    PopulateOrderAndBin(barcode);
                   
                    OrderAndBin.SelectedIndex = OrderAndBin.Items.Count == 2? 1: 0;
                    OrderAndBin.Enabled = OrderAndBin.Items.Count > 1;
                }
            }
        }

        public void PopulateOrderAndBin (string sku)
        {
            var sql = @"SELECT case when Orders.substatusid =2 then 'ON HOLD ' else '' end +'Order: ' + case when orders.ExternalOrderID like '%-%' then orders.ExternalOrderID else Sales.eCommerceID end + case when Buyers.eBayUserid is null then '' else + ' / ' + ISNULL(Buyers.eBayUserid, '-') end + ' / ' + ISNULL(Addresses.FirstName, '-') + ' ' + ISNULL(Addresses.LastName, '-') AS OrderBin,
                        isnull(sales.Title,items.Title) as [title]
                        FROM Orders
                        INNER JOIN Shipments ON Shipments.OrderID = Orders.OrderID
                        INNER JOIN Sales ON Sales.ShipmentID = Shipments.ShipmentID
                        INNER JOIN Buyers ON Buyers.BuyerID = Orders.BuyerID
                        INNER JOIN Addresses on Addresses.AddressID=Shipments.ShippingAddressID
                        INNER JOIN SalesPurchases ON Sales.SaleID = SalesPurchases.SaleID
                        INNER JOIN Purchases ON SalesPurchases.PurchaseID = Purchases.PurchaseID
                        INNER JOIN Inventory ON Purchases.InventoryID = Inventory.InventoryID
                        INNER JOIN items on items.ItemID=inventory.ItemID
                        WHERE Inventory.SKU = @SKU and orders.StatusID=2000
                        UNION ALL
                        select
                        'Cleaners: '+
                        case when storeid='5005' then convert(varchar,ord.ordernumber) +' / WalMart'--WalMart
                        when storeid=2005 then code +' / '+ebaybuyerid --ebay
                        when storeid=1005 then amazonorderid+' / Amazon' --Amazon
                        else code
                        end +' / ' + shipfirstname+' ' +shiplastname, 'Cleaners'
                        from [192.168.1.4].[ShipWorks].[dbo].orderitem
                        join [192.168.1.4].[ShipWorks].[dbo].[order] ord on ord.orderid=orderitem.orderid
                        left join [192.168.1.4].[ShipWorks].[dbo].[Amazonorder] amzord on ord.orderid=amzord.orderid
                        left join [192.168.1.4].[ShipWorks].[dbo].[ebayorder] ebayord on ord.orderid=ebayord.orderid
                        where sku=@sku and ord.LocalStatus='At Cleaners'
                        Union ALL
                        select 'QC Check Box','QC Check Box'";
            var orders = new OrderAndBinModel[]{
                        new OrderAndBinModel
                        {
                            OrderBin="Select the order",
                            Title= " "
                        }
            };
            var items = SQLQueryParam(sql, "sku", sku);
            orders = orders.Concat(items).ToArray();
            OrderAndBin.DataSource = orders;
            if (items.Count()  == 1 )
            {
                OrderAndBin.SelectedIndex = 1;
            }
            else
            {
                OrderAndBin.SelectedIndex = 0;
            }
            OrderAndBin.DisplayMember = "OrderBin";
            OrderAndBin.ValueMember = "Title";
        }

      public void PassButtonClicked(object sender, EventArgs e)
      {
            //QC Name, SKU, Order/Bin Info, Pass , Date/Time to Audit Table
            string OrderBinText = OrderAndBin.Text.Replace("'", "''");
            OrderBinText.Replace("Bin: ", "");
            OrderBinText.Replace("Order: ", "");
            Query = @"INSERT INTO CCC.dbo.AuditTable (UserName,SKU,OrderBin,Status,AddedOn) VALUES ('"+ UserID.Text + "','"+ ScannedBarcode.Text + "','" + OrderBinText + "','Pass',GETDATE())";
            SQLNonQuery(Query);

            ResetFrom();

      }
        private void Steam_Click(object sender, EventArgs e)
        {
            //QC Name, SKU, Order/Bin Info, Pass , Date/Time to Audit Table
            string OrderBinText = OrderAndBin.Text.Replace("'", "''");
            OrderBinText.Replace("Bin: ", "");
            OrderBinText.Replace("Order: ", "");
            Query = @"INSERT INTO CCC.dbo.AuditTable (UserName,SKU,OrderBin,Status,AddedOn) VALUES ('" + UserID.Text + "','" + ScannedBarcode.Text + "','" + OrderBinText + "','Steam',GETDATE())";
            SQLNonQuery(Query);

            ResetFrom();
        }

        public void FailButtonClicked(object sender, EventArgs e)
        {

            /*
               
                
                If >0 then display a dialog log that reads “There is another available to pick” - Restart Process
                If =0 then display a dialog log that reads “No more available” - Restart Process

            //QC Name, SKU, Order/Bin Info, Fail , Date/Time to Audit Table
            */
            string OrderBinText = OrderAndBin.Text.Replace("'", "''");
            OrderBinText.Replace("Bin: ", "");
            OrderBinText.Replace("Order: ", "");
            Query = @"INSERT INTO CCC.dbo.AuditTable (UserName,SKU,OrderBin,Status,AddedOn) VALUES ('" + UserID.Text + "','" + ScannedBarcode.Text + "','" + OrderBinText + "','Fail',GETDATE())";
            SQLNonQuery(Query);

            string CountOnHandQuery = @"SELECT CAST(ISNULL(([dbo].[GetTotalOnHandForInventoryID](inventory.inventoryID))-([dbo].[GetSoldWaitingShipmentForInventoryID](inventory.InventoryID)),0) AS NVARCHAR(10)) AS CountOnHand FROM Items INNER JOIN Inventory ON Inventory.ItemID=items.ItemID WHERE SKU=@SKU";
            string CountOnHandResults = SQLQueryParam(CountOnHandQuery, "SKU", ScannedBarcode.Text, "CountOnHand")[0];
            int CountOnHand;

            if (CountOnHandResults != "No Records Available")
            {
                CountOnHand = Int32.Parse(CountOnHandResults);
            }
            else
            {
                CountOnHand = 0;
            }

            if (CountOnHand > 0)
            {
                MessageBox.Show("PICK ANOTHER");
            } else {
                MessageBox.Show("No more available");
            }

            ResetFrom();

        }

        private void CleanersButtonClicked(object sender, EventArgs e)
        {

            string OrderBinText = OrderAndBin.Text.Replace("'", "''");
            string ecom = OrderAndBin.Text.Split(':', '/')[1];
            ecom = ecom.Trim();
            string ebayuserid = OrderAndBin.Text.Split('/', '/')[1];
            ebayuserid = ebayuserid.Trim();
            OrderBinText.Replace("Bin: ", "");
            OrderBinText.Replace("Order: ", "");
            Query = @"INSERT INTO CCC.dbo.AuditTable (UserName,SKU,OrderBin,Status,AddedOn) VALUES ('" + UserID.Text + "','" + ScannedBarcode.Text + "','" + OrderBinText + "','Cleaners',GETDATE())";
            SQLNonQuery(Query);
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            Query = @"EXEC [SW].[ShipWorks].[dbo].[ShipWorks_Cleaners] @sku = N'" + ScannedBarcode.Text + "',@ecom = N'" + ecom + "',@ebayid = N'" + ebayuserid + "'";
            SQLNonQuery(Query);
            Query = @"EXEC [Cleaners_hold] @ecom = N'" + ecom + "',@ebayid = N'" + ebayuserid + "'";
            SQLNonQuery(Query);
            ResetFrom();
        }

        public void ResetFrom()
        {
            ScannedBarcode.Enabled = true;
            ProductPicture.ImageLocation = "";
            OrderAndBin.Enabled = false;
            PassButton.Enabled = false;
            FailButton.Enabled = false;
            CleanersButton.Enabled = false;
            Steam.Enabled = false;
            OrderAndBin.Text = "";
            ProductTitle.Text = "";
            ScannedBarcode.Text = "";
            ScannedBarcode.Focus();
        }

        public string[] SQLQuery(string SQLQuery, string FieldName)
        {
            conn = new SqlConnection(conString);

            conn.Open();
            query = new SqlCommand(SQLQuery, conn);

            adapter = new SqlDataAdapter(query);
            grid = new DataTable();
            adapter.Fill(grid);
            conn.Close();

            return (grid.AsEnumerable().Select(row => row.Field<string>(FieldName)).ToArray());

        }

        public OrderAndBinModel[] SQLQueryParam(string SQLQuery, string ParamName, string ParamValue)
        {
            conn = new SqlConnection(conString);

            conn.Open();
            query = new SqlCommand(SQLQuery, conn);
            query.Parameters.AddWithValue(ParamName, ParamValue);
            adapter = new SqlDataAdapter(query);
            grid = new DataTable();
            adapter.Fill(grid);
            conn.Close();

            if (grid.Rows.Count > 0)
            {
                return grid.AsEnumerable().Select(row => new OrderAndBinModel{
                   OrderBin = row.Field<string>("OrderBin"),
                   Title = row.Field<string>("title")
                }).ToArray();
            }
            else
            {
                return (new OrderAndBinModel[] { new OrderAndBinModel { Title = "No Records Available" } });
            }
        }

        public string[] SQLQueryParam(string SQLQuery, string ParamName,string ParamValue,string FieldName)
        {
            conn = new SqlConnection(conString);

            conn.Open();
            query = new SqlCommand(SQLQuery, conn);
            query.Parameters.AddWithValue(ParamName, ParamValue);
            adapter = new SqlDataAdapter(query);
            grid = new DataTable();
            adapter.Fill(grid);
            conn.Close();

            if(grid.Rows.Count > 0)
            { 
                return (grid.AsEnumerable().Select(row => row.Field<string>(FieldName)).ToArray());
            }
            else
            {
                return (new string[] { "No Records Available" });
            }
        }

        public void SQLNonQuery(string SQLQuery)
        {
            conn = new SqlConnection(conString);

            conn.Open();
            query = new SqlCommand(SQLQuery, conn);
            //query.Parameters.AddWithValue(ParamName, ParamValue);
            query.ExecuteNonQuery();
            conn.Close();
        }

        public List<string> SQLQuery2(string SQLQuery)
        {

            List<string> str = new List<string>();
            try
            {
                SqlCommand comm = new SqlCommand(SQLQuery, conn);
                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();                
                //int i = 0;
                while (reader.Read())
                {
                    str.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return str;
        }

       
        
        public static Image ConvertToImage(string iString, Encoding enc)
        {
            byte[] iBinary = enc.GetBytes(iString);
            var arrayBinary = iBinary.ToArray();
            Image rImage = null;

            using (MemoryStream ms = new MemoryStream(arrayBinary))
            {
                rImage = Image.FromStream(ms);
            }
            return rImage;
        }

        private void QualityControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pictures._Pictures' table. You can move, or remove it, as needed.
            this.picturesTableAdapter.Fill(pictures._Pictures);                       
        }


       
        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.picturesTableAdapter.FillBy1(this.pictures._Pictures, ((int)(System.Convert.ChangeType(parameterNameToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetFrom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintLabel(ScannedBarcode.Text);
        }
        private void PrintLabel(string Label)
        {
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = "ZDesigner GC420d (EPL)";
            ps.Width = 203 * 4;
            ps.Length = 203 * 3;
            ps.Darkness = 30;

            List<byte> page = new List<byte>();
            page.AddRange(ZPLCommands.ClearPrinter(ps));

            page.AddRange(ZPLCommands.TextWrite(100, 500, ElementDrawRotation.ROTATE_180_DEGREES, 80, Label));
            //page.AddRange(ZPLCommands.BarCodeWrite(10, 50, 50, ElementDrawRotation.NO_ROTATION, P4Value, 1, Label));            
            page.AddRange(ZPLCommands.TextWrite(30, 20, ElementDrawRotation.ROTATE_180_DEGREES, 50, ProductTitle.Text));
            page.AddRange(ZPLCommands.PrintBuffer(1));
            new SpoolPrinter(ps).Print(page.ToArray());
        }

        private void OrderAndBin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductTitle.Text = OrderAndBin.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(OrderAndBin.SelectedValue.ToString()))
            {
                button2.Enabled = true;
                PassButton.Enabled = true;
                FailButton.Enabled = true;
                CleanersButton.Enabled = true;
                Steam.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                PassButton.Enabled = false;
                FailButton.Enabled = false;
                CleanersButton.Enabled = false;
                Steam.Enabled = false;
            }
        }
    }
}
 