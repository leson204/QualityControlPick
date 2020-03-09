namespace QualityControlPick
{
    partial class QualityControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ScannedBarcode = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.ProductPicture = new System.Windows.Forms.PictureBox();
            this.ProductTitle = new System.Windows.Forms.TextBox();
            this.OrderAndBin = new System.Windows.Forms.ComboBox();
            this.PassButton = new System.Windows.Forms.Button();
            this.FailButton = new System.Windows.Forms.Button();
            this.CleanersButton = new System.Windows.Forms.Button();
            this.ChangeUser = new System.Windows.Forms.Button();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.ProductTitleLabel = new System.Windows.Forms.Label();
            this.BinOrderLabel = new System.Windows.Forms.Label();
            this.picFromDB = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictures = new QualityControlPick.Pictures();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.parameterNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.parameterNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.picturesTableAdapter = new QualityControlPick.PicturesTableAdapters.PicturesTableAdapter();
            this.MinsPerPiece = new System.Windows.Forms.TextBox();
            this.QtyOnHandBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Steam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFromDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictures)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScannedBarcode
            // 
            this.ScannedBarcode.Enabled = false;
            this.ScannedBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScannedBarcode.Location = new System.Drawing.Point(1113, 75);
            this.ScannedBarcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScannedBarcode.Multiline = true;
            this.ScannedBarcode.Name = "ScannedBarcode";
            this.ScannedBarcode.Size = new System.Drawing.Size(760, 95);
            this.ScannedBarcode.TabIndex = 1;
            this.ScannedBarcode.TextChanged += new System.EventHandler(this.ScannedBarcode_TextChanged);
            // 
            // UserID
            // 
            this.UserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(142, 20);
            this.UserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(466, 37);
            this.UserID.TabIndex = 2;
            this.UserID.TextChanged += new System.EventHandler(this.UserID_TextChanged);
            // 
            // ProductPicture
            // 
            this.ProductPicture.Location = new System.Drawing.Point(18, 74);
            this.ProductPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductPicture.Name = "ProductPicture";
            this.ProductPicture.Size = new System.Drawing.Size(1050, 1038);
            this.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPicture.TabIndex = 2;
            this.ProductPicture.TabStop = false;
            // 
            // ProductTitle
            // 
            this.ProductTitle.Enabled = false;
            this.ProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTitle.Location = new System.Drawing.Point(1107, 222);
            this.ProductTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductTitle.Multiline = true;
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.Size = new System.Drawing.Size(774, 309);
            this.ProductTitle.TabIndex = 3;
            // 
            // OrderAndBin
            // 
            this.OrderAndBin.Enabled = false;
            this.OrderAndBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAndBin.FormattingEnabled = true;
            this.OrderAndBin.Location = new System.Drawing.Point(1107, 648);
            this.OrderAndBin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderAndBin.Name = "OrderAndBin";
            this.OrderAndBin.Size = new System.Drawing.Size(774, 48);
            this.OrderAndBin.TabIndex = 10;
            this.OrderAndBin.SelectedIndexChanged += new System.EventHandler(this.OrderAndBin_SelectedIndexChanged);
            // 
            // PassButton
            // 
            this.PassButton.Enabled = false;
            this.PassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassButton.Location = new System.Drawing.Point(1140, 742);
            this.PassButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(318, 126);
            this.PassButton.TabIndex = 11;
            this.PassButton.Text = "Pass";
            this.PassButton.UseVisualStyleBackColor = true;
            this.PassButton.Click += new System.EventHandler(this.PassButtonClicked);
            // 
            // FailButton
            // 
            this.FailButton.Enabled = false;
            this.FailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailButton.Location = new System.Drawing.Point(1564, 743);
            this.FailButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FailButton.Name = "FailButton";
            this.FailButton.Size = new System.Drawing.Size(261, 126);
            this.FailButton.TabIndex = 12;
            this.FailButton.Text = "Fail";
            this.FailButton.UseVisualStyleBackColor = true;
            this.FailButton.Click += new System.EventHandler(this.FailButtonClicked);
            // 
            // CleanersButton
            // 
            this.CleanersButton.Enabled = false;
            this.CleanersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanersButton.Location = new System.Drawing.Point(1564, 923);
            this.CleanersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CleanersButton.Name = "CleanersButton";
            this.CleanersButton.Size = new System.Drawing.Size(261, 46);
            this.CleanersButton.TabIndex = 22;
            this.CleanersButton.Text = "Cleaners";
            this.CleanersButton.UseVisualStyleBackColor = true;
            this.CleanersButton.Click += new System.EventHandler(this.CleanersButtonClicked);
            // 
            // ChangeUser
            // 
            this.ChangeUser.Location = new System.Drawing.Point(900, 20);
            this.ChangeUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeUser.Name = "ChangeUser";
            this.ChangeUser.Size = new System.Drawing.Size(134, 35);
            this.ChangeUser.TabIndex = 13;
            this.ChangeUser.Text = "ChangeUser";
            this.ChangeUser.UseVisualStyleBackColor = true;
            this.ChangeUser.Click += new System.EventHandler(this.ChangeUserID);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(46, 37);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(87, 20);
            this.LabelUsername.TabIndex = 14;
            this.LabelUsername.Text = "Username:";
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLabel.Location = new System.Drawing.Point(1107, 31);
            this.BarcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(81, 32);
            this.BarcodeLabel.TabIndex = 15;
            this.BarcodeLabel.Text = "SKU:";
            // 
            // ProductTitleLabel
            // 
            this.ProductTitleLabel.AutoSize = true;
            this.ProductTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTitleLabel.Location = new System.Drawing.Point(1107, 182);
            this.ProductTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductTitleLabel.Name = "ProductTitleLabel";
            this.ProductTitleLabel.Size = new System.Drawing.Size(183, 32);
            this.ProductTitleLabel.TabIndex = 16;
            this.ProductTitleLabel.Text = "Product Title:";
            // 
            // BinOrderLabel
            // 
            this.BinOrderLabel.AutoSize = true;
            this.BinOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinOrderLabel.Location = new System.Drawing.Point(1107, 600);
            this.BinOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BinOrderLabel.Name = "BinOrderLabel";
            this.BinOrderLabel.Size = new System.Drawing.Size(327, 32);
            this.BinOrderLabel.TabIndex = 17;
            this.BinOrderLabel.Text = "Choose Order # or Bin #:";
            // 
            // picFromDB
            // 
            this.picFromDB.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSource1, "Picture", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "No Picture Available"));
            this.picFromDB.Location = new System.Drawing.Point(18, 75);
            this.picFromDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFromDB.Name = "picFromDB";
            this.picFromDB.Size = new System.Drawing.Size(1050, 1038);
            this.picFromDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFromDB.TabIndex = 18;
            this.picFromDB.TabStop = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Pictures";
            this.bindingSource1.DataSource = this.pictures;
            // 
            // pictures
            // 
            this.pictures.DataSetName = "Pictures";
            this.pictures.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parameterNameToolStripLabel,
            this.parameterNameToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1912, 38);
            this.fillBy1ToolStrip.TabIndex = 20;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // parameterNameToolStripLabel
            // 
            this.parameterNameToolStripLabel.Name = "parameterNameToolStripLabel";
            this.parameterNameToolStripLabel.Size = new System.Drawing.Size(87, 33);
            this.parameterNameToolStripLabel.Text = "PictureID:";
            this.parameterNameToolStripLabel.Visible = false;
            // 
            // parameterNameToolStripTextBox
            // 
            this.parameterNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.parameterNameToolStripTextBox.Name = "parameterNameToolStripTextBox";
            this.parameterNameToolStripTextBox.Size = new System.Drawing.Size(148, 38);
            this.parameterNameToolStripTextBox.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(96, 33);
            this.fillBy1ToolStripButton.Text = "UpdatePic";
            this.fillBy1ToolStripButton.Visible = false;
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // picturesTableAdapter
            // 
            this.picturesTableAdapter.ClearBeforeFill = true;
            // 
            // MinsPerPiece
            // 
            this.MinsPerPiece.Enabled = false;
            this.MinsPerPiece.Location = new System.Drawing.Point(638, 20);
            this.MinsPerPiece.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinsPerPiece.Name = "MinsPerPiece";
            this.MinsPerPiece.Size = new System.Drawing.Size(232, 26);
            this.MinsPerPiece.TabIndex = 21;
            // 
            // QtyOnHandBox
            // 
            this.QtyOnHandBox.Enabled = false;
            this.QtyOnHandBox.Location = new System.Drawing.Point(1478, 20);
            this.QtyOnHandBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QtyOnHandBox.Name = "QtyOnHandBox";
            this.QtyOnHandBox.Size = new System.Drawing.Size(148, 26);
            this.QtyOnHandBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1334, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Addt\'l Qty";
            // 
            // Steam
            // 
            this.Steam.Enabled = false;
            this.Steam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steam.Location = new System.Drawing.Point(1206, 923);
            this.Steam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Steam.Name = "Steam";
            this.Steam.Size = new System.Drawing.Size(210, 46);
            this.Steam.TabIndex = 25;
            this.Steam.Text = "Steam";
            this.Steam.UseVisualStyleBackColor = true;
            this.Steam.Click += new System.EventHandler(this.Steam_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1742, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cancel/Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(1564, 542);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 97);
            this.button2.TabIndex = 27;
            this.button2.Text = "Print Label";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QualityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1912, 1132);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QtyOnHandBox);
            this.Controls.Add(this.CleanersButton);
            this.Controls.Add(this.MinsPerPiece);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.picFromDB);
            this.Controls.Add(this.BinOrderLabel);
            this.Controls.Add(this.ProductTitleLabel);
            this.Controls.Add(this.BarcodeLabel);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ChangeUser);
            this.Controls.Add(this.FailButton);
            this.Controls.Add(this.PassButton);
            this.Controls.Add(this.OrderAndBin);
            this.Controls.Add(this.ProductTitle);
            this.Controls.Add(this.ProductPicture);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.ScannedBarcode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QualityControl";
            this.Text = "Quality Control Pick";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFromDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictures)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScannedBarcode;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.PictureBox ProductPicture;
        private System.Windows.Forms.TextBox ProductTitle;
        private System.Windows.Forms.ComboBox OrderAndBin;
        private System.Windows.Forms.Button PassButton;
        private System.Windows.Forms.Button FailButton;
        private System.Windows.Forms.Button ChangeUser;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.Label ProductTitleLabel;
        private System.Windows.Forms.Label BinOrderLabel;
        //private Pictures pictures;
        //private System.Windows.Forms.BindingSource picturesBindingSource;
        private System.Windows.Forms.PictureBox picFromDB;
        private Pictures pictures;
        private System.Windows.Forms.BindingSource bindingSource1;
        private PicturesTableAdapters.PicturesTableAdapter picturesTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel parameterNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox parameterNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.TextBox MinsPerPiece;
        private System.Windows.Forms.Button CleanersButton;
        private System.Windows.Forms.TextBox QtyOnHandBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Steam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

