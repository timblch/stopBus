using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busStop


{
    public partial class Form1 : Form
     
    {
        
        
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=bus.mdb;";
        public OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connect);
            myConnection.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT FIO FROM bus WHERE w_id = 1";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            textBox5.Text = command.ExecuteScalar().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT FIO, Adress, Marka, id_num, Date_v, Status FROM bus ORDER BY w_id";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();

            while (reader.Read())
            {

                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " +
                    reader[4].ToString() + " " + reader[5].ToString() + " ");
                
            }

            reader.Close();

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string b = "Mazda";
            string query = $"INSERT INTO bus (FIO, Adress, Marka, id_num, Date_v, Status) VALUES ('Миханчев', 'Стрит5', '{b}', 'Ok', '01.02.2022 00:00:00', 'Ok')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "UPDATE bus SET FIO = 'Сидоров' WHERE w_id=1";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM bus WHERE w_id < 6";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }
    }
}
