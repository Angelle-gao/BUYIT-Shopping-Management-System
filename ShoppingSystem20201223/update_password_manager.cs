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
    public partial class update_password_manager : Form
    {
        public update_password_manager()
        {
            InitializeComponent();
        }

        public void init()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }

        private void update_password_manager_Load(object sender, EventArgs e)
        {
            init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string managername = this.textBox1.Text.Trim();
            string password = this.textBox2.Text.Trim();
            string new_password = this.textBox3.Text.Trim();
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("尚未输入管理员账号！");
                this.textBox1.Focus();
            }
            else
            {
                if (this.textBox2.Text == "")
                {
                    MessageBox.Show("尚未输入原始密码！");
                    this.textBox2.Focus();
                }
                else
                {
                    if (this.textBox3.Text == "")
                    {
                        MessageBox.Show("尚未输入新密码！");
                        this.textBox3.Focus();
                    }
                    else
                    {
                        int flag = DataAccess.update_login_manager_password(managername, password, new_password);
                        if (flag == 1)
                        {
                            MessageBox.Show("成功修改密码！");
                        }
                        else if (flag == 2)
                        {
                            MessageBox.Show("管理员密码输入错误！");
                            this.textBox2.Focus();
                        }
                        else if (flag < 0)
                        {
                            MessageBox.Show("管理员账号输入错误！无法检索到该用户账号！");
                            this.textBox1.Focus();
                        }
                        else
                        {
                            MessageBox.Show("管理员密码修改失败，系统错误！");
                        }
                    }
                }
            }
        }
    }
}
