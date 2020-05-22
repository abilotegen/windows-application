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
    public partial class Login : Form
    {
        public Login()
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
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new Registration();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void textBox1_Click(object sender, EventArgs e)
        {
            loginpasstextbx.Clear();
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            loginpasstextbx.ForeColor = Color.FromArgb(0, 122, 204);

            panel2.ForeColor = Color.WhiteSmoke;
            loginpasstexbx.ForeColor = Color.WhiteSmoke;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            loginpasstexbx.Clear();
            panel4.ForeColor = Color.FromArgb(78, 184, 206);
            loginpasstexbx.ForeColor = Color.FromArgb(0, 122, 204);

            


            panel2.ForeColor = Color.WhiteSmoke;
            loginpasstextbx.ForeColor = Color.WhiteSmoke;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            String loginUser = loginpasstextbx.Text;
            String loginPass = loginpasstexbx.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` where `login` = @uL and  `pass` = @uP ", db.getConnection() );
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value=loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = loginPass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {

                    var cells = row.ItemArray;
                    Class.globalUsername = Convert.ToString(cells[1]);
                    Class.globalName = Convert.ToString(cells[4]);
                    Class.globalSurname = Convert.ToString(cells[5]);
                    Class.globalEmail = Convert.ToString(cells[3]);
                    Class.globalPassword = Convert.ToString(cells[6]);


                }
                this.Hide();
                Welcome form1 = new Welcome();
                form1.ShowDialog();
                MainPage form = new MainPage();
                form.Show();

            }
            else
                MessageBox.Show("No");

        }

        private void loginusertextbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginusertextbx_Leave(object sender, EventArgs e)
        {
            if (loginpasstextbx.Text == "")
                loginpasstextbx.Text = "Username";
        }

        private void loginpasstexbx_Leave(object sender, EventArgs e)
        {
            if (loginpasstextbx.Text == "")
                loginpasstextbx.Text = "Password";
        }

        private void loginpasstexbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

public static class Class
{
    public static String globalName, globalSurname, globalUsername, globalEmail,globalPassword;
    public static ImageFormatConverter globalImg;
}