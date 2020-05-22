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
    public partial class Repairs : Form
    {
        public Repairs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String first = combxtypetech.Text;
            String second = combxtypebroke.Text;
            String third = combxtypething.Text;
            String forth = combxDesign.Text;
            String fifth = combxmodel.Text;
            String sixth = combxmodel.Text;
            String seventh = textdate.Text;
            String eight = textdatefinish.Text;
            String nineth = textpay.Text;
            String tenth = combxman.Text;


            DB db = new DB();
            DataTable table = new DataTable();
            MySqlCommand comm = new MySqlCommand("INSERT INTO `technik` (`typetechnik`, `typebroken`, `typedetal`,`typemanufact`,`typemodel`, `typeharakter`,  `startdate`,`finishdate`,`payment`,`manwhorepair`,`code`) VALUES (@q1,@q2,@q3,@q4,@q5,@q6,@q7,@q8,@q9,@q10,@qc)", db.getConnection());


            comm.Parameters.Add("@q1", MySqlDbType.VarChar).Value = combxtypetech.Text;
            comm.Parameters.Add("@q2", MySqlDbType.VarChar).Value = combxtypebroke.Text;
            comm.Parameters.Add("@q3", MySqlDbType.VarChar).Value = combxtypething.Text;
            comm.Parameters.Add("@q4", MySqlDbType.VarChar).Value = combxDesign.Text;
            comm.Parameters.Add("@q5", MySqlDbType.VarChar).Value = combxmodel.Text;
            comm.Parameters.Add("@q6", MySqlDbType.VarChar).Value = textdate.Text;
            comm.Parameters.Add("@q7", MySqlDbType.VarChar).Value = textdatefinish.Text;
            comm.Parameters.Add("@q8", MySqlDbType.VarChar).Value = textdatefinish.Text;
            comm.Parameters.Add("@q9", MySqlDbType.VarChar).Value = textpay.Text;
            comm.Parameters.Add("@q10", MySqlDbType.VarChar).Value = combxman.Text;
            comm.Parameters.Add("@qc", MySqlDbType.VarChar).Value = code.Text;


            db.openConnection();

            if (comm.ExecuteNonQuery() == 1)

                MessageBox.Show("Succesful");
            else
                MessageBox.Show("No");
          
            db.closeConnection();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textdatefinish_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

