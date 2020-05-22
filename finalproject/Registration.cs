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
using MySql.Data.MySqlClient;

namespace finalproject
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="Username")
            {
                MessageBox.Show("Write Username");
                return;
            }
            if (checkuser())
                return;
            if(textBox2.Text =="Email")
            {
                MessageBox.Show("write Email");
            }
            if(textBox3.Text == "Password")
            {
                MessageBox.Show("write Password");
            }

            DB db = new DB();

            MySqlCommand comm = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `email`,`firstname`,`surname`,`picture`) VALUES (@usern , @pas, @em, @fst, @srn, @pic)", db.getConnection());

           
            comm.Parameters.Add("@usern", MySqlDbType.VarChar).Value = textBox1.Text;
            comm.Parameters.Add("@pas", MySqlDbType.VarChar).Value = textBox3.Text;
            comm.Parameters.Add("@em", MySqlDbType.VarChar).Value = textBox2.Text;
            comm.Parameters.Add("@fst", MySqlDbType.VarChar).Value = firstnm.Text;
            comm.Parameters.Add("@srn", MySqlDbType.VarChar).Value = surnm.Text;
            comm.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.Image;

            db.openConnection();

            if (comm.ExecuteNonQuery() == 1)
                MessageBox.Show("Succesful");
            else
                MessageBox.Show("Failed");

            db.closeConnection();

            this.Hide();
            var form2 = new Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        public Boolean checkuser() 
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` where `login` = @uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox1.Text;
           

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show(" write different username");
                return true;
            }
            else
                return false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel2.ForeColor = Color.FromArgb(78,184,206);
            textBox1.ForeColor = Color.FromArgb(0,122,204);

            panel3.ForeColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            panel4.ForeColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            firstnmpanel5.ForeColor = Color.WhiteSmoke;
            firstnm.ForeColor = Color.WhiteSmoke;

            surnmpanel6.ForeColor = Color.WhiteSmoke;
            surnm.ForeColor = Color.WhiteSmoke;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel3.ForeColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(0, 122, 204);

            panel2.ForeColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            panel4.ForeColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            firstnmpanel5.ForeColor = Color.WhiteSmoke;
            firstnm.ForeColor = Color.WhiteSmoke;

            surnmpanel6.ForeColor = Color.WhiteSmoke;
            surnm.ForeColor = Color.WhiteSmoke;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            panel4.ForeColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(0, 122, 204);

            panel3.ForeColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

        
            panel2.ForeColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            firstnmpanel5.ForeColor = Color.WhiteSmoke;
            firstnm.ForeColor = Color.WhiteSmoke;

            surnmpanel6.ForeColor = Color.WhiteSmoke;
            surnm.ForeColor = Color.WhiteSmoke;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Username";

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                textBox2.Text = "Email";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                textBox3.Text = "Password";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndownload_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            f1.Filter = "Image Files(AllFiles(*.*)|*.*";
            if (f1.ShowDialog() == DialogResult.OK)
            {
                picture.Image = new Bitmap(f1.FileName);
                picturetxtbx.Text = f1.SafeFileName;

            }
        }

        private void firstnm_Click(object sender, EventArgs e)
        {

            firstnm.Clear();
            firstnmpanel5.ForeColor = Color.FromArgb(78, 184, 206);
            firstnm.ForeColor = Color.FromArgb(0, 122, 204);

            panel3.ForeColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            panel4.ForeColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            panel2.ForeColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            surnmpanel6.ForeColor = Color.WhiteSmoke;
            surnm.ForeColor = Color.WhiteSmoke;

        }

        private void surnm_Click(object sender, EventArgs e)
        {
            surnm.Clear();
            surnmpanel6.ForeColor = Color.WhiteSmoke;
            surnm.ForeColor = Color.WhiteSmoke;

            panel3.ForeColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            panel4.ForeColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            panel2.ForeColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            firstnmpanel5.ForeColor = Color.WhiteSmoke;
            firstnm.ForeColor = Color.WhiteSmoke;
        }

        private void picturetxtbx_Click(object sender, EventArgs e)
        {
            picturetxtbx.Clear();
        }
    }
}
