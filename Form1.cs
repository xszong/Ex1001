using System; // 引入基本的类和功能
using System.Collections.Generic; // 引入集合类的命名空间（未在本程序中使用）
using System.ComponentModel; // 引入组件模型的命名空间（未在本程序中使用）
using System.Data; // 引入数据相关的命名空间（未在本程序中使用）
using System.Drawing; // 引入图形相关的命名空间（未在本程序中使用）
using System.Linq; // 引入 LINQ 查询功能的命名空间（未在本程序中使用）
using System.Text; // 引入字符串处理的命名空间（未在本程序中使用）
using System.Threading.Tasks; // 引入异步编程的命名空间（未在本程序中使用）
using System.Windows.Forms; // 引入 Windows Forms 应用程序所需的命名空间

namespace Ex1001 // 定义一个命名空间 Ex1001
{
    public partial class Form1 : Form // 定义一个名为 Form1 的类，继承自 Form
    {
        public Form1() // 构造函数
        {
            InitializeComponent(); // 初始化组件，设置窗体及其控件
        }

        // 按钮点击事件处理程序
        private void btnShow_Click(object sender, EventArgs e)
        {
            // 获取当前的日期和时间，并将其转换为字符串
            lblDisplay.Text = DateTime.Now.ToString(); // 在标签上显示当前日期和时间
        }

        // 结束应用程序的按钮事件处理程序
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 关闭应用程序
        }

        // 标签点击事件处理程序（当前未使用）
        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        // 窗体加载事件处理程序（当前未使用）
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
//构造函数：

//Form1()：调用 InitializeComponent() 方法来初始化窗体和控件。
//按钮事件：

//btnShow_Click：当用户点击 "Show" 按钮时，获取当前日期和时间并显示在标签 lblDisplay 上。
//btnEnd_Click：当用户点击 "End" 按钮时，调用 Application.Exit() 结束应用程序。
//未使用的事件：

//lblDisplay_Click 和 Form1_Load 方法当前未实现任何功能，但它们可以用于处理标签点击事件和窗体加载事件。
//注意事项
//控件初始化：InitializeComponent() 方法是自动生成的，用于初始化窗体上的控件。
//事件处理：确保将事件处理程序正确地连接到窗体上的控件，例如按钮和标签。