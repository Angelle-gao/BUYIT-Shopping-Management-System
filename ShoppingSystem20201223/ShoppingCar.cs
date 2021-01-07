using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ShoppingSystem20201223
{
    public partial class ShoppingCar : Form
    {
        public ShoppingCar()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        private void ShoppingCar_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“gOODSDataSet2.shopping_car”中。您可以根据需要移动或删除它。
            this.shopping_carTableAdapter.Fill(this.gOODSDataSet2.shopping_car);
            this.dataGridView1.AllowUserToAddRows = false;
            string strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand("select * from shopping_car", conn);
            da = new SqlDataAdapter(comm);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            int goods_sum = DataAccess.CountSum();
            this.label3.Text = goods_sum.ToString() + "元";
            this.shoppingcarBindingSource.Filter = "商品名称 like '%" + this.textBox1.Text.Trim() + "%'";
            if (this.radioButton1.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            if (this.radioButton2.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
            this.dataGridView1.Columns[0].ReadOnly = true;//设置商品序号数据为只读（不允许修改）
            this.dataGridView1.Columns[1].ReadOnly = true;//设置商品名称数据为只读（不允许修改）
            this.dataGridView1.Columns[2].ReadOnly = true;//设置单价数据为只读（不允许修改）
            this.dataGridView1.Columns[4].ReadOnly = true;//设置总额数据为只读（不允许修改）
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.shoppingcarBindingSource.Filter = "商品名称 like '%" + this.textBox1.Text.Trim() + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            if (this.radioButton2.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            if (this.radioButton2.Checked)
            {
                this.dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
        }

        int flag = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择需要删除的商品哦~");
            }
            else
            {
                if (MessageBox.Show("确定要删除选定的商品吗？", "删除购物车商品", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = this.dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        string name = this.dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                        this.bindingSource1.RemoveAt(dataGridView1.SelectedRows[i].Index);//在datagridview中删除一条数据，但此时数据未在数据库购物车表中删除
                        flag = DataAccess.DeleteShoppingCarGoods(name);
                        if(flag == 0)
                        {
                            MessageBox.Show("whoops!"+name+"删除失败！");
                        }
                    }
                    if (flag > 0)
                    {
                        MessageBox.Show("商品删除成功！");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bindingSource1.EndEdit();
                da.Update(ds);
                ds.AcceptChanges();
                string name, quantity;
                int flag = 0;
                for(int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    name = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                    quantity = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                    flag = DataAccess.update_shoppingcar(name, quantity);
                }
                if (flag > 0)
                {
                    this.dataGridView1.DataSource = this.shoppingcarBindingSource;
                    MessageBox.Show("成功保存购物车数据！");
                }
                else if(flag < 0)
                {
                    MessageBox.Show("无法更新商品库存", "发生错误");
                }
                else
                {
                    MessageBox.Show("保存购物车数据失败！");
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "保存购物车更新失败！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name, quantity, sum;
            int int_sum = 0, flag = 0;
            if (this.textBox3.Text.Trim() != "")
            {
                string address = this.textBox3.Text.Trim();
                //计算购物车内的商品总额、商品数量并结算为一个新的订单
                for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
                {
                    name = this.dataGridView1.Rows[i].Cells[1].Value.ToString();//读取datagridview第i列的商品名称值
                    quantity = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                    sum = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                    int_sum = Convert.ToInt32(sum);
                    flag = DataAccess.add_order(name, quantity, int_sum, address);
                    if(flag == 0)
                    {
                        MessageBox.Show("订单生成失败！", "订单创建失败");
                        break;
                    }
                    else if(flag < 0)
                    {
                        MessageBox.Show("当前购物车为空，请先添加商品进入购物车！", "订单创建失败");
                        break;
                    }
                }                //更新结算后的对应商品库存*
                MessageBox.Show("成功生成一条新订单！", "订单创建成功");
            }
            else
            {
                MessageBox.Show("您还没有输入收货地址哦！", "订单创建失败");
            }
        }

        private void 商品列表ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 用户订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_order uo = new user_order();
            this.Close();
            uo.ShowDialog();
        }

        private void 购物车ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShoppingCar sc = new ShoppingCar();
            this.Close();
            sc.ShowDialog();
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

        private void 历史订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history_order ho = new history_order();
            this.Close();
            ho.ShowDialog();
        }
    }
}
