using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ShoppingSystem20201223
{
    class DataAccess
    {
        public static DataSet SelectUser(string username)
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from login_user where 用户账号=@username";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@username", username);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet SelectUser(int id)
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from login_user where id=@id";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet SelectAllUser()
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from login_user";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet SelectUsers(string username)
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from login_user where 用户账号 like '%'+@username+'%'";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@username", username);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static int DeleteUser(string username)//删除商品库里的商品
        {
            string strConn, strComm;
            int flag = 0;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            strComm = "Delete from login_user where 用户账号=@username";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@username", username);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                {
                    flag = 1;//删除成功
                }
                else
                {
                    flag = 0;//删除失败
                }
            }
            catch (Exception e)
            {
                flag = 0;//删除失败
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        public static int DeleteUser(int id)
        {
            string strConn, strComm;
            int flag = 0;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            strComm = "Delete from login_user where id=@id";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
            catch (Exception e)
            {
                flag = 0;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        public static int AddUser(string u, string p, string t)
        {
            string strConn, strComm;
            int flag = 0;
            DataSet ds = SelectUser(u);
            DataSet ds1 = SelectAllUser();
            if (ds.Tables[0].Rows.Count > 0)//如果查询到包含用户账号信息的记录，令标记为-1；
            {
                flag = -1;//账户已经存在，无法注册
            }
            else
            {
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                strComm = "insert into login_user(id,用户账号,用户密码,联系电话) values(@id,@username,@password,@phone)";
                SqlCommand comm = new SqlCommand(strComm, conn);
                comm.Parameters.AddWithValue("@id", ds1.Tables[0].Rows.Count + 1);
                comm.Parameters.AddWithValue("@username", u);
                comm.Parameters.AddWithValue("@password", p);
                comm.Parameters.AddWithValue("@phone", t);
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                    //执行SQL，返回一个整型变量，如果SQL是对数据库的记录进行操作，那么返回操作影响的记录条数
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
                catch (Exception e)
                {
                    flag = 0;
                }
                finally
                {
                    conn.Close();
                }
            }
            return flag;
        }
        public static int update_login_user_password(string username, string password, string new_password)//更新login_user中的账户密码
        {
            string strConn;
            int flag = 0;
            DataSet ds = SelectAllUser();
            DataSet ds_user = SelectUser(username);
            if (ds.Tables[0].Rows.Count > 0)//如果在登陆名中找到该用户
            {
                if (ds.Tables[0].Rows[0]["用户密码"].ToString() == password)//如果用户密码和系统中的账户密码匹配，可以修改密码
                {
                    string strcomm = "update login_user set 用户密码=@password where 用户账号=@username";
                    strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                    SqlConnection conn = new SqlConnection(strConn);
                    SqlCommand comm = new SqlCommand(strcomm, conn);
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@username", username);
                    comm.Parameters.AddWithValue("@password", new_password);//更改密码
                    try
                    {
                        conn.Open();
                        if (comm.ExecuteNonQuery() > 0)
                            flag = 1;//密码更改成功
                        else
                            flag = 0;//密码更改失败
                    }
                    catch (SqlException err)
                    {
                        flag = 0;//密码更改失败
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    flag = 2;//用户密码输入错误，与实际不匹配
                }
            }
            else {
                flag = -1;//用户账号输入错误
            }
            return flag;
        }
        public static int update_user_phone(int id, string username, string phone)//更新用户联系电话
        {
            string strConn;
            int flag = 0;
            DataSet ds_user = SelectUser(username);//查找用户
            if (ds_user.Tables[0].Rows.Count > 0) //如果找到该用户
            {
                string strcomm = "update login_user set id=@id,联系电话=@phone where 用户账号=@username";
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand comm = new SqlCommand(strcomm, conn);
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@phone", phone);
                comm.Parameters.AddWithValue("@username", username);
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                        flag = 1;
                    else
                        flag = 0;
                }
                catch (SqlException err)
                {
                    flag = 0;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                flag = -1;//找不到
            }
            return flag;
        }
        public static DataSet SelectAllManager()
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from login_manager";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet SelectManager(string managername)//依据管理员账号选择login_manager中的数据
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from login_manager where 管理员账号=@managername";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@managername", managername);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static int update_login_manager_password(string managername, string password, string new_password)//更新login_manager中的账户密码
        {
            string strConn;
            int flag = 0;
            DataSet ds = SelectAllManager();
            DataSet ds_manager = SelectManager(managername);
            if (ds.Tables[0].Rows.Count > 0)//如果在登陆名中找到管理员
            {
                if (ds.Tables[0].Rows[0]["管理员密码"].ToString() == password)//如果管理员密码和系统中的账户密码匹配，可以修改密码
                {
                    string strcomm = "update login_manager set 管理员密码=@password where 管理员账号=@managername";
                    strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                    SqlConnection conn = new SqlConnection(strConn);
                    SqlCommand comm = new SqlCommand(strcomm, conn);
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@managername", managername);
                    comm.Parameters.AddWithValue("@password", new_password);//更改密码
                    try
                    {
                        conn.Open();
                        if (comm.ExecuteNonQuery() > 0)
                            flag = 1;//密码更改成功
                        else
                            flag = 0;//密码更改失败
                    }
                    catch (SqlException err)
                    {
                        flag = 0;//密码更改失败
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    flag = 2;//密码输入错误，与实际不匹配
                }
            }
            else
            {
                flag = -1;//账号输入错误
            }
            return flag;
        }
        public static DataSet SelectGoods(string name)
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from shopping_car where 商品名称=@name";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@name", name);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet SelectAllGoods()
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from shopping_car";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static int SelectAllGoodsJudge()
        {
            int flag = 0;
            DataSet ds = SelectAllGoods();
            if (ds.Tables[0].Rows.Count > 0)
            {
                flag = 1;//购物车中有数据
            }
            else
            {
                flag = 0;//购物车中没有数据
            }
            return flag;
        }
        public static int add_shoppingcar(string i, string n, int p, int q, int s)//商品序号，商品名称，单价，商品数量，总额
        {
            string strConn, strComm;
            int flag = 0;
            DataSet ds = SelectGoods(n);
            DataSet ds_goods = SelectAllGoods();
            if (ds.Tables[0].Rows.Count > 0)//如果查询到购物车已经添加了此商品,则在原来商品数量基础上更新商品数量
            {
                q = Convert.ToInt32(ds.Tables[0].Rows[0]["商品数量"].ToString()) + q;
                s = Convert.ToInt32(ds.Tables[0].Rows[0]["总额"].ToString()) + s;
                string strcomm = "update shopping_car set 商品数量=@quantity, 总额=@sum where 商品序号=@index";
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand comm = new SqlCommand(strcomm, conn);
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@index", ds.Tables[0].Rows[0]["商品序号"].ToString());
                comm.Parameters.AddWithValue("@quantity", q);
                comm.Parameters.AddWithValue("@sum", s);
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                        flag = -1;
                    else
                        flag = 0;
                }
                catch (SqlException err)
                {
                    flag = 0;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                strComm = "insert into shopping_car(商品序号,商品名称,单价,商品数量,总额) values(@index,@name,@price,@quantity,@sum)";
                SqlCommand comm = new SqlCommand(strComm, conn);
                comm.Parameters.AddWithValue("@index", ds_goods.Tables[0].Rows.Count + 1);
                comm.Parameters.AddWithValue("@name", n);
                comm.Parameters.AddWithValue("@price", p);
                comm.Parameters.AddWithValue("@quantity", q);
                comm.Parameters.AddWithValue("@sum", s);
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                    //执行SQL，返回一个整型变量，如果SQL是对数据库的记录进行操作，那么返回操作影响的记录条数
                    {
                        flag = 1;//商品成功添加至购物车
                    }
                    else
                    {
                        flag = 0;//商品添加失败
                    }
                }
                catch (Exception e)
                {
                    flag = 0;//商品添加失败
                }
                finally
                {
                    conn.Close();
                }
            }
            return flag;
        }
        public static int DeleteShoppingCar(int index)
        {
            string strConn, strComm;
            int flag = 0;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            strComm = "Delete * from shoping_car where 商品序号=@index";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@index", index);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                {
                    flag = 1;//购物车商品删除成功
                }
                else
                {
                    flag = 0;//购物车商品删除失败
                }
            }
            catch (Exception e)
            {
                flag = 0;//购物车商品删除失败
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        public static int CountSum()
        {
            int sum = 0, now_sum = 0;
            string Sum;
            DataSet ds = SelectAllGoods();
            if (ds.Tables[0].Rows.Count > 0)//如果购物车中已经添加了商品
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Sum = ds.Tables[0].Rows[i]["总额"].ToString();
                    now_sum = Convert.ToInt32(Sum);
                    sum = sum + now_sum;
                }
            }
            else
            {
                sum = 0;
            }
            return sum;
        }
        public static int DeleteAllShoppingCar()//清空购物车
        {
            string strConn, strComm;
            int flag = 0;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            strComm = "Delete from shopping_car";
            SqlCommand comm = new SqlCommand(strComm, conn);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                {
                    flag = 1;//购物车商品删除成功
                }
                else
                {
                    flag = 0;//购物车商品删除失败
                }
            }
            catch (Exception e)
            {
                flag = 0;//购物车商品删除失败
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        public static int DeleteShoppingCarGoods(string name)//删除购物车中的指定商品
        {
            string strConn, strComm;
            int flag = 0;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            strComm = "Delete from shopping_car where 商品名称=@name";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@name", name);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                {
                    flag = 1;//购物车商品删除成功
                }
                else
                {
                    flag = 0;//购物车商品删除失败
                }
            }
            catch (Exception e)
            {
                flag = 0;//购物车商品删除失败
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        public static int DeleteOrderByState(string name, string state)//删除某一订单状态下的指定商品名称的订单数据
        {
            string strConn, strComm;
            int flag = 0;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            strComm = "Delete from user_order where 商品名称=@name and 订单状态=@state";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@state", state);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                {
                    flag = 1;//删除成功
                }
                else
                {
                    flag = 0;//删除失败
                }
            }
            catch (Exception e)
            {
                flag = 0;//购物车商品删除失败
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        public static DataSet SelectGoodsStore(string name)//查询商品库表的信息（依据商品名称）
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from goods where 商品名称=@name";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@name", name);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet SelectGoodsStoreAll()//查询商品库表的全部信息
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from goods";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static int DeleteStoreGoods(string name)//删除商品库里的商品
        {
            string strConn, strComm;
            int flag = 0;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            strComm = "Delete from goods where 商品名称=@name";
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@name", name);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                {
                    flag = 1;//商品删除成功
                }
                else
                {
                    flag = 0;//商品删除失败
                }
            }
            catch (Exception e)
            {
                flag = 0;//商品删除失败
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        public static int update_goods(int i, string name, string price, string stock)//更新goods中的信息（商品名称，商品价格，商品库存）
        {
            string strConn;
            int flag = 0;
            DataSet ds = SelectGoodsStoreAll();//读取goods中的全部商品信息
            if (ds.Tables[0].Rows.Count > 0) //如果商品表中有数据
            {
                string strcomm = "update goods set 商品编号=@index,商品价格=@price,商品库存=@stock where 商品名称=@name";
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand comm = new SqlCommand(strcomm, conn);
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@index", i + 1);
                comm.Parameters.AddWithValue("@name", name);
                comm.Parameters.AddWithValue("@price", price);
                comm.Parameters.AddWithValue("@stock", stock);
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                        flag = 1;
                    else
                        flag = 0;
                }
                catch (SqlException err)
                {
                    flag = 0;
                }
                finally
                {
                    conn.Close();
                }
            }
            return flag;
        }
        public static int update_goodsstore_stock_sub(string n, int q)//减少shopping_car中的商品库存（商品名称，商品数量（用户需求））
        {
            string strConn;
            int flag = 0;
            DataSet ds = SelectGoodsStore(n);
            DataSet ds_goods = SelectGoodsStoreAll();
            int s = Convert.ToInt32(ds.Tables[0].Rows[0]["商品库存"].ToString()) - q;
            string strcomm = "update goods set 商品库存=@stock where 商品名称=@name";
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strcomm, conn);
            comm.Parameters.Clear();
            comm.Parameters.AddWithValue("@name", ds.Tables[0].Rows[0]["商品名称"].ToString());
            comm.Parameters.AddWithValue("@stock", s);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                    flag = 1;
                else
                    flag = 0;
            }
            catch (SqlException err)
            {
                flag = 0;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        public static int update_goodsstore_stock_plus(string n, int q)//增加shopping_car中的商品库存（商品名称，商品数量（用户需求））
        {
            string strConn;
            int flag = 0;
            DataSet ds = SelectGoodsStore(n);
            DataSet ds_goods = SelectGoodsStoreAll();
            int s = Convert.ToInt32(ds.Tables[0].Rows[0]["商品库存"].ToString()) + q;
            string strcomm = "update goods set 商品库存=@stock where 商品名称=@name";
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strcomm, conn);
            comm.Parameters.Clear();
            comm.Parameters.AddWithValue("@name", ds.Tables[0].Rows[0]["商品名称"].ToString());
            comm.Parameters.AddWithValue("@stock", s);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                    flag = 1;
                else
                    flag = 0;
            }
            catch (SqlException err)
            {
                flag = 0;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        public static int update_shoppingcar(string name, string q)//更新shopping_car中的总额（商品名称，商品数量）
        {
            string strConn;
            int flag = 0, s = 0, p = 0, qu = 0;
            DataSet ds_goods = SelectGoods(name);//查找对应商品名称的列
            if (ds_goods.Tables[0].Rows.Count > 0) //如果购物车中找到该商品
            {
                p = Convert.ToInt32(ds_goods.Tables[0].Rows[0]["单价"].ToString());//查找商品的单价
                qu = Convert.ToInt32(q);//获取商品的数量
                s = p * qu;//计算最后的商品总额
                string strcomm = "update shopping_car set 总额=@sum,商品数量=@quantity where 商品名称=@name";
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand comm = new SqlCommand(strcomm, conn);
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@name", name);
                comm.Parameters.AddWithValue("@quantity", q);
                comm.Parameters.AddWithValue("@sum", s.ToString());
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                        flag = 1;
                    else
                        flag = 0;
                }
                catch (SqlException err)
                {
                    flag = 0;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                flag = -1;//找不到该商品，无法更新
            }
            return flag;
        }

        public static DataSet SelectAllOrder()//读取order_list表中的所有信息
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from user_order";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet SelectOrderState(int state)//读取order_list表中订单状态的信息
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from user_order where 订单状态=@state";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@state", state);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static int add_order_from_shoppingcar(string address)//结算购物车新增为一条订单数据（商品序号，商品数量，商品总额，交易日期）
        {
            string strConn, strComm;
            int flag = 0, status = 0, flag2 = 0;
            string datetime, Sum, Quantity, Name;
            int quantity = 0, sum = 0, now_sum, now_q;
            DataSet ds = SelectAllGoods();
            DataSet order_ds = SelectAllOrder();
            if (ds.Tables[0].Rows.Count > 0)//如果购物车中有数据，将数据结算生成新的order_list中的数据
            {
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                strComm = "insert into user_order(订单编号,商品数量,商品总额,交易日期,订单状态,收货地址) values(@index,@quantity,@sum,@datetime,@status,@address)";
                SqlCommand comm = new SqlCommand(strComm, conn);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Name = ds.Tables[0].Rows[i]["商品名称"].ToString();
                    Sum = ds.Tables[0].Rows[i]["总额"].ToString();
                    now_sum = Convert.ToInt32(Sum);
                    sum = sum + now_sum;
                    Quantity = ds.Tables[0].Rows[i]["商品数量"].ToString();
                    now_q = Convert.ToInt32(Quantity);
                    flag2 = update_goodsstore_stock_sub(Name, now_q);
                    if (flag2 == 1)
                    {
                        quantity = quantity + now_q;
                    }
                    else
                    {
                        flag = -1;//商品库存更新失败
                        break;
                    }
                }
                if (flag2 == 1)
                {
                    datetime = DateTime.Now.ToShortDateString().ToString();
                    comm.Parameters.AddWithValue("@index", order_ds.Tables[0].Rows.Count + 1);
                    comm.Parameters.AddWithValue("@quantity", quantity);
                    comm.Parameters.AddWithValue("@sum", sum);
                    comm.Parameters.AddWithValue("@datetime", datetime);
                    comm.Parameters.AddWithValue("@status", status);//默认为0（未付款），只有商家确认付款才由商家更新为1
                    comm.Parameters.AddWithValue("@address", address);
                }
                else
                {
                    flag = -1;
                }
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                    //执行SQL，返回一个整型变量，如果SQL是对数据库的记录进行操作，那么返回操作影响的记录条数
                    {
                        flag = 1;//商品成功加入订单表
                    }
                    else
                    {
                        flag = 0;//商品添加失败
                    }
                }
                catch (Exception e)
                {
                    flag = 0;//商品添加失败
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                flag = -1;//购物车是空的，则无法添加数据进入订单
            }
            return flag;
        }
        public static int add_order(string name, string quantity, int sum, string address)//新增一个商品为一条订单数据（商品序号，商品数量，商品总额，交易日期）
        {
            string strConn, strComm;
            int flag = 0;
            string datetime;
            DataSet ds = SelectGoodsStore(name);
            DataSet order_ds = SelectAllOrder();
            if (ds.Tables[0].Rows.Count > 0)//如果查找到商品信息，将数据结算生成新的order_list中的数据
            {
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                strComm = "insert into user_order(订单编号,商品数量,商品总额,交易日期,订单状态,收货地址,商品名称) values(@index,@quantity,@sum,@datetime,@status,@address,@name)";
                SqlCommand comm = new SqlCommand(strComm, conn);
                datetime = DateTime.Now.ToShortDateString().ToString();
                comm.Parameters.AddWithValue("@index", order_ds.Tables[0].Rows.Count + 1);
                comm.Parameters.AddWithValue("@quantity", quantity);
                comm.Parameters.AddWithValue("@sum", sum);
                comm.Parameters.AddWithValue("@datetime", datetime);
                comm.Parameters.AddWithValue("@status", 0);//新加入的订单初始值赋0，表示已下单，商家未确认发货
                comm.Parameters.AddWithValue("@address", address);
                comm.Parameters.AddWithValue("@name", name);
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                    //执行SQL，返回一个整型变量，如果SQL是对数据库的记录进行操作，那么返回操作影响的记录条数
                    {
                        flag = 1;//商品成功加入订单表
                    }
                    else
                    {
                        flag = 0;//商品添加失败
                    }
                }
                catch (Exception e)
                {
                    flag = 0;//商品添加失败
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                flag = -1;//找不到该商品，无法添加数据进入订单
            }
            return flag;
        }
        public static int order_num()//获取所有订单的条数
        {
            DataSet order_ds = SelectAllOrder();
            return order_ds.Tables[0].Rows.Count;
        }
        public static int order_num_by_state(int state)//获取所有订单的条数
        {
            DataSet order_ds = SelectOrderState(state);
            return order_ds.Tables[0].Rows.Count;
        }
        public static int order_sum(int state)//获取订单在某一状态下的销售额
        {
            DataSet order_ds = SelectOrderState(state);
            int sum = 0, new_sum = 0;//定义初始销售额为0元
            if (order_ds.Tables[0].Rows.Count > 0)//如果在该订单状态下有数据
            {
                for(int i = 0; i < order_ds.Tables[0].Rows.Count; i++)
                {
                    new_sum = Convert.ToInt32(order_ds.Tables[0].Rows[i]["商品总额"].ToString());
                    sum = sum + new_sum;
                }
            }
            else
            {
                sum = 0;//购物车是空的，则无法添加数据进入订单
            }
            return sum;
        }
        public static DataSet SelectAllComment()//读取user_comment表中的所有信息
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from user_comment";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static int add_comment(string comment)//新增用户评论数据记录
        {
            string strConn, strComm;
            int flag = 0;
            string datetime;
            DataSet ds = SelectAllComment();
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            strComm = "insert into user_comment(评价编号,评价内容,评价时间) values(@index,@comment,@datetime)";
            SqlCommand comm = new SqlCommand(strComm, conn);
            datetime = DateTime.Now.ToShortDateString().ToString();
            comm.Parameters.AddWithValue("@index", ds.Tables[0].Rows.Count + 1);
            comm.Parameters.AddWithValue("@comment", comment);
            comm.Parameters.AddWithValue("@datetime", datetime);
            try{
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)//执行SQL，返回一个整型变量，如果SQL是对数据库的记录进行操作，那么返回操作影响的记录条数
                {
                    flag = 1;//成功提交评论
                }
                else{
                    flag = 0;//评论添加失败
                }
            }
            catch (Exception e)
            {
                flag = 0;//评论添加失败
            }
            finally
            {
                conn.Close();
            }
        return flag;
        }
        public static int add_goods(string name, string price, string stock)//新增用户评论数据记录
        {
            string strConn, strComm;
            int flag = 0;
            int int_stock = Convert.ToInt32(stock);
            DataSet ds = SelectGoodsStoreAll();//查找商品表中的全部商品
            DataSet ds_goods = SelectGoodsStore(name);//查找商品表中有无该商品信息
            if (ds_goods.Tables[0].Rows.Count > 0)//如果查找到了该商品
            {
                flag = -1;//查找到该商品，不需要添加
            }
            else{
                string datetime;
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                strComm = "insert into goods(商品编号,商品名称,商品价格,商品库存) values(@index,@name,@price,@stock)";
                SqlCommand comm = new SqlCommand(strComm, conn);
                datetime = DateTime.Now.ToShortDateString().ToString();
                comm.Parameters.AddWithValue("@index", ds.Tables[0].Rows.Count + 1);
                comm.Parameters.AddWithValue("@name", name);
                comm.Parameters.AddWithValue("@price", price);
                comm.Parameters.AddWithValue("@stock", stock);
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)//执行SQL，返回一个整型变量，如果SQL是对数据库的记录进行操作，那么返回操作影响的记录条数
                    {
                        flag = 1;//成功添加商品
                    }
                    else
                    {
                        flag = 0;//商品添加失败
                    }
                }
                catch (Exception e)
                {
                    flag = 0;//商品添加失败
                }
                finally
                {
                    conn.Close();
                }
            }
            return flag;
        }
        public static DataSet SelectGoodsDelivery(string order_index)//查询发货表的信息（依据订单编号）
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from goods_delivery where 订单编号=@order_index";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@order_index", order_index);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet SelectAllDelivery()//查询发货表的信息（依据订单编号）
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from goods_delivery";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static int add_goods_delivery(string company, string order, string sum, string order_index, string address1, string address2)//新增发货物流信息
        {
            string strConn, strComm;
            int flag = 0;
            DataSet ds = SelectAllDelivery();//查找发货表中的全部数据
            DataSet ds_order = SelectGoodsDelivery(order_index);//查找发货表中有没有该订单编号
            if (ds_order.Tables[0].Rows.Count > 0)//如果查找到了该商品
            {
                flag = -1;//订单已经发货，不需要添加
            }
            else
            {
                string datetime;
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                strComm = "insert into goods_delivery(发货编号,发货物流,物流单号,交易金额,发货时间,订单编号,发货地址,收货地址) values(@index,@company,@order,@sum,@datetime,@order_index,@address1,@address2)";
                SqlCommand comm = new SqlCommand(strComm, conn);
                //datetime = DateTime.Now.ToShortDateString().ToString();
                datetime = DateTime.Now.ToString();
                comm.Parameters.AddWithValue("@index", ds.Tables[0].Rows.Count + 1);
                comm.Parameters.AddWithValue("@company", company);
                comm.Parameters.AddWithValue("@order", order);
                comm.Parameters.AddWithValue("@sum", sum);
                comm.Parameters.AddWithValue("@datetime", datetime);
                comm.Parameters.AddWithValue("@order_index", order_index);
                comm.Parameters.AddWithValue("@address1", address1);
                comm.Parameters.AddWithValue("@address2", address2);
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)//执行SQL，返回一个整型变量，如果SQL是对数据库的记录进行操作，那么返回操作影响的记录条数
                    {
                        flag = 1;//成功添加新的发货信息
                    }
                    else
                    {
                        flag = 0;//发货信息添加失败
                    }
                }
                catch (Exception e)
                {
                    flag = 0;//发货信息添加失败
                }
                finally
                {
                    conn.Close();
                }
            }
            return flag;
        }
        public static DataSet SelectOrder(string order_index)//根据订单编号查找订单数据
        {
            string strConn, strComm;
            strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
            strComm = "select * from user_order where 订单编号=@order_index";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand comm = new SqlCommand(strComm, conn);
            comm.Parameters.AddWithValue("@order_index", order_index);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static int update_order_state(string order_index, int state)//更新user_state中的订单状态数据
        {
            string strConn;
            int flag = 0;
            DataSet ds_order = SelectOrder(order_index);//查找对应订单名称的列
            if (ds_order.Tables[0].Rows.Count > 0) //如果找到该订单
            {
                string strcomm = "update user_order set 订单状态=@state where 订单编号=@order_index";
                strConn = ConfigurationManager.AppSettings["ConnStr"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand comm = new SqlCommand(strcomm, conn);
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@order_index", order_index);
                comm.Parameters.AddWithValue("@state", state);
                try
                {
                    conn.Open();
                    if (comm.ExecuteNonQuery() > 0)
                        flag = 1;
                    else
                        flag = 0;
                }
                catch (SqlException err)
                {
                    flag = 0;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                flag = -1;//找不到该订单
            }
            return flag;
        }
    }
}
