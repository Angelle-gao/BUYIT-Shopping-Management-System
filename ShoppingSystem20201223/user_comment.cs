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
    public partial class user_comment : Form
    {
        public user_comment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string comment = this.textBox1.Text;
            int flag = DataAccess.add_comment(comment);
            if (flag > 0)
            {
                MessageBox.Show("感谢您的反馈！我们已收到~");
            }
            else
            {
                MessageBox.Show("似乎出错了，反馈未能成功提交~");
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

        private void 用户基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int order_num = DataAccess.order_num();
            MessageBox.Show("当前订单数量为:" + order_num);
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

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_password up = new update_password();
            this.Close();
            up.ShowDialog();
        }
    }
}
