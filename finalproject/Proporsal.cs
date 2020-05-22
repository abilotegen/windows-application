using MySql.Data.MySqlClient;
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
    public partial class Proporsal : Form
    {
        public Proporsal()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {

            DB db = new DB();
         
            MySqlCommand comm = new MySqlCommand("INSERT INTO `idea` (`login`,`number`,`idea`) VALUES (@q11,@q22,@q33)", db.getConnection());


            comm.Parameters.Add("@q11", MySqlDbType.VarChar).Value = textlog.Text;
            comm.Parameters.Add("@q22", MySqlDbType.VarChar).Value = textnomber.Text;
            comm.Parameters.Add("@q33", MySqlDbType.VarChar).Value = textidea.Text;
           


            db.openConnection();

            if (comm.ExecuteNonQuery() == 1)

                MessageBox.Show("Succesful");
            else
                MessageBox.Show("No");

            db.closeConnection();


           

        }
    }
}
