using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
//订单状态参数：
//0:已下单但未发货
//1:已发货未确认收货
//2:确认收货
//3:退款/退货/售后
//4:已退款/退货/售后服务结束

namespace ShoppingSystem20201223
{
    public partial class receive_goods : Form
    {
        public receive_goods()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlDataAdapter da;
        DataSet ds;
        private void receive_goods_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ReadOnly = true;//设置数据为只读（不允许修改）
            string strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand("select * from user_order where 订单状态=1", conn);//读取user_order表中的全部数据
            da = new SqlDataAdapter(comm);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];//显示数据为用户订单表中订单状态为1的记录
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string order_index = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选中订单的订单编号数据
            int flag = DataAccess.update_order_state(order_index, 2);//更新订单状态为确认收货
            if (flag > 0)
            {
                MessageBox.Show("确认收货成功！恭喜你完成交易，祝您愉快！");
            }
            else if (flag < 0)
            {
                MessageBox.Show("该订单不存在！");
            }
            else
            {
                MessageBox.Show("发生了错误，收货失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string order_index = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选中订单的订单编号数据
            int flag = DataAccess.update_order_state(order_index, 3);//更新订单状态为退款/退货
            if (flag > 0)
            {
                MessageBox.Show("申请退款/退货成功！");
            }
            else if (flag < 0)
            {
                MessageBox.Show("该订单不存在！");
            }
            else
            {
                MessageBox.Show("发生了错误，申请退款/退货失败！");
            }
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
            this.Visible = false;
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

        private void 历史订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history_order ho = new history_order();
            this.Close();
            ho.ShowDialog();
        }
    }
}
