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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblFirstname.Text = Class.globalName;
            lbllSurname.Text = Class.globalSurname;
            lblUsername.Text = Class.globalUsername;
            lblemail.Text = Class.globalEmail;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
