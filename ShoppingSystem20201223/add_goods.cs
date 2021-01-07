using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingSystem20201223
{
    public partial class add_goods : Form
    {
        public add_goods()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void init()
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            init();
        }
        private void 商品列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = this.textBox2.Text;
            string price = this.textBox3.Text;
            string stock = this.textBox4.Text;
            if (name == "" || price == "" || stock == "")
            {
                MessageBox.Show("有商品信息为空，无法添加商品！");
                this.textBox2.Focus();
            }
            else
            {
                int flag = DataAccess.add_goods(name, price, stock);
                if (flag < 0)
                {
                    MessageBox.Show("检测到商品库已经有该商品，请移步商品管理区管理该商品信息！");
                }
                else if(flag == 0){
                    MessageBox.Show("商品添加失败！");
                }
                else
                {
                    MessageBox.Show("商品添加成功！");
                }
            }
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_process op = new order_process();
            this.Close();
            op.ShowDialog();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_user mu = new manage_user();
            this.Close();
            mu.ShowDialog();
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
    }
}
