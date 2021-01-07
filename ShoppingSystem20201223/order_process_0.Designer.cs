namespace ShoppingSystem20201223
{
    partial class order_process_0
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_process_0));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.订单编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品总额DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.交易日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收货地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gOODSDataSet7 = new ShoppingSystem20201223.GOODSDataSet7();
            this.gOODSDataSet4 = new ShoppingSystem20201223.GOODSDataSet4();
            this.user_orderTableAdapter = new ShoppingSystem20201223.GOODSDataSet4TableAdapters.user_orderTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未处理发货订单0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已发货订单1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退款售后订单2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已完成订单4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户基本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.user_orderTableAdapter1 = new ShoppingSystem20201223.GOODSDataSet7TableAdapters.user_orderTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正姚体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "未读/未发货订单管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 739);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "当前发现未处理订单：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.订单编号DataGridViewTextBoxColumn,
            this.商品数量DataGridViewTextBoxColumn,
            this.商品总额DataGridViewTextBoxColumn,
            this.交易日期DataGridViewTextBoxColumn,
            this.订单状态DataGridViewTextBoxColumn,
            this.收货地址});
            this.dataGridView1.DataSource = this.userorderBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(47, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(933, 349);
            this.dataGridView1.TabIndex = 18;
            // 
            // 订单编号DataGridViewTextBoxColumn
            // 
            this.订单编号DataGridViewTextBoxColumn.DataPropertyName = "订单编号";
            this.订单编号DataGridViewTextBoxColumn.HeaderText = "订单编号";
            this.订单编号DataGridViewTextBoxColumn.Name = "订单编号DataGridViewTextBoxColumn";
            // 
            // 商品数量DataGridViewTextBoxColumn
            // 
            this.商品数量DataGridViewTextBoxColumn.DataPropertyName = "商品数量";
            this.商品数量DataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.商品数量DataGridViewTextBoxColumn.Name = "商品数量DataGridViewTextBoxColumn";
            // 
            // 商品总额DataGridViewTextBoxColumn
            // 
            this.商品总额DataGridViewTextBoxColumn.DataPropertyName = "商品总额";
            this.商品总额DataGridViewTextBoxColumn.HeaderText = "商品总额";
            this.商品总额DataGridViewTextBoxColumn.Name = "商品总额DataGridViewTextBoxColumn";
            // 
            // 交易日期DataGridViewTextBoxColumn
            // 
            this.交易日期DataGridViewTextBoxColumn.DataPropertyName = "交易日期";
            this.交易日期DataGridViewTextBoxColumn.HeaderText = "交易日期";
            this.交易日期DataGridViewTextBoxColumn.Name = "交易日期DataGridViewTextBoxColumn";
            // 
            // 订单状态DataGridViewTextBoxColumn
            // 
            this.订单状态DataGridViewTextBoxColumn.DataPropertyName = "订单状态";
            this.订单状态DataGridViewTextBoxColumn.HeaderText = "订单状态";
            this.订单状态DataGridViewTextBoxColumn.Name = "订单状态DataGridViewTextBoxColumn";
            // 
            // 收货地址
            // 
            this.收货地址.DataPropertyName = "收货地址";
            this.收货地址.HeaderText = "收货地址";
            this.收货地址.Name = "收货地址";
            // 
            // userorderBindingSource
            // 
            this.userorderBindingSource.DataMember = "user_order";
            this.userorderBindingSource.DataSource = this.gOODSDataSet7;
            // 
            // gOODSDataSet7
            // 
            this.gOODSDataSet7.DataSetName = "GOODSDataSet7";
            this.gOODSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gOODSDataSet4
            // 
            this.gOODSDataSet4.DataSetName = "GOODSDataSet4";
            this.gOODSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_orderTableAdapter
            // 
            this.user_orderTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(12, 685);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 51);
            this.button1.TabIndex = 20;
            this.button1.Text = "确认发货";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(723, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 122);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "排序：交易时间";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(137, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 36);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "降序";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 36);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "升序";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("方正姚体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 523);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 25;
            this.label3.Text = "发货物流：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("方正姚体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 576);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 37);
            this.label4.TabIndex = 27;
            this.label4.Text = "快递单号：";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(199, 576);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 39);
            this.textBox2.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 524);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 40);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(191, 685);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 51);
            this.button2.TabIndex = 30;
            this.button2.Text = "退出界面";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.BackgroundImage = global::ShoppingSystem20201223.Properties.Resources.psc;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品管理ToolStripMenuItem,
            this.添加商品ToolStripMenuItem,
            this.订单管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.管理员中心ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 35);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "用户菜单";
            // 
            // 商品管理ToolStripMenuItem
            // 
            this.商品管理ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
            this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(120, 31);
            this.商品管理ToolStripMenuItem.Text = "商品管理";
            this.商品管理ToolStripMenuItem.Click += new System.EventHandler(this.商品管理ToolStripMenuItem_Click);
            // 
            // 添加商品ToolStripMenuItem
            // 
            this.添加商品ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.添加商品ToolStripMenuItem.Name = "添加商品ToolStripMenuItem";
            this.添加商品ToolStripMenuItem.Size = new System.Drawing.Size(120, 31);
            this.添加商品ToolStripMenuItem.Text = "添加商品";
            this.添加商品ToolStripMenuItem.Click += new System.EventHandler(this.添加商品ToolStripMenuItem_Click);
            // 
            // 订单管理ToolStripMenuItem
            // 
            this.订单管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.未处理发货订单0ToolStripMenuItem,
            this.已发货订单1ToolStripMenuItem,
            this.退款售后订单2ToolStripMenuItem,
            this.已完成订单4ToolStripMenuItem});
            this.订单管理ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.订单管理ToolStripMenuItem.Name = "订单管理ToolStripMenuItem";
            this.订单管理ToolStripMenuItem.Size = new System.Drawing.Size(120, 31);
            this.订单管理ToolStripMenuItem.Text = "订单管理";
            this.订单管理ToolStripMenuItem.Click += new System.EventHandler(this.订单管理ToolStripMenuItem_Click);
            // 
            // 未处理发货订单0ToolStripMenuItem
            // 
            this.未处理发货订单0ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("未处理发货订单0ToolStripMenuItem.BackgroundImage")));
            this.未处理发货订单0ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.未处理发货订单0ToolStripMenuItem.Name = "未处理发货订单0ToolStripMenuItem";
            this.未处理发货订单0ToolStripMenuItem.Size = new System.Drawing.Size(331, 32);
            this.未处理发货订单0ToolStripMenuItem.Text = "未处理/发货订单（0）";
            this.未处理发货订单0ToolStripMenuItem.Click += new System.EventHandler(this.未处理发货订单0ToolStripMenuItem_Click);
            // 
            // 已发货订单1ToolStripMenuItem
            // 
            this.已发货订单1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("已发货订单1ToolStripMenuItem.BackgroundImage")));
            this.已发货订单1ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.已发货订单1ToolStripMenuItem.Name = "已发货订单1ToolStripMenuItem";
            this.已发货订单1ToolStripMenuItem.Size = new System.Drawing.Size(331, 32);
            this.已发货订单1ToolStripMenuItem.Text = "已发货订单（1）";
            this.已发货订单1ToolStripMenuItem.Click += new System.EventHandler(this.已发货订单1ToolStripMenuItem_Click);
            // 
            // 退款售后订单2ToolStripMenuItem
            // 
            this.退款售后订单2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("退款售后订单2ToolStripMenuItem.BackgroundImage")));
            this.退款售后订单2ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.退款售后订单2ToolStripMenuItem.Name = "退款售后订单2ToolStripMenuItem";
            this.退款售后订单2ToolStripMenuItem.Size = new System.Drawing.Size(331, 32);
            this.退款售后订单2ToolStripMenuItem.Text = "退款/售后订单（3）";
            this.退款售后订单2ToolStripMenuItem.Click += new System.EventHandler(this.退款售后订单2ToolStripMenuItem_Click);
            // 
            // 已完成订单4ToolStripMenuItem
            // 
            this.已完成订单4ToolStripMenuItem.BackgroundImage = global::ShoppingSystem20201223.Properties.Resources.psc;
            this.已完成订单4ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.已完成订单4ToolStripMenuItem.Name = "已完成订单4ToolStripMenuItem";
            this.已完成订单4ToolStripMenuItem.Size = new System.Drawing.Size(331, 32);
            this.已完成订单4ToolStripMenuItem.Text = "已完成订单（4）";
            this.已完成订单4ToolStripMenuItem.Click += new System.EventHandler(this.已完成订单4ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(120, 31);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 管理员中心ToolStripMenuItem
            // 
            this.管理员中心ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.管理员中心ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户基本信息ToolStripMenuItem,
            this.更改密码ToolStripMenuItem});
            this.管理员中心ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.管理员中心ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.管理员中心ToolStripMenuItem.Name = "管理员中心ToolStripMenuItem";
            this.管理员中心ToolStripMenuItem.Size = new System.Drawing.Size(144, 31);
            this.管理员中心ToolStripMenuItem.Text = "管理员中心";
            // 
            // 用户基本信息ToolStripMenuItem
            // 
            this.用户基本信息ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("用户基本信息ToolStripMenuItem.BackgroundImage")));
            this.用户基本信息ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.用户基本信息ToolStripMenuItem.Name = "用户基本信息ToolStripMenuItem";
            this.用户基本信息ToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.用户基本信息ToolStripMenuItem.Text = "管理员基本信息";
            this.用户基本信息ToolStripMenuItem.Click += new System.EventHandler(this.用户基本信息ToolStripMenuItem_Click);
            // 
            // 更改密码ToolStripMenuItem
            // 
            this.更改密码ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("更改密码ToolStripMenuItem.BackgroundImage")));
            this.更改密码ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem";
            this.更改密码ToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.更改密码ToolStripMenuItem.Text = "更改密码";
            this.更改密码ToolStripMenuItem.Click += new System.EventHandler(this.更改密码ToolStripMenuItem_Click);
            // 
            // user_orderTableAdapter1
            // 
            this.user_orderTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(580, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "TIPS:请选中整行订单数据再点击“确认发货”";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Thistle;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Indigo;
            this.button3.Location = new System.Drawing.Point(370, 685);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 51);
            this.button3.TabIndex = 33;
            this.button3.Text = "刷新页面";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("方正姚体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 629);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 37);
            this.label6.TabIndex = 34;
            this.label6.Text = "发货地址：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(199, 629);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 39);
            this.textBox1.TabIndex = 35;
            // 
            // order_process_0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShoppingSystem20201223.Properties.Resources.psc__2_;
            this.ClientSize = new System.Drawing.Size(1024, 797);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "order_process_0";
            this.Text = "未读/未发货订单管理";
            this.Load += new System.EventHandler(this.order_process_0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GOODSDataSet1 gOODSDataSet1;
        private GOODSDataSet4 gOODSDataSet4;
        private System.Windows.Forms.BindingSource userorderBindingSource;
        private GOODSDataSet4TableAdapters.user_orderTableAdapter user_orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品总额DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 交易日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 未处理发货订单0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已发货订单1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退款售后订单2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户基本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private GOODSDataSet7 gOODSDataSet7;
        private GOODSDataSet7TableAdapters.user_orderTableAdapter user_orderTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收货地址;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem 已完成订单4ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}