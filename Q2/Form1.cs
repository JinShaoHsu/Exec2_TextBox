using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
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
			DateTime dt =DateTime.Now;
			DateTime dt2 = Convert.ToDateTime(textBox1.Text);
			if(dt2 > dt)
			{
				label1.Text = "您輸入的日期大於今天";
			}else if(dt2 < DateTime.Now)
			{
				label1.Text = "您輸入的日期小於今天";
			}
			else { label1.Text = "您輸入的日期為今天"; }
		}
	}
}
