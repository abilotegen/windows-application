using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Org.BouncyCastle.Asn1.Ocsp;
using MySql.Data.MySqlClient;
using Ubiety.Dns.Core;
using System.Data.SqlClient;
using Request = Org.BouncyCastle.Asn1.Ocsp.Request;

namespace finalproject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected void MainPage_Load(object sender, EventArgs e)
        {
            panel1_Click(null ,e);
        }

        private void closepicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmax.Visible = false;
            btnres.Visible = true;
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnres.Visible = false;
            btnmax.Visible = true;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Profile());
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
       int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Upfrom_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblfirstname.Text = Class.globalName + "  " + Class.globalSurname;
            lblusername.Text = Class.globalUsername;
            lblemail.Text = Class.globalEmail;
        }

        private void emaill_Click(object sender, EventArgs e)
        {

        }

        private void usernamel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure  to close the app", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                
            this.Hide();
            var form2 = new Login();
            form2.Closed += (s, args) => this.Close();
         
            form2.Show();
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.Controllform.Controls.Count > 0)
                this.Controllform.Controls.RemoveAt(0);
          
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Controllform.Controls.Add(fh);
            this.Controllform.Tag = fh;
          
            fh.Show();
        }

        private void usernamepicture_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Page());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Repairs());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Report());
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Proporsal());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Settings());
        }

        private void btnimfo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new information());
        }

        private void btnadres_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Address());
        }
    }
}
