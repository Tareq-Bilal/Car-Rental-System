namespace Car_Rental_Project
{
    partial class UC_RentalBooking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RentalBooking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbSearchBookInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvAllRentalBookings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsRentalBooking = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmShowVehicleInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsCustomerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.returnVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRentalBookings)).BeginInit();
            this.cmsRentalBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 17;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRefresh.Location = new System.Drawing.Point(1026, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 37);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderRadius = 17;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbFilter.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Book ID",
            "Vehicle ID",
            "Customer ID",
            "Pickup Location",
            "Dropoff Location"});
            this.cbFilter.Location = new System.Drawing.Point(437, 9);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(182, 36);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 9;
            this.cbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbSearchBookInfo
            // 
            this.tbSearchBookInfo.BorderRadius = 17;
            this.tbSearchBookInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchBookInfo.DefaultText = "";
            this.tbSearchBookInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchBookInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchBookInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchBookInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchBookInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchBookInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.tbSearchBookInfo.ForeColor = System.Drawing.Color.Black;
            this.tbSearchBookInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchBookInfo.Location = new System.Drawing.Point(134, 10);
            this.tbSearchBookInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearchBookInfo.Name = "tbSearchBookInfo";
            this.tbSearchBookInfo.PasswordChar = '\0';
            this.tbSearchBookInfo.PlaceholderText = "";
            this.tbSearchBookInfo.SelectedText = "";
            this.tbSearchBookInfo.Size = new System.Drawing.Size(205, 36);
            this.tbSearchBookInfo.TabIndex = 8;
            this.tbSearchBookInfo.TextChanged += new System.EventHandler(this.tbSearchBookInfo_TextChanged);
            // 
            // dgvAllRentalBookings
            // 
            this.dgvAllRentalBookings.AllowUserToAddRows = false;
            this.dgvAllRentalBookings.AllowUserToDeleteRows = false;
            this.dgvAllRentalBookings.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dgvAllRentalBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllRentalBookings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllRentalBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllRentalBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllRentalBookings.ColumnHeadersHeight = 25;
            this.dgvAllRentalBookings.ContextMenuStrip = this.cmsRentalBooking;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllRentalBookings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllRentalBookings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllRentalBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dgvAllRentalBookings.Location = new System.Drawing.Point(0, 103);
            this.dgvAllRentalBookings.Name = "dgvAllRentalBookings";
            this.dgvAllRentalBookings.ReadOnly = true;
            this.dgvAllRentalBookings.RowHeadersVisible = false;
            this.dgvAllRentalBookings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllRentalBookings.RowTemplate.Height = 30;
            this.dgvAllRentalBookings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllRentalBookings.Size = new System.Drawing.Size(1135, 480);
            this.dgvAllRentalBookings.TabIndex = 7;
            this.dgvAllRentalBookings.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.dgvAllRentalBookings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dgvAllRentalBookings.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllRentalBookings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllRentalBookings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllRentalBookings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllRentalBookings.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvAllRentalBookings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dgvAllRentalBookings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.dgvAllRentalBookings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAllRentalBookings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllRentalBookings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllRentalBookings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllRentalBookings.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvAllRentalBookings.ThemeStyle.ReadOnly = true;
            this.dgvAllRentalBookings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.dgvAllRentalBookings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllRentalBookings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllRentalBookings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllRentalBookings.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllRentalBookings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.dgvAllRentalBookings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsRentalBooking
            // 
            this.cmsRentalBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowVehicleInfo,
            this.toolStripSeparator1,
            this.tmsCustomerInfo,
            this.toolStripSeparator2,
            this.returnVehicleToolStripMenuItem});
            this.cmsRentalBooking.Name = "guna2ContextMenuStrip1";
            this.cmsRentalBooking.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsRentalBooking.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsRentalBooking.RenderStyle.ColorTable = null;
            this.cmsRentalBooking.RenderStyle.RoundedEdges = true;
            this.cmsRentalBooking.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsRentalBooking.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsRentalBooking.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsRentalBooking.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsRentalBooking.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsRentalBooking.Size = new System.Drawing.Size(183, 116);
            this.cmsRentalBooking.Opening += new System.ComponentModel.CancelEventHandler(this.cmsRentalBooking_Opening);
            // 
            // tsmShowVehicleInfo
            // 
            this.tsmShowVehicleInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmShowVehicleInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmShowVehicleInfo.Image")));
            this.tsmShowVehicleInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmShowVehicleInfo.Name = "tsmShowVehicleInfo";
            this.tsmShowVehicleInfo.Size = new System.Drawing.Size(182, 26);
            this.tsmShowVehicleInfo.Text = "Vehicle Info";
            this.tsmShowVehicleInfo.Click += new System.EventHandler(this.tsmShowVehicleInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // tmsCustomerInfo
            // 
            this.tmsCustomerInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmsCustomerInfo.Image = ((System.Drawing.Image)(resources.GetObject("tmsCustomerInfo.Image")));
            this.tmsCustomerInfo.Name = "tmsCustomerInfo";
            this.tmsCustomerInfo.Size = new System.Drawing.Size(182, 26);
            this.tmsCustomerInfo.Text = "Customer Info";
            this.tmsCustomerInfo.Click += new System.EventHandler(this.tmsCustomerInfo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // returnVehicleToolStripMenuItem
            // 
            this.returnVehicleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.returnVehicleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnVehicleToolStripMenuItem.Image")));
            this.returnVehicleToolStripMenuItem.Name = "returnVehicleToolStripMenuItem";
            this.returnVehicleToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.returnVehicleToolStripMenuItem.Text = "Return Vehicle";
            this.returnVehicleToolStripMenuItem.Click += new System.EventHandler(this.returnVehicleToolStripMenuItem_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(59, 14);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(68, 32);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Search";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(709, 13);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(41, 27);
            this.guna2HtmlLabel3.TabIndex = 15;
            this.guna2HtmlLabel3.Text = "Sort";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(378, 9);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(53, 32);
            this.guna2HtmlLabel5.TabIndex = 20;
            this.guna2HtmlLabel5.Text = "Filter";
            // 
            // cbSort
            // 
            this.cbSort.BackColor = System.Drawing.Color.Transparent;
            this.cbSort.BorderRadius = 17;
            this.cbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSort.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbSort.ForeColor = System.Drawing.Color.Black;
            this.cbSort.ItemHeight = 30;
            this.cbSort.Items.AddRange(new object[] {
            "Newest",
            "Oldest",
            "Longest Rent Period",
            "Shortest Rent Period",
            "Highest Rent Price/Day",
            "Lowest Rent Price/Day"});
            this.cbSort.Location = new System.Drawing.Point(756, 10);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(235, 36);
            this.cbSort.TabIndex = 21;
            this.cbSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(666, 13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(37, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 22;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UC_RentalBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.tbSearchBookInfo);
            this.Controls.Add(this.dgvAllRentalBookings);
            this.Name = "UC_RentalBooking";
            this.Size = new System.Drawing.Size(1135, 583);
            this.Load += new System.EventHandler(this.UC_RentalBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRentalBookings)).EndInit();
            this.cmsRentalBooking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchBookInfo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAllRentalBookings;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbSort;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsRentalBooking;
        private System.Windows.Forms.ToolStripMenuItem tsmShowVehicleInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmsCustomerInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem returnVehicleToolStripMenuItem;
    }
}
