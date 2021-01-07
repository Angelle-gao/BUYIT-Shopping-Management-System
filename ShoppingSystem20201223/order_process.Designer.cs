namespace ShoppingSystem20201223
{
    partial class order_process
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_process));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收货地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gOODSDataSet7 = new ShoppingSystem20201223.GOODSDataSet7();
            this.gOODSDataSet5 = new ShoppingSystem20201223.GOODSDataSet5();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.user_orderTableAdapter2 = new ShoppingSystem20201223.GOODSDataSet5TableAdapters.user_orderTableAdapter();
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
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.user_orderTableAdapter3 = new ShoppingSystem20201223.GOODSDataSet7TableAdapters.user_orderTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet5)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(315, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "商家订单管理中心";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.收货地址});
            this.dataGridView1.DataSource = this.userorderBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(71, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(836, 421);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "订单编号";
            this.dataGridViewTextBoxColumn6.HeaderText = "订单编号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "商品数量";
            this.dataGridViewTextBoxColumn7.HeaderText = "商品数量";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "商品总额";
            this.dataGridViewTextBoxColumn8.HeaderText = "商品总额";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "交易日期";
            this.dataGridViewTextBoxColumn9.HeaderText = "交易日期";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "订单状态";
            this.dataGridViewTextBoxColumn10.HeaderText = "订单状态";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
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
            // gOODSDataSet5
            // 
            this.gOODSDataSet5.DataSetName = "GOODSDataSet5";
            this.gOODSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(71, 573);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 122);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单查询";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "订单号：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(349, 573);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 122);
            this.groupBox1.TabIndex = 23;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(628, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 51);
            this.button2.TabIndex = 24;
            this.button2.Text = "未读/未发货订单管理";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(628, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "已发货订单管理";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Thistle;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Indigo;
            this.button3.Location = new System.Drawing.Point(628, 732);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(279, 51);
            this.button3.TabIndex = 26;
            this.button3.Text = "退款/售后订单管理";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // user_orderTableAdapter2
            // 
            this.user_orderTableAdapter2.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(979, 35);
            this.menuStrip1.TabIndex = 27;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Wheat;
            this.button4.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button4.Location = new System.Drawing.Point(71, 757);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 45);
            this.button4.TabIndex = 28;
            this.button4.Text = "退出界面";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 712);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "注：单击选中一列才可添加";
            // 
            // user_orderTableAdapter3
            // 
            this.user_orderTableAdapter3.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Wheat;
            this.button5.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button5.Location = new System.Drawing.Point(324, 757);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 45);
            this.button5.TabIndex = 30;
            this.button5.Text = "刷新页面";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // order_process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShoppingSystem20201223.Properties.Resources.psc__2_;
            this.ClientSize = new System.Drawing.Size(979, 834);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "order_process";
            this.Text = "商家订单管理中心";
            this.Load += new System.EventHandler(this.order_process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userorderBindingSource;
        private GOODSDataSet1TableAdapters.user_orderTableAdapter user_orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品总额DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 交易日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private GOODSDataSet1 gOODSDataSet11;
        private GOODSDataSet1TableAdapters.user_orderTableAdapter user_orderTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private GOODSDataSet5 gOODSDataSet5;
        private GOODSDataSet5TableAdapters.user_orderTableAdapter user_orderTableAdapter2;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private GOODSDataSet7 gOODSDataSet7;
        private GOODSDataSet7TableAdapters.user_orderTableAdapter user_orderTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收货地址;
        private System.Windows.Forms.ToolStripMenuItem 已完成订单4ToolStripMenuItem;
        private System.Windows.Forms.Button button5;
    }
}