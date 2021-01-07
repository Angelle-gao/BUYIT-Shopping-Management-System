using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ShoppingSystem20201223
{
    public partial class order_process_3 : Form
    {
        public order_process_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlDataAdapter da;
        DataSet ds;
        private void order_process_2_Load(object sender, EventArgs e)
        {
            string strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand("select * from user_order where 订单状态=3", conn);//读取user_order表中退款/售后的订单条数
            da = new SqlDataAdapter(comm);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];//显示数据为用户订单表中订单状态为3的记录
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string order_index = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选中订单的订单编号数据
            int flag = DataAccess.update_order_state(order_index, 4);//更新订单状态为已退款/退货
            if (flag > 0)
            {
                MessageBox.Show("处理退款/退货成功！");
            }
            else if (flag < 0)
            {
                MessageBox.Show("该订单不存在！");
            }
            else
            {
                MessageBox.Show("发生了错误，操作失败！");
            }
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 添加商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_goods ag = new add_goods();
            this.Close();
            ag.ShowDialog();
        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_process op = new order_process();
            this.Close();
            op.ShowDialog();
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

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_user mu = new manage_user();
            this.Close();
            mu.ShowDialog();
        }

        private void 用户基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = DataAccess.order_num_by_state(0);
            MessageBox.Show("当前未读订单数量为:" + num);
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_password_manager upm = new update_password_manager();
            this.Close();
            upm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand("select * from user_order where 订单状态=3", conn);//读取user_order表中退款/售后的订单条数
            da = new SqlDataAdapter(comm);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];//显示数据为用户订单表中订单状态为3的记录
        }

        private void 已完成订单4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_process_4 op4 = new order_process_4();
            this.Close();
            op4.ShowDialog();
        }
    }
}
