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

