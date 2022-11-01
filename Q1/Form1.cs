using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text = String.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//輸入數值是否在[1,99]
			//先在textbox輸入一個值
			//在用if去判斷是否有在1~99內
			//然後回傳到lable : true or false
			textBox1.Text= string.Intern(textBox1.Text);
			string num = textBox1.Text;
			//string yes = "有在範圍內";
			//string no = "沒在範圍內";
			int result = Convert.ToInt32(num);
			if (result > 0 && result < 100)
			{
				//string yes = "有在範圍內";
				label1.Text= "yes";
			}
			else
			{
				//string no = "沒在範圍內";
				label1.Text= "no";
			}
			
			
		}

		
	}
}
