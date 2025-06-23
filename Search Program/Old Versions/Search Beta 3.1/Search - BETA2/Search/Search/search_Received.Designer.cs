namespace csvToGrid
{
	partial class search_Received
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
            System.Windows.Forms.Label cust_NameLabel;
            System.Windows.Forms.Label drugLabel;
            System.Windows.Forms.Label fill_DateLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label scriptLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_Received));
            this.button8 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.script_OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinneyDatabaseDataSet = new csvToGrid.KinneyDatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scriptTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.fill_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.drugTextBox = new System.Windows.Forms.TextBox();
            this.cust_NameTextBox = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.script_OrdersTableAdapter = new csvToGrid.KinneyDatabaseDataSetTableAdapters.script_OrdersTableAdapter();
            this.tableAdapterManager = new csvToGrid.KinneyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.clearImagebutton = new System.Windows.Forms.Button();
            this.ChooseImageButton = new System.Windows.Forms.Button();
            cust_NameLabel = new System.Windows.Forms.Label();
            drugLabel = new System.Windows.Forms.Label();
            fill_DateLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            scriptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.script_OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinneyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cust_NameLabel
            // 
            cust_NameLabel.AutoSize = true;
            cust_NameLabel.Location = new System.Drawing.Point(25, 30);
            cust_NameLabel.Name = "cust_NameLabel";
            cust_NameLabel.Size = new System.Drawing.Size(85, 13);
            cust_NameLabel.TabIndex = 49;
            cust_NameLabel.Text = "Customer Name:";
            cust_NameLabel.Click += new System.EventHandler(this.cust_NameLabel_Click);
            // 
            // drugLabel
            // 
            drugLabel.AutoSize = true;
            drugLabel.Location = new System.Drawing.Point(26, 62);
            drugLabel.Name = "drugLabel";
            drugLabel.Size = new System.Drawing.Size(33, 13);
            drugLabel.TabIndex = 51;
            drugLabel.Text = "Drug:";
            drugLabel.Click += new System.EventHandler(this.drugLabel_Click);
            // 
            // fill_DateLabel
            // 
            fill_DateLabel.AutoSize = true;
            fill_DateLabel.Location = new System.Drawing.Point(26, 100);
            fill_DateLabel.Name = "fill_DateLabel";
            fill_DateLabel.Size = new System.Drawing.Size(48, 13);
            fill_DateLabel.TabIndex = 52;
            fill_DateLabel.Text = "Fill Date:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(283, 30);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(46, 13);
            qtyLabel.TabIndex = 53;
            qtyLabel.Text = "Quanity:";
            // 
            // scriptLabel
            // 
            scriptLabel.AutoSize = true;
            scriptLabel.Location = new System.Drawing.Point(286, 65);
            scriptLabel.Name = "scriptLabel";
            scriptLabel.Size = new System.Drawing.Size(37, 13);
            scriptLabel.TabIndex = 54;
            scriptLabel.Text = "Script:";
            scriptLabel.Click += new System.EventHandler(this.scriptLabel_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(546, 305);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 25);
            this.button8.TabIndex = 11;
            this.button8.Text = "Print results";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.script_OrdersBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonUpdateItem,
            this.toolStripButtonRefresh});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(754, 25);
            this.bindingNavigator1.TabIndex = 33;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // script_OrdersBindingSource
            // 
            this.script_OrdersBindingSource.DataMember = "script_Orders";
            this.script_OrdersBindingSource.DataSource = this.kinneyDatabaseDataSet;
            // 
            // kinneyDatabaseDataSet
            // 
            this.kinneyDatabaseDataSet.DataSetName = "KinneyDatabaseDataSet";
            this.kinneyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator.Click += new System.EventHandler(this.bindingNavigatorSeparator_Click);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator1.Click += new System.EventHandler(this.bindingNavigatorSeparator1_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator2.Click += new System.EventHandler(this.bindingNavigatorSeparator2_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.Crimson;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButtonUpdateItem
            // 
            this.toolStripButtonUpdateItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButtonUpdateItem.Image = global::csvToGrid.Properties.Resources.floppy;
            this.toolStripButtonUpdateItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateItem.Name = "toolStripButtonUpdateItem";
            this.toolStripButtonUpdateItem.Size = new System.Drawing.Size(98, 22);
            this.toolStripButtonUpdateItem.Text = "Save | Update";
            this.toolStripButtonUpdateItem.Click += new System.EventHandler(this.toolStripButtonUpdateItem_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.ForeColor = System.Drawing.Color.Lime;
            this.toolStripButtonRefresh.Image = global::csvToGrid.Properties.Resources.refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csvToGrid.Properties.Resources.RxReconcile1;
            this.pictureBox1.Location = new System.Drawing.Point(521, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(754, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(scriptLabel);
            this.groupBox1.Controls.Add(this.scriptTextBox);
            this.groupBox1.Controls.Add(qtyLabel);
            this.groupBox1.Controls.Add(this.qtyTextBox);
            this.groupBox1.Controls.Add(fill_DateLabel);
            this.groupBox1.Controls.Add(this.fill_DateDateTimePicker);
            this.groupBox1.Controls.Add(drugLabel);
            this.groupBox1.Controls.Add(this.drugTextBox);
            this.groupBox1.Controls.Add(cust_NameLabel);
            this.groupBox1.Controls.Add(this.cust_NameTextBox);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 285);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // scriptTextBox
            // 
            this.scriptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.script_OrdersBindingSource, "script", true));
            this.scriptTextBox.Location = new System.Drawing.Point(329, 62);
            this.scriptTextBox.Name = "scriptTextBox";
            this.scriptTextBox.Size = new System.Drawing.Size(155, 20);
            this.scriptTextBox.TabIndex = 55;
            this.scriptTextBox.TextChanged += new System.EventHandler(this.scriptTextBox_TextChanged);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.script_OrdersBindingSource, "qty", true));
            this.qtyTextBox.Location = new System.Drawing.Point(329, 27);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(155, 20);
            this.qtyTextBox.TabIndex = 54;
            // 
            // fill_DateDateTimePicker
            // 
            this.fill_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.script_OrdersBindingSource, "fill_Date", true));
            this.fill_DateDateTimePicker.Location = new System.Drawing.Point(115, 100);
            this.fill_DateDateTimePicker.Name = "fill_DateDateTimePicker";
            this.fill_DateDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.fill_DateDateTimePicker.TabIndex = 53;
            this.fill_DateDateTimePicker.ValueChanged += new System.EventHandler(this.fill_DateDateTimePicker_ValueChanged);
            // 
            // drugTextBox
            // 
            this.drugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.script_OrdersBindingSource, "drug", true));
            this.drugTextBox.Location = new System.Drawing.Point(116, 62);
            this.drugTextBox.Name = "drugTextBox";
            this.drugTextBox.Size = new System.Drawing.Size(161, 20);
            this.drugTextBox.TabIndex = 52;
            // 
            // cust_NameTextBox
            // 
            this.cust_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.script_OrdersBindingSource, "cust_Name", true));
            this.cust_NameTextBox.Location = new System.Drawing.Point(116, 27);
            this.cust_NameTextBox.Name = "cust_NameTextBox";
            this.cust_NameTextBox.Size = new System.Drawing.Size(161, 20);
            this.cust_NameTextBox.TabIndex = 50;
            this.cust_NameTextBox.TextChanged += new System.EventHandler(this.cust_NameTextBox_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(320, 218);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 28);
            this.buttonExit.TabIndex = 49;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(29, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 294);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer List:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.scriptDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.drugDataGridViewTextBoxColumn,
            this.fillDateDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.script_OrdersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(652, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scriptDataGridViewTextBoxColumn
            // 
            this.scriptDataGridViewTextBoxColumn.DataPropertyName = "script";
            this.scriptDataGridViewTextBoxColumn.HeaderText = "script";
            this.scriptDataGridViewTextBoxColumn.Name = "scriptDataGridViewTextBoxColumn";
            this.scriptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "cust_Name";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "cust_Name";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugDataGridViewTextBoxColumn
            // 
            this.drugDataGridViewTextBoxColumn.DataPropertyName = "drug";
            this.drugDataGridViewTextBoxColumn.HeaderText = "drug";
            this.drugDataGridViewTextBoxColumn.Name = "drugDataGridViewTextBoxColumn";
            this.drugDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fillDateDataGridViewTextBoxColumn
            // 
            this.fillDateDataGridViewTextBoxColumn.DataPropertyName = "fill_Date";
            this.fillDateDataGridViewTextBoxColumn.HeaderText = "fill_Date";
            this.fillDateDataGridViewTextBoxColumn.Name = "fillDateDataGridViewTextBoxColumn";
            this.fillDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // script_OrdersTableAdapter
            // 
            this.script_OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.script_OrdersTableAdapter = this.script_OrdersTableAdapter;
            this.tableAdapterManager.script_ReceivedTableAdapter = null;
            this.tableAdapterManager.script_ReturnedTableAdapter = null;
            this.tableAdapterManager.script_UnorderedTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = csvToGrid.KinneyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.script_OrdersBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(546, 138);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(127, 124);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 37;
            this.photoPictureBox.TabStop = false;
            // 
            // clearImagebutton
            // 
            this.clearImagebutton.Location = new System.Drawing.Point(546, 268);
            this.clearImagebutton.Name = "clearImagebutton";
            this.clearImagebutton.Size = new System.Drawing.Size(75, 25);
            this.clearImagebutton.TabIndex = 38;
            this.clearImagebutton.Text = "Clear Image";
            this.clearImagebutton.UseVisualStyleBackColor = true;
            this.clearImagebutton.Click += new System.EventHandler(this.clearImagebutton_Click);
            // 
            // ChooseImageButton
            // 
            this.ChooseImageButton.Location = new System.Drawing.Point(634, 268);
            this.ChooseImageButton.Name = "ChooseImageButton";
            this.ChooseImageButton.Size = new System.Drawing.Size(88, 25);
            this.ChooseImageButton.TabIndex = 39;
            this.ChooseImageButton.Text = "Choose Image";
            this.ChooseImageButton.UseVisualStyleBackColor = true;
            this.ChooseImageButton.Click += new System.EventHandler(this.ChooseImageButton_Click);
            // 
            // search_Received
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 680);
            this.Controls.Add(this.ChooseImageButton);
            this.Controls.Add(this.clearImagebutton);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "search_Received";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Ordered Products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.search_Received_FormClosing);
            this.Load += new System.EventHandler(this.search_Received_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.script_OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinneyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KinneyDatabaseDataSet kinneyDatabaseDataSet;
        private System.Windows.Forms.BindingSource script_OrdersBindingSource;
        private KinneyDatabaseDataSetTableAdapters.script_OrdersTableAdapter script_OrdersTableAdapter;
        private KinneyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cust_NameTextBox;
        private System.Windows.Forms.TextBox drugTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.DateTimePicker fill_DateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fillDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox scriptTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button clearImagebutton;
        private System.Windows.Forms.Button ChooseImageButton;
    }
}