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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            String code1 = code.Text;
          

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `technik` where `code` = @uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = code1;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {

                    var cells = row.ItemArray;
                    Class1.first = Convert.ToString(cells[1]);
                    Class1.second = Convert.ToString(cells[2]);
                    Class1.third = Convert.ToString(cells[3]);
                    Class1.forth = Convert.ToString(cells[4]);
                    Class1.fifth = Convert.ToString(cells[5]);
                    Class1.sixth = Convert.ToString(cells[6]);
                    Class1.seventh = Convert.ToString(cells[7]);
                    Class1.eightth = Convert.ToString(cells[8]);
                    Class1.nineth = Convert.ToString(cells[9]);
                    Class1.tenth = Convert.ToString(cells[10]);



                }

                MessageBox.Show("yes");
               
                this.Hide();
                MainPage form = new MainPage();
                panel1.Visible = true;
                form.Show();
            }
            else
                MessageBox.Show("No");

        }
    }
}


public static class Class1
{
    public static String first, second, third, forth, fifth, sixth, seventh, eightth, nineth, tenth;

}