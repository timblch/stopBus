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

namespace BusStopWP
{
    public partial class FormAdd : Form
    {
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=busstop.mdb;";
        public OleDbConnection myConnection;
        public FormAdd()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connect);
            myConnection.Open();
        }

        private void button_add_auto_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string gosnumber = textBox2.Text;
            string markaAuto = textBox3.Text;
            string modelAuto = textBox4.Text;
            string adress = textBox6.Text;
            string mesto = textBox7.Text;

            // Добавление к дате количества суток
            int sumday = Convert.ToInt32(textBox5.Text);
            DateTime mdate = this.dateTimePicker1.Value;
            DateTime addd = mdate.AddDays(sumday);
            //label9.Text = addd.ToString();





            //string b = "Mazda";
            string query = $"INSERT INTO db_bus (db_name, db_gosnumber, db_marka, db_model, db_sumdate, db_status, db_date_v, db_date_vv, db_adress, db_mesto) VALUES ('{name}', '{gosnumber}', '{markaAuto}', '{modelAuto}', '{sumday}', 'Стоит', '{this.dateTimePicker1.Text}', '{addd.ToString()}', '{adress}', '{mesto}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button_add_auto_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            FormDB form = this.Owner as FormDB;

            form.gridUpdate();
        }
    }
}
