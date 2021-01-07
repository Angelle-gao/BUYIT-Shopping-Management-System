namespace ShoppingSystem20201223
{
    partial class history_order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history_order));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正姚体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户历史订单列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(54, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(803, 349);
            this.dataGridView1.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Thistle;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("方正姚体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Indigo;
            this.button3.Location = new System.Drawing.Point(679, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 51);
            this.button3.TabIndex = 25;
            this.button3.Text = "退出界面";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(908, 35);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "用户菜单";
            // 
            // 商品列表ToolStripMenuItem
            // 
            this.商品列表ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.商品列表ToolStripMenuItem.Name = "商品列表ToolStripMenuItem";
            this.商品列表ToolStripMenuItem.Size = new System.Drawing.Size(72, 31);
            this.商品列表ToolStripMenuItem.Text = "首页";
            this.商品列表ToolStripMenuItem.Click += new System.EventHandler(this.商品列表ToolStripMenuItem_Click);
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
            // history_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShoppingSystem20201223.Properties.Resources._2018122623054983146;
            this.ClientSize = new System.Drawing.Size(908, 670);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "history_order";
            this.Text = "7";
            this.Load += new System.EventHandler(this.history_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 商品列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 购物车ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 待收货ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退款ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户基本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统反馈ToolStripMenuItem;
    }
}