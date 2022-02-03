using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace busStop
{
    public partial class Form2 : Form


    {
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=bus.mdb;";
        public OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_auto_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string gosnumber = textBox2.Text;
            string markaAuto = textBox3.Text;
            string modelAuto = textBox4.Text;
            
            int sumday = Convert.ToInt32(textBox5.Text);
            DateTime mdate = this.dateTimePicker1.Value;
            DateTime addd = mdate.AddDays(sumday);
            //label9.Text = addd.ToString();





            //string b = "Mazda";
            string query = $"INSERT INTO db_bus (db_name, db_gosnumber, db_marka, db_model, db_sumdate, db_status, db_date_v, db_date_vv) VALUES ('{name}', '{gosnumber}', '{markaAuto}', '{modelAuto}', '{sumday}', 'Стоит', '{this.dateTimePicker1.Text}', '{addd.ToString()}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();

            //myConnection.Close();


            //this.Close();
       


        }


        private void Form2_Load(object sender, EventArgs e)
        {
           myConnection = new OleDbConnection(connect);
           myConnection.Open();
         
            
        }

        private void button_add_auto_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            Form1 form = this.Owner as Form1;

            form.gridUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
