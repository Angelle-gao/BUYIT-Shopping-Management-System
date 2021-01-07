using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ShoppingSystem20201223
{
    public partial class after_sales : Form
    {
        public after_sales()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        private void after_sales_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ReadOnly = true;//设置数据为只读（不允许修改）
            string strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand("select * from user_order where 订单状态=4", conn);//读取user_order表
            da = new SqlDataAdapter(comm);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];//显示数据为用户订单表中订单状态为4的记录
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 商品列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 购物车ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShoppingCar sc = new ShoppingCar();
            this.Close();
            sc.ShowDialog();
        }

        private void 用户订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_order uo = new user_order();
            this.Close();
            uo.ShowDialog();
        }

        private void 待收货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receive_goods rg = new receive_goods();
            this.Close();
            rg.ShowDialog();
        }

        private void 退款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            after_sales afs = new after_sales();
            this.Close();
            afs.ShowDialog();
        }

        private void 用户基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int order_num = DataAccess.order_num();
            MessageBox.Show("当前订单数量为:" + order_num);
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_password up = new update_password();
            this.Close();
            up.ShowDialog();
        }

        private void 系统反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_comment uc = new user_comment();
            this.Close();
            uc.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
