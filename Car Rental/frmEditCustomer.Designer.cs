namespace Car_Rental_Project
{
    partial class frmEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCustomer));
            this.ShadowfrmAddNewCustomer = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.epNumericValueCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.epDLNCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tbDLN = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomerID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbCustomer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.llblRemovePicture = new System.Windows.Forms.LinkLabel();
            this.llblSetPicture = new System.Windows.Forms.LinkLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.epNumericValueCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDLNCheck)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // ShadowfrmAddNewCustomer
            // 
            this.ShadowfrmAddNewCustomer.BorderRadius = 0;
            this.ShadowfrmAddNewCustomer.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // epNumericValueCheck
            // 
            this.epNumericValueCheck.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // epDLNCheck
            // 
            this.epDLNCheck.ContainerControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(12)))));
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(469, 36);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(12)))));
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(379, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 36);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(12)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(424, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 37);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // tbDLN
            // 
            this.tbDLN.Animated = true;
            this.tbDLN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbDLN.BorderRadius = 17;
            this.tbDLN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDLN.DefaultText = "";
            this.tbDLN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDLN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDLN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDLN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDLN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDLN.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDLN.ForeColor = System.Drawing.Color.Black;
            this.tbDLN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDLN.Location = new System.Drawing.Point(239, 643);
            this.tbDLN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDLN.Name = "tbDLN";
            this.tbDLN.PasswordChar = '\0';
            this.tbDLN.PlaceholderText = "";
            this.tbDLN.SelectedText = "";
            this.tbDLN.Size = new System.Drawing.Size(167, 27);
            this.tbDLN.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbDLN.TabIndex = 71;
            this.tbDLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDLN.Validating += new System.ComponentModel.CancelEventHandler(this.tbDLN_Validating);
            this.tbDLN.Validated += new System.EventHandler(this.tbDLN_Validated);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Animated = true;
            this.tbPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbPhoneNumber.BorderRadius = 17;
            this.tbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNumber.DefaultText = "";
            this.tbPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.tbPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber.Location = new System.Drawing.Point(239, 567);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PasswordChar = '\0';
            this.tbPhoneNumber.PlaceholderText = "";
            this.tbPhoneNumber.SelectedText = "";
            this.tbPhoneNumber.Size = new System.Drawing.Size(167, 27);
            this.tbPhoneNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPhoneNumber.TabIndex = 70;
            this.tbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhoneNumber_Validating);
            this.tbPhoneNumber.Validated += new System.EventHandler(this.tbPhoneNumber_Validated);
            // 
            // tbName
            // 
            this.tbName.Animated = true;
            this.tbName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbName.BorderRadius = 17;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Location = new System.Drawing.Point(239, 494);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.Size = new System.Drawing.Size(167, 27);
            this.tbName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbName.TabIndex = 69;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(20, 643);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(216, 27);
            this.guna2HtmlLabel5.TabIndex = 68;
            this.guna2HtmlLabel5.Text = "Driver License Number :";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(84, 567);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(149, 27);
            this.guna2HtmlLabel4.TabIndex = 67;
            this.guna2HtmlLabel4.Text = "Phone Number :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(167, 494);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(65, 27);
            this.guna2HtmlLabel3.TabIndex = 66;
            this.guna2HtmlLabel3.Text = "Name : ";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCustomerID.Location = new System.Drawing.Point(315, 417);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(36, 34);
            this.lblCustomerID.TabIndex = 65;
            this.lblCustomerID.Text = "???";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(171, 424);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(124, 27);
            this.guna2HtmlLabel1.TabIndex = 64;
            this.guna2HtmlLabel1.Text = "Customer ID : ";
            // 
            // pbCustomer
            // 
            this.pbCustomer.ImageRotate = 0F;
            this.pbCustomer.Location = new System.Drawing.Point(118, 56);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbCustomer.Size = new System.Drawing.Size(288, 275);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustomer.TabIndex = 63;
            this.pbCustomer.TabStop = false;
            // 
            // llblRemovePicture
            // 
            this.llblRemovePicture.AutoSize = true;
            this.llblRemovePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblRemovePicture.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRemovePicture.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.llblRemovePicture.Location = new System.Drawing.Point(297, 350);
            this.llblRemovePicture.Name = "llblRemovePicture";
            this.llblRemovePicture.Size = new System.Drawing.Size(151, 25);
            this.llblRemovePicture.TabIndex = 62;
            this.llblRemovePicture.TabStop = true;
            this.llblRemovePicture.Text = "Remove Picture";
            this.llblRemovePicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRemovePicture_LinkClicked_1);
            // 
            // llblSetPicture
            // 
            this.llblSetPicture.AutoSize = true;
            this.llblSetPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblSetPicture.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSetPicture.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.llblSetPicture.Location = new System.Drawing.Point(82, 350);
            this.llblSetPicture.Name = "llblSetPicture";
            this.llblSetPicture.Size = new System.Drawing.Size(108, 25);
            this.llblSetPicture.TabIndex = 61;
            this.llblSetPicture.TabStop = true;
            this.llblSetPicture.Text = "Set Picture";
            this.llblSetPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetPicture_LinkClicked_1);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 17;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(12)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(203, 709);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 45);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "Save";
            this.btnSave.TextOffset = new System.Drawing.Point(8, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(469, 779);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDLN);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pbCustomer);
            this.Controls.Add(this.llblRemovePicture);
            this.Controls.Add(this.llblSetPicture);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditCustomer";
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epNumericValueCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDLNCheck)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm ShadowfrmAddNewCustomer;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ErrorProvider epNumericValueCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider epDLNCheck;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbDLN;
        private Guna.UI2.WinForms.Guna2TextBox tbPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbCustomer;
        private System.Windows.Forms.LinkLabel llblRemovePicture;
        private System.Windows.Forms.LinkLabel llblSetPicture;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}