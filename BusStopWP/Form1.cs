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
    public partial class Form1 : Form
    {
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=bus.mdb;";
        public OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connect);
        }

        OleDbCommand cmd = new OleDbCommand();
        OleDbCommand cmd2 = new OleDbCommand();
        OleDbDataAdapter db = new OleDbDataAdapter();

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            new FormAdmin().Show();
            this.Hide();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            string query = "SELECT * FROM db_users WHERE id_user = '" + textUser.Text + "' AND id_password = '" + textPassword.Text + "'";
            cmd = new OleDbCommand(query, myConnection);
            cmd2 = new OleDbCommand(query, myConnection);
            OleDbDataReader ole = cmd.ExecuteReader();
            OleDbDataReader ole2 = cmd2.ExecuteReader();
            string masteruser = "admin";

            if (ole.Read() == true & textUser.Text == masteruser)
            {
                new FormAdmin().Show();
                this.Hide();
            }

            else if (ole2.Read() == true)
            {
                new FormDB().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Неправильный пользователь или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}
