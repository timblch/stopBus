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
            
            
            //string b = "Mazda";
            string query = $"INSERT INTO db_bus (db_name, db_gosnumber, db_marka, db_model, db_sumdate, db_status) VALUES ('{name}', '{gosnumber}', '{markaAuto}', '{modelAuto}', '{sumday}', 'Стоит')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();

            myConnection.Close();

            Form1 od = new Form1();
            od.myConnect();
            this.Close();



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connect);
            myConnection.Open();
        }
    }
}
