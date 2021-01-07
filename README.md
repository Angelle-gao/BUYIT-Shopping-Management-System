# BUYIT-Shopping-Management-System
C# WinForm开发的一个交互式小型购物管理系统，连接SQL Server数据库
1	系统功能概述
1.1 项目前景
1.1.1 背景与机遇
	在传统的实体店铺或超市购物过程中，购物双方需要进行繁琐的人工交流，彼此之间往往无法得到有效沟通，同时由于时空的限制，缺乏了大量的自由互动。对于中小型的购物场景，往往商家与买家处于一个比较封闭内在的购物限制中（譬如企业内部的内部价交易），而不需要公开的交易系统（如目前常见的网购商城）。而本管理系统在实现电子化贸易的同时，购物双方可以从不同端口参与可变规模，有一定系统边界的交易中去，实现中小范围的购物互通，大大迎合了具有一定特殊性的用户需求。本系统的系统化，信息化，智能化，自动化和规范化，能够提高购物的效率。
1.1.2	 业务需求
1.	是一个支持联机用户、卖家、商品查询、商品管理、订单处理、订单查询、订单审核、发货退货事务的高级系统
2.	为客户提供历史交易事务的查询
3.	支持用户、商品和卖家信息实时存储与查询
4.	保存足够多的历史数据以支持销售分析和市场需求预测
1.2 系统功能概述
	本系统旨在为用户和商家（管理员）提供交互的购物管理服务，具体实现的功能如下所示：
1.	用户和管理员选择相对应的服务界面，并进行登陆、注册、信息管理（密码修改，个人和系统信息查看）。
2.	用户查看、筛选、排序商品信息，选择心仪的商品添加进购物车或直接购买。
3.	用户管理购物车，修改购物车中的商品数量，计算购物车总额，结算购物车。
4.	用户查看商家发货订单信息，确认收货或因为发货或私人问题选择退款/退货。
5.	用户查看退款/售后订单及其处理情况。
6.	用户查看已经确认收货或退款/售后处理完毕的历史订单。
7.	用户对系统进行使用反馈、评价。
8.	商家/管理员对商品进行管理。查看、筛选和依据价格排序商品信息，修改已经添加进系统的商品价格和商品库存，删除商品记录，添加新的商品信息。
9.	商家/管理员对订单进行管理。对未读/未发货订单进行发货确认，查看已发货订单的动态，处理退款/售后订单，统计已完成订单的销售数据。
10.	商家/管理员对用户信息进行管理。注销无用用户，修改用户联系方式。
1.3 用户特征
用 户	描 述
系统客户	系统存储有多个客户，在线上进行商品浏览、购买，线下确认收货，线上确认收货或退款/退货等。具有简单的计算机操作能力，对商品和订单信息不具有管理。
系统商家	系统原则上包含一个集团商家，多个子商家，都具有系统/集团商品。
系统管理员	系统管理员兼具商品、订单、用户管理和数据库管理、程序设计管理等功能，是维护系统正常运行的必要条件。
3	系统架构和功能模块
3.1 模块职责
3.1.1 模块视图
	本系统采用C/S架构设计，并使用C#语言进行开发。客户机通过局域网与服务器相连，接受用户的请求，并通过网络向服务器提出请求，对数据库进行操作。服务器接受客户机的请求，将数据提交给客户机，客户机将数据进行计算并将结果呈现给用户。
	本系统采用的模块结构视图如下所示：
 
3.1.2 各层职责
层	职责
用户界面层	提供购物商城系统用户页面显示，界面引导，接受用户输入，并向应用服务器发送服务请求，显示用户操作的处理结果
业务逻辑层	提供外来接口调用和执行业务逻辑服务，向数据库端发送请求
类库支持层	封装系统开发底层端口和数据库访问端口的类支持
数据存储层	执行数据逻辑，运行sql server数据库操作语句和存储过程
3.1.3 系统调用类库
标准类库	服务调用方
System
System.Windows.Forms
System.ComponentModel	用户界面层
System
System.Configuration	业务逻辑层
System
System.Data
System.Data.SqlClient
System.Configuration	类库支持层
3.2 用户界面层功能模块设计
3.2.1 界面交互关系
	根据需求，系统设计出21个Windows窗体用户界面，包括系统欢迎界面，客户注册界面，客户登录界面，客户登录界面，客户浏览商品主界面，客户购物车界面，客户订单管理界面，客户确认收货界面，客户退款/售后管理界面，客户历史订单管理界面，客户系统反馈界面，客户密码修改界面，管理员/商家登录界面，管理员/商家商品管理主界面，管理员/商家添加商品界面，管理员/商家订单管理主界面，管理员/商家未确认订单管理界面，管理员/商家已发货订单管理界面，管理员/商家未确认订单管理界面，管理员/商家已发货订单管理界面，管理员/商家退款/售后订单管理界面，管理员/商家已完成订单管理界面，管理员/商家已完成订单管理界面，管理员/商家用户管理界面，管理员/商家密码修改界面。界面跳转如下所示：
 
3.2.1 模块功能描述
Windows窗体名称	界面功能描述
welcome.cs	系统欢迎界面
register.cs	客户注册界面
login.cs	客户登录界面
MainForm.cs	客户浏览商品主界面
ShoppingCar.cs	客户购物车界面
user_order.cs	客户订单管理界面
receive_goods.cs	客户确认收货界面
after_sale.cs	客户退款/售后管理界面
history_order.cs	客户历史订单管理界面
user_comment.cs	客户系统反馈界面
update_password.cs	客户密码修改界面
manager_login.cs	管理员/商家登录界面
mainForm_manager.cs	管理员/商家商品管理主界面
add_goods.cs	管理员/商家添加商品界面
order_process.cs	管理员/商家订单管理主界面
order_process0.cs	管理员/商家未确认订单管理界面
order_process1.cs	管理员/商家已发货订单管理界面
order_process3.cs	管理员/商家退款/售后订单管理界面
order_process4.cs	管理员/商家已完成订单管理界面
manager_user.cs	管理员/商家用户管理界面
update_password_manager.cs	管理员/商家密码修改界面

3.2.2 模块功能和结构
由于系统内存在一些相似结构的控件和使用逻辑，为了简化，仅仅详细叙述前四个窗体的详细控件结构。
1.	系统欢迎界面welcome.cs
 

控件名称	功能描述	对应函数
Label1	显示用户欢迎来到BUYIT!购物系统	
Label3	显示用户选择登陆身份	
Label4	系统宣传语“全方位的电商商城综合管理系统”	
Button1	用户登录入口。选择该按钮并点击进入用户登陆页面。	private void button1_Click(object sender, EventArgs e)
Button2	管理员登录入口。选择该按钮并点击进入管理员登录页面。	private void button2_Click(object sender, EventArgs e)
Button3	退出系统按钮。点击该按钮退出程序。	private void button3_Click(object sender, EventArgs e)
2.	客户登陆页面login.cs
 

控件名称	功能描述	对应函数
Label1	显示标题“欢迎登录BUYIT!购物管理系统”	
Label2	显示输入用户账号“用户账号：”	
Label3	显示输入用户密码“用户密码：”	
textBox1	输入和读入用户账号的文本框	
textBox2	输入和读取用户密码的文本框	
Button1	登录按钮，点击按钮进入客户浏览商品主界面	private void button1_Click(object sender, EventArgs e)
Button2	注册按钮，点击按钮进入客户注册界面	private void button2_Click(object sender, EventArgs e)
Button3	退出按钮，点击按钮退回到系统欢迎界面	private void button3_Click(object sender, EventArgs e)
	为了测试和调试系统的可用性，开发者在数据库中预先设置了少量的用户账号，可以使用这些账户和密码直接登录（全部小写）：
id	用户账号	用户密码
0	wanghao	wh123
1	gaolele	gyt123
2	tanxinyu	txy123

3.	客户注册界面register.cs
 

控件名称	功能描述	对应函数
Label1	显示标题“新用户注册”	
Label2	显示输入用户账号“用户账号：”	
Label3	显示输入用户密码“用户密码：”	
Label4	显示输入联系电话“联系电话：”	
Label5	显示已经输入的用户账号位数	
Label6	显示已经输入的账户密码位数	
Label7	显示至少输入10位数字	
textBox1	输入和读入用户账号的文本框	
textBox2	输入和读取用户密码的文本框	
textBox3	输入和读取联系电话的文本框	
Button1	退出按钮，点击按钮退回用户登录界面	private void button1_Click(object sender, EventArgs e)
Button2	注册按钮，点击按钮确认注册新用户，并添加新记录进入表login_user中	private void button2_Click(object sender, EventArgs e)
Button3	重置按钮，初始化文本框数据	private void button3_Click(object sender, EventArgs e)
4.	客户浏览商品主界面MainForm.cs
 

控件名称	功能描述	对应函数
menuStrip1	客户界面菜单栏，点击菜单栏上标识的按钮可以进入对应界面，其中购物车中暂无数据时，会提示警告弹窗，无法显示购物车界面，需要手动添加数据进入购物车；可以直接查看和管理用户订单和查看修改用户信息，设置为新增窗口显示。	
Label1	显示标题“心选好物清单”	
Label2	显示“欢迎您！”	
Label3	显示“当前用户为：”+用户账号，即显示当前登录的用户账号信息	
Label4	嵌入groupBox2，显示“商品名：”，提示输入查询商品信息的关键字、词	
Label5	显示“商品名片（点击商品区域展示）”	
Label6	显示“您选择的商品为：”	
Label7	显示“商品编号：”	
Label8	显示“商品名称：”	
Label9	显示“商品价格：”	
Label10	显示“商品库存：”	
Label11	显示“请输入需要的数量：”	
Label12	显示“/件”	
Label13	显示选中商品的编号	
Label14	显示选中商品的名称	
Label15	显示选中商品的价格	
Label16	显示选中商品的库存	
Label17	显示“请输入收货地址：”	
textBox1	嵌入groupBox2，输入和读取商品名称关键词	private void textBox1_TextChanged(object sender, EventArgs e)
textBox2	输入和读取商品数量（必填）	
textBox3	输入和读取收货地址（选择直接购买按钮必填）	
groupBox1	承载依据价格排序的按钮的容器	
groupBox2	承载查询商品名称过滤显示的容器	
dataGridView1	绑定数据库，显示商品信息	private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
radioButton1	升序依据商品价格排列商品信息	private void radioButton1_CheckedChanged(object sender, EventArgs e)
radioButton2	降序依据商品价格排列商品信息	private void radioButton2_CheckedChanged(object sender, EventArgs e)
Button1	退出界面按钮，点击按钮退回系统欢迎界面，并自动清空购物车数据	private void button1_Click(object sender, EventArgs e)
Button2	加入购物车按钮，选中dataGridView1中的任意一个商品数据，待下部分标签显示商品信息后填写商品数量，点击按钮加入购物车	private void button2_Click(object sender, EventArgs e)
Button3	直接购买按钮，客户选中某一商品后，填写商品数量和收货地址后即可成功生成新的订单	private void button3_Click(object sender, EventArgs e)
Button4	刷新页面窗口，刷新数据源	private void button4_Click(object sender, EventArgs e)
	在该界面可以实现用户浏览、筛选、排序商品信息，点击具体的商品信息，输入需要的商品数量将商品加入购物车或继续填写收货地址、直接下单，更新商品数据等。
5.	客户购物车界面ShoppingCar.cs
将商品添加至购物车后，点击菜单栏中的“购物车”进入（如果未添加商品无法跳转）。显示客户在商品浏览主界面向购物车添加的商品购买意向信息，包括商品序号（购物车商品编号，是随着数据修改而按序更新的），商品名称，单价，商品数量和总额（=单价×商品数量），并查看购物车总额。用户可以实时根据商品总额进行升序或降序排列，或依据商品名称筛选商品信息）。系统设置用户仅可以修改商品数量；或删除一条购物车记录，单击“保存修改”按钮进行数据操作。由于商家是根据用户购买的商品名称进行配货的，所以设置系统只能分批将商品生成新的订单，输入有效的收货地址后，选中指定商品的行（注意是整行），点击“结算商品”添加新的订单。点击“退出购物车”退出购物车。
 
6.	客户订单管理界面user_order.cs
点击菜单栏中的“用户订单”进入。查看所有的用户订单，其中订单状态参数的含义如下：
0:已下单但未发货
1:已发货未确认收货
2:确认收货
3:退款/退货/售后
4:已退款/退货/售后服务结束
客户可以查看和筛选订单信息。
 
7.	客户确认收货界面receive_goods.cs
点击菜单栏中的“待收货”进入。客户选择已经完成的订单的整行，点击“确认收货”，系统自动更新订单状态为2；点击“我要退款/退货”，系统自动更新订单状态为3；点击“退出界面”，关闭此窗口，显示用户浏览商品主界面。
 
8.	客户退款/售后管理界面after_sales.cs
点击菜单栏中的“退款/售后”进入。用户查看正在退款/售后中的订单。点击“退出界面”，关闭此窗口，显示用户浏览商品主界面。
 
9.	客户历史订单管理界面history_order.cs
点击菜单栏中的“历史订单”进入。用户查看历史订单（订单状态为2或4）。点击“退出界面”，关闭此窗口，显示用户浏览商品主界面。
 
10.	客户系统反馈界面user_comment.cs
点击菜单栏中“个人中心”下的“系统反馈”进入。在文本框中填写反馈后，单击“提交反馈”提交，user_comment数据表中新增一条用户反馈记录（匿名）。
 
11.	客户密码修改界面update_password.cs
点击菜单栏中的“更改密码”进入。系统客户必须输入正确的用户账号和原来的用户密码，再输入新密码，点击“确认更改”，系统通过初始账号信息匹配后可修改用户密码信息。点击“重置”初始化文本框输入内容。点击“退出页面”退出窗口。
 
12.	管理员/商家登录界面manager_login.cs
从系统欢迎界面点击“管理员登录入口”进入。在对应文本框中输入正确的管理员账号和账户密码，点击“登录”进入管理员/商家商品管理主界面。点击“退出”退出窗口，返回系统欢迎界面。
 
为了测试和调试系统的可用性，开发者在数据库中预先设置了少量的管理员账号，可以使用这些账户和密码直接登录（全部小写）：
id	用户账号	用户密码
0	wanghao	wh123
1	gaolele	gyt123
2	tanxinyu	txy123

13.	管理员/商家商品管理主界面mainForm_manager.cs
登录后显示的管理员/商家商品管理主界面。管理员/商家可以修改商品的价格和库存信息，修改完成后点击“保存修改”保存数据修改。选中需要删除的整行数据进行删除。根据条件排序和筛选显示的商品数据。操作完成后点击“刷新页面”刷新商品信息。点击“退出系统”退出界面，返回系统欢迎页面。
 
14.	管理员/商家添加商品界面add_goods.cs
点击主界面菜单栏的“添加商品”显示。输入商品名称、商品价格和商品库存，点击“确认添加”即可添加一条新的商品信息。点击“重置”初始化所有文本框；点击“退出窗口”退出窗口。
 
15.	管理员/商家订单管理主界面order_process.cs
在任一子订单管理页面的菜单栏的“订单管理”按钮点击显示。可以查看所有的订单信息，进行浏览、查找和排序；点击“未读/未发货订单管理”进入管理员/商家未确认订单管理界面；点击“已发货订单管理”进入管理员/商家已发货订单管理界面；点击“退款/售后订单管理”进入管理员/商家退款/售后订单管理界面。点击“退出界面”关闭窗口，返回主界面；点击“刷新页面”刷新数据。
 
16.	管理员/商家未确认订单管理界面order_process0.cs
点击主界面“订单管理”下的“未读/未发货订单（0）”进入。商家可以查看目前未处理的订单数、筛选订单信息。选中发货的整条订单数据，选择发货物流（选择成功后会弹出确认弹窗），输入快递单号，输入发货的具体地址，单击“确认发货”即可成功发货；点击“退出界面”退出窗口；点击“刷新页面”刷新数据。
 
17.	管理员/商家已发货订单管理界面order_process1.cs
点击主界面“订单管理”下的“已发货订单（1）”进入。商家可以查看目前已发货/未确认发货的订单数、筛选订单信息。点击“退出界面”退出窗口；点击“刷新页面”刷新数据。
 
18.	管理员/商家退款/售后订单管理界面order_process3.cs
点击主界面“订单管理”下的“退款/售后订单（3）”进入。商家可以查看退款/售后的订单信息。商家处理好退款/售后以后，选中已处理的整条订单数据，单击“处理退款/售后”即可成功更改订单状态为4；点击“退出界面”退出窗口；点击“刷新页面”刷新数据。
 
19.	管理员/商家已完成订单管理界面order_process4.cs
点击主界面“订单管理”下的“已完成订单（4）”进入。商家可以统计已完成的订单数、销售额。点击“退出界面”退出窗口。
 
20.	管理员/商家用户管理界面manage_user.cs
点击主界面“用户管理”进入。管理员可以根据用户的请求更改指定用户的联系电话，点击“保存修改”进行保存。查找用户账号中包含某一关键字/词的数据。对于恶意交易或者长期闲置账号的用户，管理员可以选择整行数据点击“注销用户”进行删除。点击“退出界面”退出窗口，返回主界面。
 
21.	管理员/商家密码修改界面update_password_manager.cs
点击主界面“管理员中心”下的“更改密码”进入。输入正确的原始管理员账号和密码，再输入新密码，点击“确认更改”进行更改；点击“重置”初始化全部文本框；点击“退出界面”退出窗口，返回主界面。
 
3.3 业务逻辑层功能模块设计
3.3.1 模块功能描述
	包括两个类，分别为：
类名	描述
Program.cs	控制应用程序的生成和启动顺序
DataAccess.cs	用于业务层操作和和数据库进行连接、操作

3.2.2 模块服务和接口
1.	Program.cs
接口名	描述
static void Main()	应用程序参数配置和启动
2.	DataAccess.cs
接口名	描述
public static DataSet SelectUser(string username)	根据用户账号查询该用户的整条数据记录，并返回为一个数据集dataSet
public static DataSet SelectUser(int id)	根据id查询该用户的整条数据记录，并返回为一个数据集dataSet
public static DataSet SelectAllUser()	查询所有用户的数据记录，并返回为一个数据集dataSet
public static DataSet SelectUsers(string username)	查询用户名包含某一关键字/词的所有用户数据，并返回为一个数据集dataSet
public static int DeleteUser(string username)	根据用户账号删除该用户的整条数据记录
public static int DeleteUser(int id)	根据id删除该用户的整条数据记录
public static int AddUser(string u, string p, string t)	给定用户账号、用户密码和联系电话，新增一条用户信息
public static int update_login_user_password(string username, string password, string new_password)	更新login_user中的账户密码
public static int update_user_phone(int id, string username, string phone)	更新login_user中的联系电话
public static DataSet SelectAllManager()	查询login_manager所有管理员的数据记录，并返回为一个数据集dataSet
public static DataSet SelectManager(string managername)	根据管理员账号查询该管理员的整条数据记录，并返回为一个数据集dataSet
public static int update_login_manager_password(string managername, string password, string new_password)	更新管理员密码
public static DataSet SelectGoods(string name)	查询shopping_car中指定商品名称的数据记录，并返回为一个数据集dataSet
public static DataSet SelectAllGoods()	查询shopping_car中所有的数据记录，并返回为一个数据集dataSet
public static int SelectAllGoodsJudge()	判断shopping_car购物车中有无数据
public static int add_shoppingcar(string i, string n, int p, int q, int s)	新增一条数据进入shopping_car
public static int DeleteShoppingCar(int index)	删除某一个编号的购物车数据
public static int CountSum()	计算购物车中的全部商品总额
public static int DeleteAllShoppingCar()	清空shopping_car购物车数据
public static int DeleteShoppingCarGoods(string name)	根据商品名称删除购物车中的一条记录
public static int DeleteOrderByState(string name, string state)	根据商品名称和指定订单状态删除一条user_order订单信息
public static DataSet SelectGoodsStore(string name)	根据商品名称查询商品表中的商品信息，并返回一个数据集DataSet
public static DataSet SelectGoodsStoreAll()	查询商品表中的全部商品信息，并返回一个数据集DataSet
public static int DeleteStoreGoods(string name)	根据商品名称删除商品表goods中的商品信息
public static int update_goods(int i, string name, string price, string stock)	更改指定goods中商品的价格和库存
public static int update_goodsstore_stock_sub(string n, int q)	更改商品表goods中的库存为原有库存减去已购买的商品数量
public static int update_goodsstore_stock_plus(string n, int q)	更改商品表goods中的库存为原有库存加上已补充的商品数量
public static int update_shoppingcar(string name, string q)	更改购物车shopping_car中某一商品名称的商品数量
public static DataSet SelectAllOrder()	查询user_order所有的数据记录，并返回为一个数据集dataSet
public static int add_order_from_shoppingcar(string address)	结算购物车中的商品订单新增为一条user_order订单记录
public static int add_order(string name, string quantity, int sum, string address)	新增一条user_order订单数据
public static int order_num()	计算订单的总个数
public static int order_num_by_state(int state)	计算某一订单状态的订单的个数
public static int order_sum(int state)	根据某一订单状态计算订单的销售总额
public static DataSet SelectAllComment()	查询user_comment所有的数据记录，并返回为一个数据集dataSet
public static int add_comment(string comment)	新增系统反馈进入user_comment表
public static int add_goods(string name, string price, string stock)	新增一条商品信息进入goods表
public static DataSet SelectGoodsDelivery(string order_index)	根据订单编号查询goods_delivery发货信息表中的一条数据并返回为一个数据集dataSet
public static DataSet SelectAllDelivery()	查询goods_delivery发货信息表中的全部数据并返回为一个数据集dataSet
public static int add_goods_delivery(string company, string order, string sum, string order_index, string address1, string address2)	新增一条数据进入goods_delivery发货信息表
public static DataSet SelectOrder(string order_index)	根据订单编号查询user_order订单信息表数据并返回为一个数据集dataSet
public static int update_order_state(string order_index, int state)	更改user_order订单数据中的指定订单编号的订单状态
