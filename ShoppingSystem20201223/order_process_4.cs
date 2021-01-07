using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ShoppingSystem20201223
{
    public partial class order_process_4 : Form
    {
        public order_process_4()
        {
            InitializeComponent();
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlDataAdapter da;
        DataSet ds;
        private void 添加商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_goods ag = new add_goods();
            this.Close();
            ag.ShowDialog();
        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 未处理发货订单0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_process_0 op0 = new order_process_0();
            this.Close();
            op0.ShowDialog();
        }

        private void 已发货订单1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_process_1 op1 = new order_process_1();
            this.Close();
            op1.ShowDialog();
        }

        private void 退款售后订单2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_process_3 op3 = new order_process_3();
            this.Close();
            op3.ShowDialog();
        }

        private void 已完成订单4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_process_4 op4 = new order_process_4();
            this.Close();
            op4.ShowDialog();
        }

        private void order_process_4_Load(object sender, EventArgs e)
        {
            string strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand("select * from user_order where 订单状态=4", conn);//读取user_order表中退款/售后的订单条数
            da = new SqlDataAdapter(comm);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];//显示数据为用户订单表中订单状态为4的记录
            this.label2.Text = "当前共完成订单数：" + DataAccess.order_num_by_state(4) + "件";
            this.label3.Text = "当前已完成销售额：" + DataAccess.order_sum(4) + "元";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
