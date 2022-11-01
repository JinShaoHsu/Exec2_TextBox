using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
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
			string gettime = dateTimePicker1.Value.ToString("yyyy");
			string dt = DateTime.Now.ToString("yyyy");
			int gettime2 =Convert.ToInt32(gettime);
			int dt2 = Convert.ToInt32(dt);
			if(dateTimePicker1.Value > DateTime.Now)
			{
				label1.Text = "生日不可超過現在";
			}else if (dt2 - gettime2 <13)
			{
				label1.Text = "您的生日小於13歲";
			}
			else
			{
				label1.Text = "您的生日大於13歲";
			}
			
		}
	}
	
}
