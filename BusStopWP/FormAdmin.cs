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
    public partial class FormAdmin : Form
    {
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=busstop.mdb;";
        public OleDbConnection myConnection;
        public FormAdmin()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connect);

            //myConnection.Open();
        }

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter db = new OleDbDataAdapter();
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "" && textPassword.Text == "" && textPassword1.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (textPassword.Text == textPassword1.Text)
            {
                myConnection.Open();
                string query = "INSERT INTO db_users (id_user, id_password) VALUES ('" + textUser.Text + "', '" + textPassword.Text + "')";
                cmd = new OleDbCommand(query, myConnection);
                cmd.ExecuteNonQuery();
                myConnection.Close();
                textUser.Text = "";
                textPassword.Text = "";
                textPassword1.Text = "";
                MessageBox.Show("Вы успешно добавили пользователя", "Добавление выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ошибка ввода пароля", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUser.Text = "";
                textPassword.Text = "";
                textPassword1.Text = "";

            }


        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                textPassword.PasswordChar = '\0';
                textPassword1.PasswordChar = '\0';

            }
            else 
            {
                textPassword.PasswordChar = '*';
                textPassword1.PasswordChar = '*';
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textUser.Text = "";
            textPassword.Text = "";
            textPassword1.Text = "";
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
