﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace number
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            if (textBox1.Text != "") { 
                string[] y = { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه", "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" };
                string[] dah = { "صفر", "ده", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
                int a = Convert.ToInt32(textBox1.Text);
                if (a < 20)
                {
                    label1.Text = y[a];
                }
                else if (a < 100)
                {
                    label1.Text = dah[a / 10] + " و " + y[a % 10];
                }
            }
		}
		
	}
}
