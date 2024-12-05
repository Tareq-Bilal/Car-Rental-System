namespace Car_Rental_Project
{
    partial class UC_RentalTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RentalTransactions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbSearchTransactionInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvAllRentalTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsPayTransaction = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmPay = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRentalTransactions)).BeginInit();
            this.cmsPayTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(666, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(37, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 31;
            this.guna2PictureBox1.TabStop = false;
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
            "Highest Actual Total Due Amount",
            "Lowest Actual Total Due Amount",
            "Highest Total Remaining",
            "Lowest Total Remaining"});
            this.cbSort.Location = new System.Drawing.Point(756, 6);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(312, 36);
            this.cbSort.TabIndex = 30;
            this.cbSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(378, 5);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(53, 32);
            this.guna2HtmlLabel5.TabIndex = 29;
            this.guna2HtmlLabel5.Text = "Filter";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(709, 9);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(41, 27);
            this.guna2HtmlLabel3.TabIndex = 28;
            this.guna2HtmlLabel3.Text = "Sort";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(59, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(68, 32);
            this.guna2HtmlLabel1.TabIndex = 27;
            this.guna2HtmlLabel1.Text = "Search";
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
            this.btnRefresh.Location = new System.Drawing.Point(1074, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 37);
            this.btnRefresh.TabIndex = 26;
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
            "Transaction ID",
            "Book ID",
            "Return ID",
            "Paid Initial"});
            this.cbFilter.Location = new System.Drawing.Point(437, 5);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(182, 36);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 25;
            this.cbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbSearchTransactionInfo
            // 
            this.tbSearchTransactionInfo.BorderRadius = 17;
            this.tbSearchTransactionInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchTransactionInfo.DefaultText = "";
            this.tbSearchTransactionInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchTransactionInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchTransactionInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransactionInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransactionInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchTransactionInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.tbSearchTransactionInfo.ForeColor = System.Drawing.Color.Black;
            this.tbSearchTransactionInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchTransactionInfo.Location = new System.Drawing.Point(134, 6);
            this.tbSearchTransactionInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearchTransactionInfo.Name = "tbSearchTransactionInfo";
            this.tbSearchTransactionInfo.PasswordChar = '\0';
            this.tbSearchTransactionInfo.PlaceholderText = "";
            this.tbSearchTransactionInfo.SelectedText = "";
            this.tbSearchTransactionInfo.Size = new System.Drawing.Size(205, 36);
            this.tbSearchTransactionInfo.TabIndex = 24;
            this.tbSearchTransactionInfo.TextChanged += new System.EventHandler(this.tbSearchTransactionInfo_TextChanged);
            // 
            // dgvAllRentalTransactions
            // 
            this.dgvAllRentalTransactions.AllowUserToAddRows = false;
            this.dgvAllRentalTransactions.AllowUserToDeleteRows = false;
            this.dgvAllRentalTransactions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dgvAllRentalTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllRentalTransactions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllRentalTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllRentalTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllRentalTransactions.ColumnHeadersHeight = 25;
            this.dgvAllRentalTransactions.ContextMenuStrip = this.cmsPayTransaction;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllRentalTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllRentalTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllRentalTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dgvAllRentalTransactions.Location = new System.Drawing.Point(0, 103);
            this.dgvAllRentalTransactions.Name = "dgvAllRentalTransactions";
            this.dgvAllRentalTransactions.ReadOnly = true;
            this.dgvAllRentalTransactions.RowHeadersVisible = false;
            this.dgvAllRentalTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllRentalTransactions.RowTemplate.Height = 30;
            this.dgvAllRentalTransactions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllRentalTransactions.Size = new System.Drawing.Size(1135, 480);
            this.dgvAllRentalTransactions.TabIndex = 23;
            this.dgvAllRentalTransactions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.dgvAllRentalTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dgvAllRentalTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllRentalTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllRentalTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllRentalTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllRentalTransactions.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvAllRentalTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dgvAllRentalTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.dgvAllRentalTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAllRentalTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllRentalTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllRentalTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllRentalTransactions.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvAllRentalTransactions.ThemeStyle.ReadOnly = true;
            this.dgvAllRentalTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.dgvAllRentalTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllRentalTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllRentalTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllRentalTransactions.ThemeStyle.RowsStyle.Height = 30;
            this.dgvAllRentalTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.dgvAllRentalTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllRentalTransactions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAllRentalTransactions_CellFormatting);
            // 
            // cmsPayTransaction
            // 
            this.cmsPayTransaction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPay});
            this.cmsPayTransaction.Name = "guna2ContextMenuStrip1";
            this.cmsPayTransaction.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsPayTransaction.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsPayTransaction.RenderStyle.ColorTable = null;
            this.cmsPayTransaction.RenderStyle.RoundedEdges = true;
            this.cmsPayTransaction.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsPayTransaction.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsPayTransaction.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsPayTransaction.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsPayTransaction.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsPayTransaction.Size = new System.Drawing.Size(181, 52);
            this.cmsPayTransaction.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPayTransaction_Opening);
            // 
            // tsmPay
            // 
            this.tsmPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmPay.Image = ((System.Drawing.Image)(resources.GetObject("tsmPay.Image")));
            this.tsmPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmPay.Name = "tsmPay";
            this.tsmPay.Size = new System.Drawing.Size(180, 26);
            this.tsmPay.Text = "Pay";
            this.tsmPay.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmPay.Click += new System.EventHandler(this.tsmPay_Click);
            // 
            // UC_RentalTransactions
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
            this.Controls.Add(this.tbSearchTransactionInfo);
            this.Controls.Add(this.dgvAllRentalTransactions);
            this.Name = "UC_RentalTransactions";
            this.Size = new System.Drawing.Size(1135, 583);
            this.Load += new System.EventHandler(this.UC_RentalTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRentalTransactions)).EndInit();
            this.cmsPayTransaction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSort;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchTransactionInfo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAllRentalTransactions;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsPayTransaction;
        private System.Windows.Forms.ToolStripMenuItem tsmPay;
    }
}
