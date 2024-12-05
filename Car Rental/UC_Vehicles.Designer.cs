namespace Car_Rental_Project
{
    partial class UC_Vehicles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Vehicles));
            this.dgvAllVehicles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsEditDeleteVehcile = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearchVehicleInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddNewVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllVehicles)).BeginInit();
            this.cmsEditDeleteVehcile.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllVehicles
            // 
            this.dgvAllVehicles.AllowUserToAddRows = false;
            this.dgvAllVehicles.AllowUserToDeleteRows = false;
            this.dgvAllVehicles.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dgvAllVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllVehicles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllVehicles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllVehicles.ColumnHeadersHeight = 25;
            this.dgvAllVehicles.ContextMenuStrip = this.cmsEditDeleteVehcile;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllVehicles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dgvAllVehicles.Location = new System.Drawing.Point(0, 103);
            this.dgvAllVehicles.Name = "dgvAllVehicles";
            this.dgvAllVehicles.ReadOnly = true;
            this.dgvAllVehicles.RowHeadersVisible = false;
            this.dgvAllVehicles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllVehicles.RowTemplate.Height = 30;
            this.dgvAllVehicles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllVehicles.Size = new System.Drawing.Size(1021, 480);
            this.dgvAllVehicles.TabIndex = 0;
            this.dgvAllVehicles.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.dgvAllVehicles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dgvAllVehicles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllVehicles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllVehicles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllVehicles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllVehicles.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvAllVehicles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dgvAllVehicles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.dgvAllVehicles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAllVehicles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllVehicles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllVehicles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllVehicles.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvAllVehicles.ThemeStyle.ReadOnly = true;
            this.dgvAllVehicles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.dgvAllVehicles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllVehicles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllVehicles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllVehicles.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllVehicles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.dgvAllVehicles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsEditDeleteVehcile
            // 
            this.cmsEditDeleteVehcile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.toolStripSeparator1,
            this.tsmDelete,
            this.toolStripSeparator2,
            this.bookToolStripMenuItem});
            this.cmsEditDeleteVehcile.Name = "guna2ContextMenuStrip1";
            this.cmsEditDeleteVehcile.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsEditDeleteVehcile.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsEditDeleteVehcile.RenderStyle.ColorTable = null;
            this.cmsEditDeleteVehcile.RenderStyle.RoundedEdges = true;
            this.cmsEditDeleteVehcile.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsEditDeleteVehcile.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsEditDeleteVehcile.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsEditDeleteVehcile.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsEditDeleteVehcile.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsEditDeleteVehcile.Size = new System.Drawing.Size(126, 94);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmEdit.Image")));
            this.tsmEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(125, 26);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmDelete.Image")));
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(125, 26);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(122, 6);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookToolStripMenuItem.Image")));
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // tbSearchVehicleInfo
            // 
            this.tbSearchVehicleInfo.BorderRadius = 17;
            this.tbSearchVehicleInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchVehicleInfo.DefaultText = "";
            this.tbSearchVehicleInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchVehicleInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchVehicleInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchVehicleInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchVehicleInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchVehicleInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchVehicleInfo.ForeColor = System.Drawing.Color.Black;
            this.tbSearchVehicleInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchVehicleInfo.Location = new System.Drawing.Point(169, 31);
            this.tbSearchVehicleInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearchVehicleInfo.Name = "tbSearchVehicleInfo";
            this.tbSearchVehicleInfo.PasswordChar = '\0';
            this.tbSearchVehicleInfo.PlaceholderText = "";
            this.tbSearchVehicleInfo.SelectedText = "";
            this.tbSearchVehicleInfo.Size = new System.Drawing.Size(210, 36);
            this.tbSearchVehicleInfo.TabIndex = 1;
            this.tbSearchVehicleInfo.TextChanged += new System.EventHandler(this.tbSearchVehicleInfo_TextChanged);
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
            "Year",
            "Fuel Type",
            "Category",
            "Milage",
            "Availablity"});
            this.cbFilter.Location = new System.Drawing.Point(504, 31);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(148, 36);
            this.cbFilter.TabIndex = 2;
            this.cbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.BorderRadius = 17;
            this.btnAddNewVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewVehicle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(12)))));
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewVehicle.Image")));
            this.btnAddNewVehicle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewVehicle.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNewVehicle.Location = new System.Drawing.Point(694, 31);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(132, 36);
            this.btnAddNewVehicle.TabIndex = 3;
            this.btnAddNewVehicle.Text = "Add Vehicle";
            this.btnAddNewVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddNewVehicle.TextOffset = new System.Drawing.Point(1, 0);
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(849, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(95, 31);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(68, 32);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Search";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(445, 31);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(53, 32);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Filter";
            // 
            // UC_Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddNewVehicle);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.tbSearchVehicleInfo);
            this.Controls.Add(this.dgvAllVehicles);
            this.Name = "UC_Vehicles";
            this.Size = new System.Drawing.Size(1021, 583);
            this.Load += new System.EventHandler(this.UC_Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllVehicles)).EndInit();
            this.cmsEditDeleteVehcile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAllVehicles;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchVehicleInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddNewVehicle;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsEditDeleteVehcile;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
    }
}
