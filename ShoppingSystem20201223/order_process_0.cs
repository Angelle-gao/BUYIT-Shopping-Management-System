using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ShoppingSystem20201223
{
    public partial class order_process_0 : Form
    {
        public order_process_0()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        private void order_process_0_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“gOODSDataSet7.user_order”中。您可以根据需要移动或删除它。
            this.user_orderTableAdapter1.Fill(this.gOODSDataSet7.user_order);
            string strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand("select * from user_order where 订单状态=0", conn);//读取user_order表中的全部数据
            da = new SqlDataAdapter(comm);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];//显示数据为用户订单表中订单状态为0的记录
            this.label2.Text = "当前发现未处理订单" + DataAccess.order_num_by_state(0).ToString() + "件";//显示当前未处理订单数
            //给发货物流添加选项
            this.comboBox1.Items.Add("顺丰快递");
            this.comboBox1.Items.Add("申通快递");
            this.comboBox1.Items.Add("圆通快递");
            this.comboBox1.Items.Add("中通快递");
            this.comboBox1.Items.Add("丹鸟快递");
            this.comboBox1.Items.Add("韵达快递");
            this.comboBox1.Items.Add("天天快递");
            this.comboBox1.Items.Add("中国邮政EMS");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//按照交易时间升序、降序排列
        {
            if (this.radioButton1.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            if (this.radioButton2.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//按照交易时间升序、降序排列
        {
            if (this.radioButton1.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            if (this.radioButton2.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            }
        }
        //显示选择后的发货物流公司
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("您选择的物流公司是：" + comboBox1.Text, "友情提示");
        }
        //确认发货，将一条新的记录加入goods_delivery表格，同时更新当前订单的订单状态为1
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string company = this.comboBox1.Text;//物流公司
                string order = this.textBox2.Text.Trim();//物流单号
                string sum = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//选中订单的商品总额数据
                string send_address = this.textBox1.Text.Trim();
                string receive_address = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();//选中订单的发货地址数据
                string order_index = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选中订单的订单编号数据
                int flag = DataAccess.add_goods_delivery(company, order, sum, order_index, send_address, receive_address);
                //更新现有订单表中的订单状态为1（表示已经发货，未收货）
                int flag2 = DataAccess.update_order_state(order_index, 1);
                if (flag > 0 && flag2 > 0)
                {
                    MessageBox.Show("成功添加新的发货信息！", "添加成功");//发货商品添加成功
                }
                else if (flag2 == -1)
                {
                    MessageBox.Show("找不到该订单编号的订单信息！", "出现错误");//发货商品添加失败
                }
                else
                {
                    MessageBox.Show("添加新的发货信息失败！", "出现错误");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("添加新的发货信息失败！", err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void 未处理发货订单0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_process_0 op0 = new order_process_0();
            this.Close();
            op0.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand("select * from user_order where 订单状态=0", conn);//读取user_order表中的全部数据
            da = new SqlDataAdapter(comm);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];//显示数据为用户订单表中订单状态为0的记录
        }

        private void 已完成订单4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_process_4 op4 = new order_process_4();
            this.Close();
            op4.ShowDialog();
        }
    }
}
