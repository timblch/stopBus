using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStopWP
{
    public partial class FormDB : Form
    {
        bool sidebarExpand;
        public FormDB()
        {
            InitializeComponent();
            panelData.Hide();
            panelStatus.Hide();
        }

        private void siderTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                siderbarContainer.Width -= 10;
                dataGridView1.Width += 10;
                dataGridView1.Location = new Point(81, 65);
                panelData.Hide();
                panelStatus.Hide();
                if (siderbarContainer.Width == siderbarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    siderTimer.Stop();
                }
            
            }
            else
            {
                siderbarContainer.Width += 10;
                dataGridView1.Location = new Point(205, 65);
                dataGridView1.Width -= 10;
                
                panelData.Show();
                panelStatus.Show();
                if (siderbarContainer.Width == siderbarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    siderTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            siderTimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
            if (FormDB.ActiveForm.Size.Width == 1184)
            {
                this.WindowState = FormWindowState.Maximized;
                //siderbarContainer.Height = FormDB.ActiveForm.Size.Height;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
           
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
            
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busstopDataSet.db_bus". При необходимости она может быть перемещена или удалена.
            this.db_busTableAdapter.Fill(this.busstopDataSet.db_bus);

        }
    }
}
