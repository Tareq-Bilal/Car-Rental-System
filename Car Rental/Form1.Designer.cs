namespace Car_Rental_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Home = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVehicleReturns = new Guna.UI2.WinForms.Guna2Button();
            this.btnRentalTransaction = new Guna.UI2.WinForms.Guna2Button();
            this.btnRentalBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_VehicleReturns1 = new Car_Rental_Project.UC_VehicleReturns();
            this.uC_RentalTransactions1 = new Car_Rental_Project.UC_RentalTransactions();
            this.uC_RentalBooking1 = new Car_Rental_Project.UC_RentalBooking();
            this.uC_Customers1 = new Car_Rental_Project.UC_Customers();
            this.uC_Vehicles1 = new Car_Rental_Project.UC_Vehicles();
            this.uC_Dashboard1 = new Car_Rental_Project.UC_Dashboard();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BorderRadius = 20;
            this.Home.TargetForm = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnVehicleReturns);
            this.guna2Panel1.Controls.Add(this.btnRentalTransaction);
            this.guna2Panel1.Controls.Add(this.btnRentalBooking);
            this.guna2Panel1.Controls.Add(this.btnCustomers);
            this.guna2Panel1.Controls.Add(this.btnVehicles);
            this.guna2Panel1.Controls.Add(this.btnDashboard);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.guna2Panel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.guna2Panel1.Size = new System.Drawing.Size(190, 630);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnVehicleReturns
            // 
            this.btnVehicleReturns.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVehicleReturns.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnVehicleReturns.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnVehicleReturns.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleReturns.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicleReturns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicleReturns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicleReturns.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnVehicleReturns.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleReturns.ForeColor = System.Drawing.Color.White;
            this.btnVehicleReturns.Image = ((System.Drawing.Image)(resources.GetObject("btnVehicleReturns.Image")));
            this.btnVehicleReturns.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicleReturns.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVehicleReturns.Location = new System.Drawing.Point(0, 438);
            this.btnVehicleReturns.Name = "btnVehicleReturns";
            this.btnVehicleReturns.PressedDepth = 0;
            this.btnVehicleReturns.Size = new System.Drawing.Size(190, 60);
            this.btnVehicleReturns.TabIndex = 5;
            this.btnVehicleReturns.Text = "Vehicle Returns";
            this.btnVehicleReturns.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicleReturns.TextOffset = new System.Drawing.Point(11, 0);
            this.btnVehicleReturns.CheckedChanged += new System.EventHandler(this.btnVehicleReturns_CheckedChanged);
            // 
            // btnRentalTransaction
            // 
            this.btnRentalTransaction.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRentalTransaction.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnRentalTransaction.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRentalTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRentalTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRentalTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRentalTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRentalTransaction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnRentalTransaction.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalTransaction.ForeColor = System.Drawing.Color.White;
            this.btnRentalTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnRentalTransaction.Image")));
            this.btnRentalTransaction.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRentalTransaction.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRentalTransaction.Location = new System.Drawing.Point(0, 372);
            this.btnRentalTransaction.Name = "btnRentalTransaction";
            this.btnRentalTransaction.PressedDepth = 0;
            this.btnRentalTransaction.Size = new System.Drawing.Size(190, 60);
            this.btnRentalTransaction.TabIndex = 4;
            this.btnRentalTransaction.Text = "Rental Transaction";
            this.btnRentalTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRentalTransaction.TextOffset = new System.Drawing.Point(11, 0);
            this.btnRentalTransaction.CheckedChanged += new System.EventHandler(this.btnRentalTransaction_CheckedChanged);
            // 
            // btnRentalBooking
            // 
            this.btnRentalBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRentalBooking.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnRentalBooking.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRentalBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRentalBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRentalBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRentalBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRentalBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnRentalBooking.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalBooking.ForeColor = System.Drawing.Color.White;
            this.btnRentalBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnRentalBooking.Image")));
            this.btnRentalBooking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRentalBooking.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRentalBooking.Location = new System.Drawing.Point(0, 306);
            this.btnRentalBooking.Name = "btnRentalBooking";
            this.btnRentalBooking.PressedDepth = 0;
            this.btnRentalBooking.Size = new System.Drawing.Size(190, 60);
            this.btnRentalBooking.TabIndex = 3;
            this.btnRentalBooking.Text = "Rental Booking";
            this.btnRentalBooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRentalBooking.TextOffset = new System.Drawing.Point(11, 0);
            this.btnRentalBooking.CheckedChanged += new System.EventHandler(this.btnRentalBooking_CheckedChanged);
            this.btnRentalBooking.Click += new System.EventHandler(this.btnRentalBooking_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomers.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnCustomers.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnCustomers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomers.Location = new System.Drawing.Point(0, 240);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.PressedDepth = 0;
            this.btnCustomers.Size = new System.Drawing.Size(190, 60);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.TextOffset = new System.Drawing.Point(11, 0);
            this.btnCustomers.CheckedChanged += new System.EventHandler(this.btnCustomers_CheckedChanged);
            // 
            // btnVehicles
            // 
            this.btnVehicles.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVehicles.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnVehicles.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnVehicles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnVehicles.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.Image = ((System.Drawing.Image)(resources.GetObject("btnVehicles.Image")));
            this.btnVehicles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicles.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVehicles.Location = new System.Drawing.Point(0, 183);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.PressedDepth = 0;
            this.btnVehicles.Size = new System.Drawing.Size(190, 60);
            this.btnVehicles.TabIndex = 1;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicles.TextOffset = new System.Drawing.Point(11, 0);
            this.btnVehicles.CheckedChanged += new System.EventHandler(this.btnVehicles_CheckedChanged);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnDashboard.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(0, 123);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedDepth = 0;
            this.btnDashboard.Size = new System.Drawing.Size(190, 60);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(11, 0);
            this.btnDashboard.CheckedChanged += new System.EventHandler(this.btnDashboard_CheckedChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Location = new System.Drawing.Point(196, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1135, 40);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(1045, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 37);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(72)))), ((int)(((byte)(78)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1090, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 37);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.Controls.Add(this.uC_VehicleReturns1);
            this.guna2Panel3.Controls.Add(this.uC_RentalTransactions1);
            this.guna2Panel3.Controls.Add(this.uC_RentalBooking1);
            this.guna2Panel3.Controls.Add(this.uC_Customers1);
            this.guna2Panel3.Controls.Add(this.uC_Vehicles1);
            this.guna2Panel3.Controls.Add(this.uC_Dashboard1);
            this.guna2Panel3.Location = new System.Drawing.Point(196, 47);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1139, 583);
            this.guna2Panel3.TabIndex = 2;
            // 
            // uC_VehicleReturns1
            // 
            this.uC_VehicleReturns1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_VehicleReturns1.Location = new System.Drawing.Point(0, 0);
            this.uC_VehicleReturns1.Name = "uC_VehicleReturns1";
            this.uC_VehicleReturns1.Size = new System.Drawing.Size(1139, 583);
            this.uC_VehicleReturns1.TabIndex = 5;
            this.uC_VehicleReturns1.Load += new System.EventHandler(this.uC_VehicleReturns1_Load);
            // 
            // uC_RentalTransactions1
            // 
            this.uC_RentalTransactions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_RentalTransactions1.Location = new System.Drawing.Point(0, 0);
            this.uC_RentalTransactions1.Name = "uC_RentalTransactions1";
            this.uC_RentalTransactions1.Size = new System.Drawing.Size(1139, 583);
            this.uC_RentalTransactions1.TabIndex = 4;
            // 
            // uC_RentalBooking1
            // 
            this.uC_RentalBooking1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_RentalBooking1.Location = new System.Drawing.Point(0, 0);
            this.uC_RentalBooking1.Name = "uC_RentalBooking1";
            this.uC_RentalBooking1.Size = new System.Drawing.Size(1139, 583);
            this.uC_RentalBooking1.TabIndex = 3;
            // 
            // uC_Customers1
            // 
            this.uC_Customers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Customers1.Location = new System.Drawing.Point(0, 0);
            this.uC_Customers1.Name = "uC_Customers1";
            this.uC_Customers1.Size = new System.Drawing.Size(1139, 583);
            this.uC_Customers1.TabIndex = 2;
            // 
            // uC_Vehicles1
            // 
            this.uC_Vehicles1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Vehicles1.Location = new System.Drawing.Point(0, 0);
            this.uC_Vehicles1.Name = "uC_Vehicles1";
            this.uC_Vehicles1.Size = new System.Drawing.Size(1139, 583);
            this.uC_Vehicles1.TabIndex = 1;
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1139, 583);
            this.uC_Dashboard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 630);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm Home;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnVehicleReturns;
        private Guna.UI2.WinForms.Guna2Button btnRentalTransaction;
        private Guna.UI2.WinForms.Guna2Button btnRentalBooking;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnVehicles;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private UC_Dashboard uC_Dashboard1;
        private UC_Vehicles uC_Vehicles1;
        private UC_VehicleReturns uC_VehicleReturns1;
        private UC_RentalTransactions uC_RentalTransactions1;
        private UC_RentalBooking uC_RentalBooking1;
        private UC_Customers uC_Customers1;
    }
}

