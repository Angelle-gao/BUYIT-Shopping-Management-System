namespace ShoppingSystem20201223
{
    partial class ShoppingCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCar));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.商品序号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总额DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingcarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gOODSDataSet2 = new ShoppingSystem20201223.GOODSDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.shopping_carTableAdapter = new ShoppingSystem20201223.GOODSDataSet2TableAdapters.shopping_carTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.商品列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.购物车ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.待收货ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户基本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingcarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正姚体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "购物车";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品序号DataGridViewTextBoxColumn,
            this.商品名称DataGridViewTextBoxColumn,
            this.单价DataGridViewTextBoxColumn,
            this.商品数量DataGridViewTextBoxColumn,
            this.总额DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shoppingcarBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(36, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(849, 294);
            this.dataGridView1.TabIndex = 4;
            // 
            // 商品序号DataGridViewTextBoxColumn
            // 
            this.商品序号DataGridViewTextBoxColumn.DataPropertyName = "商品序号";
            this.商品序号DataGridViewTextBoxColumn.HeaderText = "商品序号";
            this.商品序号DataGridViewTextBoxColumn.Name = "商品序号DataGridViewTextBoxColumn";
            // 
            // 商品名称DataGridViewTextBoxColumn
            // 
            this.商品名称DataGridViewTextBoxColumn.DataPropertyName = "商品名称";
            this.商品名称DataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.商品名称DataGridViewTextBoxColumn.Name = "商品名称DataGridViewTextBoxColumn";
            // 
            // 单价DataGridViewTextBoxColumn
            // 
            this.单价DataGridViewTextBoxColumn.DataPropertyName = "单价";
            this.单价DataGridViewTextBoxColumn.HeaderText = "单价";
            this.单价DataGridViewTextBoxColumn.Name = "单价DataGridViewTextBoxColumn";
            // 
            // 商品数量DataGridViewTextBoxColumn
            // 
            this.商品数量DataGridViewTextBoxColumn.DataPropertyName = "商品数量";
            this.商品数量DataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.商品数量DataGridViewTextBoxColumn.Name = "商品数量DataGridViewTextBoxColumn";
            // 
            // 总额DataGridViewTextBoxColumn
            // 
            this.总额DataGridViewTextBoxColumn.DataPropertyName = "总额";
            this.总额DataGridViewTextBoxColumn.HeaderText = "总额";
            this.总额DataGridViewTextBoxColumn.Name = "总额DataGridViewTextBoxColumn";
            // 
            // shoppingcarBindingSource
            // 
            this.shoppingcarBindingSource.DataMember = "shopping_car";
            this.shoppingcarBindingSource.DataSource = this.gOODSDataSet2;
            // 
            // gOODSDataSet2
            // 
            this.gOODSDataSet2.DataSetName = "GOODSDataSet2";
            this.gOODSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(98, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "排序依据：总额";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(402, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "条件筛选";
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
            this.label4.Text = "商品名：";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(712, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "删除商品";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(712, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "保存修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Wheat;
            this.button4.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button4.Location = new System.Drawing.Point(728, 663);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 42);
            this.button4.TabIndex = 13;
            this.button4.Text = "退出购物车";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Wheat;
            this.button3.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button3.Location = new System.Drawing.Point(541, 663);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 42);
            this.button3.TabIndex = 14;
            this.button3.Text = "结算商品";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // shopping_carTableAdapter
            // 
            this.shopping_carTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataSource = this.shoppingcarBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 667);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "商品总额：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(150, 667);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "0元";
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
            this.商品列表ToolStripMenuItem,
            this.购物车ToolStripMenuItem,
            this.用户订单ToolStripMenuItem,
            this.待收货ToolStripMenuItem,
            this.退款ToolStripMenuItem,
            this.历史订单ToolStripMenuItem,
            this.个人中心ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 35);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "用户菜单";
            // 
            // 商品列表ToolStripMenuItem
            // 
            this.商品列表ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.商品列表ToolStripMenuItem.Name = "商品列表ToolStripMenuItem";
            this.商品列表ToolStripMenuItem.Size = new System.Drawing.Size(72, 31);
            this.商品列表ToolStripMenuItem.Text = "首页";
            this.商品列表ToolStripMenuItem.Click += new System.EventHandler(this.商品列表ToolStripMenuItem_Click_1);
            // 
            // 购物车ToolStripMenuItem
            // 
            this.购物车ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.购物车ToolStripMenuItem.Name = "购物车ToolStripMenuItem";
            this.购物车ToolStripMenuItem.Size = new System.Drawing.Size(96, 31);
            this.购物车ToolStripMenuItem.Text = "购物车";
            this.购物车ToolStripMenuItem.Click += new System.EventHandler(this.购物车ToolStripMenuItem_Click);
            // 
            // 用户订单ToolStripMenuItem
            // 
            this.用户订单ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.用户订单ToolStripMenuItem.Name = "用户订单ToolStripMenuItem";
            this.用户订单ToolStripMenuItem.Size = new System.Drawing.Size(120, 31);
            this.用户订单ToolStripMenuItem.Text = "用户订单";
            this.用户订单ToolStripMenuItem.Click += new System.EventHandler(this.用户订单ToolStripMenuItem_Click);
            // 
            // 待收货ToolStripMenuItem
            // 
            this.待收货ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.待收货ToolStripMenuItem.Name = "待收货ToolStripMenuItem";
            this.待收货ToolStripMenuItem.Size = new System.Drawing.Size(96, 31);
            this.待收货ToolStripMenuItem.Text = "待收货";
            this.待收货ToolStripMenuItem.Click += new System.EventHandler(this.待收货ToolStripMenuItem_Click);
            // 
            // 退款ToolStripMenuItem
            // 
            this.退款ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.退款ToolStripMenuItem.Name = "退款ToolStripMenuItem";
            this.退款ToolStripMenuItem.Size = new System.Drawing.Size(127, 31);
            this.退款ToolStripMenuItem.Text = "退款/售后";
            this.退款ToolStripMenuItem.Click += new System.EventHandler(this.退款ToolStripMenuItem_Click);
            // 
            // 历史订单ToolStripMenuItem
            // 
            this.历史订单ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.历史订单ToolStripMenuItem.Name = "历史订单ToolStripMenuItem";
            this.历史订单ToolStripMenuItem.Size = new System.Drawing.Size(120, 31);
            this.历史订单ToolStripMenuItem.Text = "历史订单";
            this.历史订单ToolStripMenuItem.Click += new System.EventHandler(this.历史订单ToolStripMenuItem_Click);
            // 
            // 个人中心ToolStripMenuItem
            // 
            this.个人中心ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.个人中心ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户基本信息ToolStripMenuItem,
            this.更改密码ToolStripMenuItem,
            this.系统反馈ToolStripMenuItem});
            this.个人中心ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.个人中心ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.个人中心ToolStripMenuItem.Name = "个人中心ToolStripMenuItem";
            this.个人中心ToolStripMenuItem.Size = new System.Drawing.Size(120, 31);
            this.个人中心ToolStripMenuItem.Text = "个人中心";
            // 
            // 用户基本信息ToolStripMenuItem
            // 
            this.用户基本信息ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("用户基本信息ToolStripMenuItem.BackgroundImage")));
            this.用户基本信息ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.用户基本信息ToolStripMenuItem.Name = "用户基本信息ToolStripMenuItem";
            this.用户基本信息ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.用户基本信息ToolStripMenuItem.Text = "用户基本信息";
            this.用户基本信息ToolStripMenuItem.Click += new System.EventHandler(this.用户基本信息ToolStripMenuItem_Click);
            // 
            // 更改密码ToolStripMenuItem
            // 
            this.更改密码ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("更改密码ToolStripMenuItem.BackgroundImage")));
            this.更改密码ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem";
            this.更改密码ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.更改密码ToolStripMenuItem.Text = "更改密码";
            this.更改密码ToolStripMenuItem.Click += new System.EventHandler(this.更改密码ToolStripMenuItem_Click);
            // 
            // 系统反馈ToolStripMenuItem
            // 
            this.系统反馈ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("系统反馈ToolStripMenuItem.BackgroundImage")));
            this.系统反馈ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.系统反馈ToolStripMenuItem.Name = "系统反馈ToolStripMenuItem";
            this.系统反馈ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.系统反馈ToolStripMenuItem.Text = "系统反馈";
            this.系统反馈ToolStripMenuItem.Click += new System.EventHandler(this.系统反馈ToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(13, 613);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(239, 32);
            this.label17.TabIndex = 26;
            this.label17.Text = "请输入收货地址：";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(242, 613);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(568, 39);
            this.textBox3.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 561);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(547, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "友情提醒：一个订单只能购买一种商品哦！";
            // 
            // ShoppingCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShoppingSystem20201223.Properties.Resources._2018122623054983146;
            this.ClientSize = new System.Drawing.Size(922, 721);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShoppingCar";
            this.Text = "购物车";
            this.Load += new System.EventHandler(this.ShoppingCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingcarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private GOODSDataSet2 gOODSDataSet2;
        private System.Windows.Forms.BindingSource shoppingcarBindingSource;
        private GOODSDataSet2TableAdapters.shopping_carTableAdapter shopping_carTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 商品列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 购物车ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 待收货ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退款ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户基本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统反馈ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品序号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总额DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 历史订单ToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
    }
}