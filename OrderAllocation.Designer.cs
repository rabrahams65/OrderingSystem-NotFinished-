
namespace OrderingSystem
{
    partial class OrderAllocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderAllocation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimise = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRequestFromFactory = new Guna.UI2.WinForms.Guna2Button();
            this.btnReadyForDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrdersOnHold = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllocatedOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnRepOrders = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.datagridRepOrders = new System.Windows.Forms.DataGridView();
            this.receiptId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGridAllocateCustToRoute = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footerPanelRepOrders = new System.Windows.Forms.Panel();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllocateToRoute = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdRoute = new System.Windows.Forms.ComboBox();
            this.dataGridAllocatedOrders = new System.Windows.Forms.DataGridView();
            this.receiptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAllocatedToRouteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.removeFromRoute = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allocatedOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new OrderingSystem.Dataset.DBDataSet();
            this.allocatedOrdersTableAdapter = new OrderingSystem.Dataset.DBDataSetTableAdapters.AllocatedOrdersTableAdapter();
            this.singleResultsDataSet = new OrderingSystem.Dataset.SingleResultsDataSet();
            this.allocatedIntOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allocatedOrdersIntTableAdapter = new OrderingSystem.Dataset.SingleResultsDataSetTableAdapters.AllocatedOrdersIntTableAdapter();
            this.tableAdapterManager = new OrderingSystem.Dataset.SingleResultsDataSetTableAdapters.TableAdapterManager();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemoveFromRoute = new System.Windows.Forms.Button();
            this.lblTotalAllocatedOrders = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRepOrders)).BeginInit();
            this.footerPanelRepOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllocatedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allocatedOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleResultsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allocatedIntOrdersBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblMinimise);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 63);
            this.panel1.TabIndex = 1;
            // 
            // lblMinimise
            // 
            this.lblMinimise.AutoSize = true;
            this.lblMinimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimise.Location = new System.Drawing.Point(944, 9);
            this.lblMinimise.Name = "lblMinimise";
            this.lblMinimise.Size = new System.Drawing.Size(23, 16);
            this.lblMinimise.TabIndex = 3;
            this.lblMinimise.Text = "__";
            this.lblMinimise.Click += new System.EventHandler(this.lblMinimise_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(972, 13);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(16, 16);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(14, 28);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(221, 20);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Order Allocation / Request";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnRequestFromFactory);
            this.panel2.Controls.Add(this.btnReadyForDelivery);
            this.panel2.Controls.Add(this.btnOrdersOnHold);
            this.panel2.Controls.Add(this.btnAllocatedOrders);
            this.panel2.Controls.Add(this.btnRepOrders);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 42);
            this.panel2.TabIndex = 2;
            // 
            // btnRequestFromFactory
            // 
            this.btnRequestFromFactory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRequestFromFactory.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnRequestFromFactory.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRequestFromFactory.CheckedState.Parent = this.btnRequestFromFactory;
            this.btnRequestFromFactory.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnRequestFromFactory.CustomImages.Parent = this.btnRequestFromFactory;
            this.btnRequestFromFactory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRequestFromFactory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRequestFromFactory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRequestFromFactory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRequestFromFactory.DisabledState.Parent = this.btnRequestFromFactory;
            this.btnRequestFromFactory.FillColor = System.Drawing.Color.White;
            this.btnRequestFromFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestFromFactory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRequestFromFactory.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnRequestFromFactory.HoverState.Parent = this.btnRequestFromFactory;
            this.btnRequestFromFactory.Location = new System.Drawing.Point(468, 2);
            this.btnRequestFromFactory.Name = "btnRequestFromFactory";
            this.btnRequestFromFactory.ShadowDecoration.Parent = this.btnRequestFromFactory;
            this.btnRequestFromFactory.Size = new System.Drawing.Size(169, 45);
            this.btnRequestFromFactory.TabIndex = 0;
            this.btnRequestFromFactory.Text = "Request From Factory";
            this.btnRequestFromFactory.Click += new System.EventHandler(this.btnRequestFromFactory_Click);
            // 
            // btnReadyForDelivery
            // 
            this.btnReadyForDelivery.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReadyForDelivery.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnReadyForDelivery.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnReadyForDelivery.CheckedState.Parent = this.btnReadyForDelivery;
            this.btnReadyForDelivery.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnReadyForDelivery.CustomImages.Parent = this.btnReadyForDelivery;
            this.btnReadyForDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReadyForDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReadyForDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReadyForDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReadyForDelivery.DisabledState.Parent = this.btnReadyForDelivery;
            this.btnReadyForDelivery.FillColor = System.Drawing.Color.White;
            this.btnReadyForDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadyForDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReadyForDelivery.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnReadyForDelivery.HoverState.Parent = this.btnReadyForDelivery;
            this.btnReadyForDelivery.Location = new System.Drawing.Point(643, 3);
            this.btnReadyForDelivery.Name = "btnReadyForDelivery";
            this.btnReadyForDelivery.ShadowDecoration.Parent = this.btnReadyForDelivery;
            this.btnReadyForDelivery.Size = new System.Drawing.Size(149, 45);
            this.btnReadyForDelivery.TabIndex = 0;
            this.btnReadyForDelivery.Text = "Ready For Delivery";
            this.btnReadyForDelivery.Click += new System.EventHandler(this.btnReadyForDelivery_Click);
            // 
            // btnOrdersOnHold
            // 
            this.btnOrdersOnHold.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrdersOnHold.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnOrdersOnHold.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnOrdersOnHold.CheckedState.Parent = this.btnOrdersOnHold;
            this.btnOrdersOnHold.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnOrdersOnHold.CustomImages.Parent = this.btnOrdersOnHold;
            this.btnOrdersOnHold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdersOnHold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdersOnHold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrdersOnHold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrdersOnHold.DisabledState.Parent = this.btnOrdersOnHold;
            this.btnOrdersOnHold.FillColor = System.Drawing.Color.White;
            this.btnOrdersOnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdersOnHold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrdersOnHold.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnOrdersOnHold.HoverState.Parent = this.btnOrdersOnHold;
            this.btnOrdersOnHold.Location = new System.Drawing.Point(313, 2);
            this.btnOrdersOnHold.Name = "btnOrdersOnHold";
            this.btnOrdersOnHold.ShadowDecoration.Parent = this.btnOrdersOnHold;
            this.btnOrdersOnHold.Size = new System.Drawing.Size(149, 45);
            this.btnOrdersOnHold.TabIndex = 0;
            this.btnOrdersOnHold.Text = "Orders On Hold";
            this.btnOrdersOnHold.Click += new System.EventHandler(this.btnOrdersOnHold_Click);
            // 
            // btnAllocatedOrders
            // 
            this.btnAllocatedOrders.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllocatedOrders.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnAllocatedOrders.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAllocatedOrders.CheckedState.Parent = this.btnAllocatedOrders;
            this.btnAllocatedOrders.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAllocatedOrders.CustomImages.Parent = this.btnAllocatedOrders;
            this.btnAllocatedOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllocatedOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllocatedOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllocatedOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllocatedOrders.DisabledState.Parent = this.btnAllocatedOrders;
            this.btnAllocatedOrders.FillColor = System.Drawing.Color.White;
            this.btnAllocatedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocatedOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllocatedOrders.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnAllocatedOrders.HoverState.Parent = this.btnAllocatedOrders;
            this.btnAllocatedOrders.Location = new System.Drawing.Point(158, 3);
            this.btnAllocatedOrders.Name = "btnAllocatedOrders";
            this.btnAllocatedOrders.ShadowDecoration.Parent = this.btnAllocatedOrders;
            this.btnAllocatedOrders.Size = new System.Drawing.Size(149, 45);
            this.btnAllocatedOrders.TabIndex = 0;
            this.btnAllocatedOrders.Text = "Allocated Orders";
            this.btnAllocatedOrders.CheckedChanged += new System.EventHandler(this.btnAllocatedOrders_CheckedChanged);
            this.btnAllocatedOrders.Click += new System.EventHandler(this.btnAllocatedOrders_Click);
            // 
            // btnRepOrders
            // 
            this.btnRepOrders.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRepOrders.Checked = true;
            this.btnRepOrders.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnRepOrders.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRepOrders.CheckedState.Parent = this.btnRepOrders;
            this.btnRepOrders.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnRepOrders.CustomImages.Parent = this.btnRepOrders;
            this.btnRepOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRepOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRepOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRepOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRepOrders.DisabledState.Parent = this.btnRepOrders;
            this.btnRepOrders.FillColor = System.Drawing.Color.White;
            this.btnRepOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRepOrders.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnRepOrders.HoverState.Parent = this.btnRepOrders;
            this.btnRepOrders.Location = new System.Drawing.Point(3, 3);
            this.btnRepOrders.Name = "btnRepOrders";
            this.btnRepOrders.ShadowDecoration.Parent = this.btnRepOrders;
            this.btnRepOrders.Size = new System.Drawing.Size(149, 45);
            this.btnRepOrders.TabIndex = 0;
            this.btnRepOrders.Text = "Rep Orders";
            this.btnRepOrders.CheckedChanged += new System.EventHandler(this.btnRepOrders_CheckedChanged);
            this.btnRepOrders.Click += new System.EventHandler(this.btnRepOrders_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTo);
            this.panel3.Controls.Add(this.lblFrom);
            this.panel3.Controls.Add(this.toDateTimePicker);
            this.panel3.Controls.Add(this.fromDateTimePicker);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1260, 39);
            this.panel3.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(257, 17);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 17);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(286, 14);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 3;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimePicker.Location = new System.Drawing.Point(51, 14);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ImageIndex = 1;
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(1193, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 20);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "211818_search_icon.png");
            this.imageList1.Images.SetKeyName(1, "430112_refresh_icon.png");
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(870, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(659, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // datagridRepOrders
            // 
            this.datagridRepOrders.AllowUserToAddRows = false;
            this.datagridRepOrders.AllowUserToDeleteRows = false;
            this.datagridRepOrders.AllowUserToResizeRows = false;
            this.datagridRepOrders.BackgroundColor = System.Drawing.Color.White;
            this.datagridRepOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridRepOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridRepOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridRepOrders.ColumnHeadersHeight = 40;
            this.datagridRepOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridRepOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptId,
            this.date,
            this.employee,
            this.customerName,
            this.type,
            this.total,
            this.btnGridAllocateCustToRoute,
            this.customerId,
            this.lineItemTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridRepOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridRepOrders.GridColor = System.Drawing.Color.White;
            this.datagridRepOrders.Location = new System.Drawing.Point(0, 180);
            this.datagridRepOrders.Name = "datagridRepOrders";
            this.datagridRepOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridRepOrders.RowHeadersVisible = false;
            this.datagridRepOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.datagridRepOrders.RowTemplate.Height = 40;
            this.datagridRepOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridRepOrders.Size = new System.Drawing.Size(1009, 429);
            this.datagridRepOrders.TabIndex = 5;
            // 
            // receiptId
            // 
            this.receiptId.HeaderText = "Receipt No.";
            this.receiptId.Name = "receiptId";
            this.receiptId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.receiptId.Width = 80;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.Width = 200;
            // 
            // employee
            // 
            this.employee.HeaderText = "Employee";
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            this.employee.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.customerName.Width = 314;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnGridAllocateCustToRoute
            // 
            this.btnGridAllocateCustToRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGridAllocateCustToRoute.HeaderText = "Allocate To Route";
            this.btnGridAllocateCustToRoute.Name = "btnGridAllocateCustToRoute";
            this.btnGridAllocateCustToRoute.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // customerId
            // 
            this.customerId.HeaderText = "customerId";
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            this.customerId.Visible = false;
            // 
            // lineItemTotal
            // 
            this.lineItemTotal.HeaderText = "lineItemTotal";
            this.lineItemTotal.Name = "lineItemTotal";
            this.lineItemTotal.ReadOnly = true;
            this.lineItemTotal.Visible = false;
            // 
            // footerPanelRepOrders
            // 
            this.footerPanelRepOrders.BackColor = System.Drawing.Color.White;
            this.footerPanelRepOrders.Controls.Add(this.panel4);
            this.footerPanelRepOrders.Controls.Add(this.lblTotalRows);
            this.footerPanelRepOrders.Controls.Add(this.label1);
            this.footerPanelRepOrders.Controls.Add(this.btnAllocateToRoute);
            this.footerPanelRepOrders.Controls.Add(this.label5);
            this.footerPanelRepOrders.Controls.Add(this.cmdRoute);
            this.footerPanelRepOrders.Location = new System.Drawing.Point(0, 608);
            this.footerPanelRepOrders.Name = "footerPanelRepOrders";
            this.footerPanelRepOrders.Size = new System.Drawing.Size(1009, 45);
            this.footerPanelRepOrders.TabIndex = 6;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Location = new System.Drawing.Point(82, 14);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(13, 13);
            this.lblTotalRows.TabIndex = 9;
            this.lblTotalRows.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Rows:";
            // 
            // btnAllocateToRoute
            // 
            this.btnAllocateToRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnAllocateToRoute.FlatAppearance.BorderSize = 0;
            this.btnAllocateToRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllocateToRoute.Location = new System.Drawing.Point(884, 9);
            this.btnAllocateToRoute.Name = "btnAllocateToRoute";
            this.btnAllocateToRoute.Size = new System.Drawing.Size(113, 23);
            this.btnAllocateToRoute.TabIndex = 7;
            this.btnAllocateToRoute.Text = "Allocate To Route";
            this.btnAllocateToRoute.UseVisualStyleBackColor = false;
            this.btnAllocateToRoute.Click += new System.EventHandler(this.btnAllocateToRoute_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Choose route:";
            // 
            // cmdRoute
            // 
            this.cmdRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdRoute.FormattingEnabled = true;
            this.cmdRoute.Items.AddRange(new object[] {
            "Route 1",
            "Route 2",
            "Route 3",
            "Route 4"});
            this.cmdRoute.Location = new System.Drawing.Point(757, 10);
            this.cmdRoute.Name = "cmdRoute";
            this.cmdRoute.Size = new System.Drawing.Size(121, 21);
            this.cmdRoute.TabIndex = 0;
            // 
            // dataGridAllocatedOrders
            // 
            this.dataGridAllocatedOrders.AllowUserToAddRows = false;
            this.dataGridAllocatedOrders.AllowUserToDeleteRows = false;
            this.dataGridAllocatedOrders.AllowUserToResizeRows = false;
            this.dataGridAllocatedOrders.AutoGenerateColumns = false;
            this.dataGridAllocatedOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAllocatedOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAllocatedOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllocatedOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAllocatedOrders.ColumnHeadersHeight = 40;
            this.dataGridAllocatedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAllocatedOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.routeNameDataGridViewTextBoxColumn,
            this.isAllocatedToRouteDataGridViewCheckBoxColumn,
            this.removeFromRoute});
            this.dataGridAllocatedOrders.DataSource = this.allocatedOrdersBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAllocatedOrders.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAllocatedOrders.GridColor = System.Drawing.Color.White;
            this.dataGridAllocatedOrders.Location = new System.Drawing.Point(0, 180);
            this.dataGridAllocatedOrders.Name = "dataGridAllocatedOrders";
            this.dataGridAllocatedOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAllocatedOrders.RowHeadersVisible = false;
            this.dataGridAllocatedOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridAllocatedOrders.RowTemplate.Height = 40;
            this.dataGridAllocatedOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAllocatedOrders.Size = new System.Drawing.Size(1009, 378);
            this.dataGridAllocatedOrders.TabIndex = 7;
            // 
            // receiptIdDataGridViewTextBoxColumn
            // 
            this.receiptIdDataGridViewTextBoxColumn.DataPropertyName = "receiptId";
            this.receiptIdDataGridViewTextBoxColumn.HeaderText = "Receipt No.";
            this.receiptIdDataGridViewTextBoxColumn.Name = "receiptIdDataGridViewTextBoxColumn";
            this.receiptIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateDataGridViewTextBoxColumn.Width = 200;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.customerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // routeNameDataGridViewTextBoxColumn
            // 
            this.routeNameDataGridViewTextBoxColumn.DataPropertyName = "routeName";
            this.routeNameDataGridViewTextBoxColumn.HeaderText = "Route Name";
            this.routeNameDataGridViewTextBoxColumn.Name = "routeNameDataGridViewTextBoxColumn";
            this.routeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.routeNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // isAllocatedToRouteDataGridViewCheckBoxColumn
            // 
            this.isAllocatedToRouteDataGridViewCheckBoxColumn.DataPropertyName = "isAllocatedToRoute";
            this.isAllocatedToRouteDataGridViewCheckBoxColumn.HeaderText = "isAllocatedToRoute";
            this.isAllocatedToRouteDataGridViewCheckBoxColumn.Name = "isAllocatedToRouteDataGridViewCheckBoxColumn";
            this.isAllocatedToRouteDataGridViewCheckBoxColumn.Visible = false;
            // 
            // removeFromRoute
            // 
            this.removeFromRoute.HeaderText = "Remove From Route";
            this.removeFromRoute.Name = "removeFromRoute";
            // 
            // allocatedOrdersBindingSource
            // 
            this.allocatedOrdersBindingSource.DataMember = "AllocatedOrders";
            this.allocatedOrdersBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allocatedOrdersTableAdapter
            // 
            this.allocatedOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // singleResultsDataSet
            // 
            this.singleResultsDataSet.DataSetName = "SingleResultsDataSet";
            this.singleResultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allocatedIntOrdersBindingSource
            // 
            this.allocatedIntOrdersBindingSource.DataMember = "AllocatedIntOrders";
            this.allocatedIntOrdersBindingSource.DataSource = this.singleResultsDataSet;
            // 
            // allocatedOrdersIntTableAdapter
            // 
            this.allocatedOrdersIntTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AllocatedOrdersIntTableAdapter = this.allocatedOrdersIntTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = OrderingSystem.Dataset.SingleResultsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRemoveFromRoute);
            this.panel4.Controls.Add(this.lblTotalAllocatedOrders);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1009, 45);
            this.panel4.TabIndex = 8;
            // 
            // btnRemoveFromRoute
            // 
            this.btnRemoveFromRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(39)))));
            this.btnRemoveFromRoute.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromRoute.Location = new System.Drawing.Point(884, 13);
            this.btnRemoveFromRoute.Name = "btnRemoveFromRoute";
            this.btnRemoveFromRoute.Size = new System.Drawing.Size(113, 23);
            this.btnRemoveFromRoute.TabIndex = 2;
            this.btnRemoveFromRoute.Text = "Remove From Route";
            this.btnRemoveFromRoute.UseVisualStyleBackColor = false;
            this.btnRemoveFromRoute.Click += new System.EventHandler(this.btnRemoveFromRoute_Click);
            // 
            // lblTotalAllocatedOrders
            // 
            this.lblTotalAllocatedOrders.AutoSize = true;
            this.lblTotalAllocatedOrders.Location = new System.Drawing.Point(136, 13);
            this.lblTotalAllocatedOrders.Name = "lblTotalAllocatedOrders";
            this.lblTotalAllocatedOrders.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAllocatedOrders.TabIndex = 1;
            this.lblTotalAllocatedOrders.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Allocated Orders:";
            // 
            // OrderAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 840);
            this.Controls.Add(this.dataGridAllocatedOrders);
            this.Controls.Add(this.footerPanelRepOrders);
            this.Controls.Add(this.datagridRepOrders);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "OrderAllocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderAllocation";
            this.Load += new System.EventHandler(this.OrderAllocation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRepOrders)).EndInit();
            this.footerPanelRepOrders.ResumeLayout(false);
            this.footerPanelRepOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllocatedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allocatedOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleResultsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allocatedIntOrdersBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnReadyForDelivery;
        private Guna.UI2.WinForms.Guna2Button btnOrdersOnHold;
        private Guna.UI2.WinForms.Guna2Button btnAllocatedOrders;
        private Guna.UI2.WinForms.Guna2Button btnRepOrders;
        private Guna.UI2.WinForms.Guna2Button btnRequestFromFactory;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lblMinimise;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView datagridRepOrders;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Panel footerPanelRepOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmdRoute;
        private System.Windows.Forms.Button btnAllocateToRoute;
        private System.Windows.Forms.DataGridView dataGridAllocatedOrders;
        private Dataset.DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource allocatedOrdersBindingSource;
        private Dataset.DBDataSetTableAdapters.AllocatedOrdersTableAdapter allocatedOrdersTableAdapter;
        private Dataset.SingleResultsDataSet singleResultsDataSet;
        private System.Windows.Forms.BindingSource allocatedIntOrdersBindingSource;
        private Dataset.SingleResultsDataSetTableAdapters.AllocatedOrdersIntTableAdapter allocatedOrdersIntTableAdapter;
        private Dataset.SingleResultsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRemoveFromRoute;
        private System.Windows.Forms.Label lblTotalAllocatedOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewLinkColumn receiptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btnGridAllocateCustToRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineItemTotal;
        private System.Windows.Forms.DataGridViewLinkColumn receiptIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAllocatedToRouteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn removeFromRoute;
    }
}