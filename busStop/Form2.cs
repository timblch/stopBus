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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_add_auto_Click(object sender, EventArgs e)
        {

        }
    }
}
