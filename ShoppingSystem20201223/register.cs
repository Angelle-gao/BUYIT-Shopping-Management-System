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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        private void init()//初始化文本框内容
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }
        private void register_Load(object sender, EventArgs e)
        {
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str_user = this.textBox1.Text.Trim();
            string str_pass = this.textBox2.Text.Trim();
            string str_phone = this.textBox3.Text.Trim();
            this.label5.Text = "已输入" + str_user.Length + "位";
            this.label6.Text = "已输入" + str_pass.Length + "位";
            this.label7.Text = "至少10位";
            if (str_user.Length < 1)//如果用户账户文本框中没有输入内容
            {
                MessageBox.Show("请输入您的用户账号！");
                this.textBox1.Focus();
            }
            else if(str_user.Length >= 1 && str_user.Length < 3)
            {
                MessageBox.Show("您的账户名太短，请输入至少4个字符的账户名！");
                this.textBox1.Focus();
            }
            else
            {
                if (str_pass.Length < 1)//如果密码文本框中没有输入内容
                {
                    MessageBox.Show("请输入用户密码！");
                    this.textBox2.Focus();
                }
                else if(str_pass.Length >= 1 && str_pass.Length < 6)
                {
                    MessageBox.Show("您的账户密码不安全，请设置至少6位！");
                    this.textBox2.Focus();
                }
                else
                {
                    int flag = DataAccess.AddUser(str_user, str_pass, str_phone);
                    if (flag < 0)
                    {
                        MessageBox.Show("用户账号已经存在，请重新输入！");
                        this.textBox1.Focus();
                    }
                    else
                    {
                        if (flag > 0)
                        {

                            MessageBox.Show("用户添加成功！");
                        }
                        else
                        {
                            MessageBox.Show("用户添加失败！");
                        }
                    }
                }
            }
        }
    }
}
