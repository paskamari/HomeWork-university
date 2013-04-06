using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace add_list
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != -1)
            {
                ListBox2.Items.Add(ListBox1.SelectedItem);
                ListBox1.Items.Remove(ListBox1.SelectedItem);
            }

        }

        protected void btnaddall_Click(object sender, EventArgs e)
        {
            while (ListBox1.Items.Count != 0)
            {
                ListBox2.Items.Add(ListBox1.Items[0]);
                ListBox1.Items.Remove(ListBox1.Items[0]);
            }

        }

        protected void btndel_Click(object sender, EventArgs e)
        {
            if (ListBox2.SelectedIndex != -1)
            {
                ListBox1.Items.Add(ListBox2.SelectedItem);
                ListBox2.Items.Remove(ListBox2.SelectedItem);
            }
        }

        protected void btndelall_Click(object sender, EventArgs e)
        {
            while (ListBox2.Items.Count != 0)
            {
                ListBox1.Items.Add(ListBox2.Items[0]);
                ListBox2.Items.Remove(ListBox2.Items[0]);
            }
        }
    }
}