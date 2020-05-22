using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class example : Form
    {
        public example()
        {
            InitializeComponent();
        }

      

        private void example_Load(object sender, EventArgs e)
        {
            l0.Text = Class1.first;
            l1.Text = Class1.first;
            l2.Text = Class1.second;
            l3.Text = Class1.third;
            l4.Text = Class1.forth;
            l5.Text = Class1.fifth;
            l6.Text = Class1.sixth;
            l7.Text = Class1.seventh;
            l8.Text = Class1.eightth;
            l9.Text = Class1.nineth;
            l10.Text = Class1.tenth;
        }
    }
}
