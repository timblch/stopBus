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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busDataSet1.db_bus". При необходимости она может быть перемещена или удалена.
            this.db_busTableAdapter.Fill(this.busDataSet1.db_bus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busDataSet.bus". При необходимости она может быть перемещена или удалена.
            this.busTableAdapter.Fill(this.busDataSet.bus);
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
            //textBox5.Text = command.ExecuteScalar().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT FIO, Adress, Marka, id_num, Date_v, Status FROM bus ORDER BY w_id";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            //listBox1.Items.Clear();

            while (reader.Read())
            {

                //listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " +
                   // reader[4].ToString() + " " + reader[5].ToString() + " ");
                
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Clear();
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox7.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                myConnection.Open();
            }
            catch
            {
                int kod = Convert.ToInt32(textBox9.Text);
                string query = $"UPDATE db_bus SET db_status = 'Продлено' WHERE Код={kod}";

                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Стоянка машины продлена");
                this.db_busTableAdapter.Fill(this.busDataSet1.db_bus);

            }
            
            
            
            

        }

        public void gridUpdate()
        {
            this.db_busTableAdapter.Fill(this.busDataSet1.db_bus);
            MessageBox.Show("Данные загружены");
            this.db_busTableAdapter.Fill(this.busDataSet1.db_bus);


        }
  
        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            textBox9.Clear();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Owner = this;
            form.ShowDialog();
            //myConnection.Close();
           // Form2 form2 = new Form2();
            //Form2.Owner = this;
           // form2.Show();
        }

        private void click_seach_Click(object sender, EventArgs e)
        {
            string kod = textBox_fio.Text;
            string query = $"SELECT * FROM db_bus WHERE db_name LIKE '%{kod}%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.db_busTableAdapter.Fill(this.busDataSet1.db_bus);
        }
    }
}
