
namespace busStop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbgosnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbmarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbdatevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbdatevvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbsumdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbsumcashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbbusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busDataSet1 = new busStop.busDataSet1();
            this.click_seach = new System.Windows.Forms.Button();
            this.textBox_gosnumber = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_del_tarif = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button_add_tarif = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.busDataSet = new busStop.busDataSet();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busTableAdapter = new busStop.busDataSetTableAdapters.busTableAdapter();
            this.db_busTableAdapter = new busStop.busDataSet1TableAdapters.db_busTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.click_seach);
            this.tabPage1.Controls.Add(this.textBox_gosnumber);
            this.tabPage1.Controls.Add(this.textBox_fio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1141, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Стоянка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.dbnameDataGridViewTextBoxColumn,
            this.dbgosnumberDataGridViewTextBoxColumn,
            this.dbmarkaDataGridViewTextBoxColumn,
            this.dbmodelDataGridViewTextBoxColumn,
            this.dbdatevDataGridViewTextBoxColumn,
            this.dbdatevvDataGridViewTextBoxColumn,
            this.dbstatusDataGridViewTextBoxColumn,
            this.dbsumdateDataGridViewTextBoxColumn,
            this.dbsumcashDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbbusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1128, 362);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 50;
            // 
            // dbnameDataGridViewTextBoxColumn
            // 
            this.dbnameDataGridViewTextBoxColumn.DataPropertyName = "db_name";
            this.dbnameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.dbnameDataGridViewTextBoxColumn.Name = "dbnameDataGridViewTextBoxColumn";
            this.dbnameDataGridViewTextBoxColumn.Width = 300;
            // 
            // dbgosnumberDataGridViewTextBoxColumn
            // 
            this.dbgosnumberDataGridViewTextBoxColumn.DataPropertyName = "db_gosnumber";
            this.dbgosnumberDataGridViewTextBoxColumn.HeaderText = "Гос номер";
            this.dbgosnumberDataGridViewTextBoxColumn.Name = "dbgosnumberDataGridViewTextBoxColumn";
            // 
            // dbmarkaDataGridViewTextBoxColumn
            // 
            this.dbmarkaDataGridViewTextBoxColumn.DataPropertyName = "db_marka";
            this.dbmarkaDataGridViewTextBoxColumn.HeaderText = "Марка ТС";
            this.dbmarkaDataGridViewTextBoxColumn.Name = "dbmarkaDataGridViewTextBoxColumn";
            // 
            // dbmodelDataGridViewTextBoxColumn
            // 
            this.dbmodelDataGridViewTextBoxColumn.DataPropertyName = "db_model";
            this.dbmodelDataGridViewTextBoxColumn.HeaderText = "Модель ТС";
            this.dbmodelDataGridViewTextBoxColumn.Name = "dbmodelDataGridViewTextBoxColumn";
            // 
            // dbdatevDataGridViewTextBoxColumn
            // 
            this.dbdatevDataGridViewTextBoxColumn.DataPropertyName = "db_date_v";
            this.dbdatevDataGridViewTextBoxColumn.HeaderText = "Дата заезда";
            this.dbdatevDataGridViewTextBoxColumn.Name = "dbdatevDataGridViewTextBoxColumn";
            // 
            // dbdatevvDataGridViewTextBoxColumn
            // 
            this.dbdatevvDataGridViewTextBoxColumn.DataPropertyName = "db_date_vv";
            this.dbdatevvDataGridViewTextBoxColumn.HeaderText = "Дата выезда";
            this.dbdatevvDataGridViewTextBoxColumn.Name = "dbdatevvDataGridViewTextBoxColumn";
            // 
            // dbstatusDataGridViewTextBoxColumn
            // 
            this.dbstatusDataGridViewTextBoxColumn.DataPropertyName = "db_status";
            this.dbstatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.dbstatusDataGridViewTextBoxColumn.Name = "dbstatusDataGridViewTextBoxColumn";
            // 
            // dbsumdateDataGridViewTextBoxColumn
            // 
            this.dbsumdateDataGridViewTextBoxColumn.DataPropertyName = "db_sumdate";
            this.dbsumdateDataGridViewTextBoxColumn.HeaderText = "Сутки";
            this.dbsumdateDataGridViewTextBoxColumn.Name = "dbsumdateDataGridViewTextBoxColumn";
            this.dbsumdateDataGridViewTextBoxColumn.Width = 50;
            // 
            // dbsumcashDataGridViewTextBoxColumn
            // 
            this.dbsumcashDataGridViewTextBoxColumn.DataPropertyName = "db_sumcash";
            this.dbsumcashDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.dbsumcashDataGridViewTextBoxColumn.Name = "dbsumcashDataGridViewTextBoxColumn";
            // 
            // dbbusBindingSource
            // 
            this.dbbusBindingSource.DataMember = "db_bus";
            this.dbbusBindingSource.DataSource = this.busDataSet1;
            // 
            // busDataSet1
            // 
            this.busDataSet1.DataSetName = "busDataSet1";
            this.busDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // click_seach
            // 
            this.click_seach.Location = new System.Drawing.Point(410, 4);
            this.click_seach.Name = "click_seach";
            this.click_seach.Size = new System.Drawing.Size(95, 23);
            this.click_seach.TabIndex = 2;
            this.click_seach.Text = "Поиск";
            this.click_seach.UseVisualStyleBackColor = true;
            // 
            // textBox_gosnumber
            // 
            this.textBox_gosnumber.Location = new System.Drawing.Point(206, 6);
            this.textBox_gosnumber.Name = "textBox_gosnumber";
            this.textBox_gosnumber.Size = new System.Drawing.Size(183, 20);
            this.textBox_gosnumber.TabIndex = 1;
            this.textBox_gosnumber.Text = "Поиск по номеру";
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(6, 6);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(183, 20);
            this.textBox_fio.TabIndex = 0;
            this.textBox_fio.Text = "Поиск по фамилии";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1141, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "+";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1141, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(405, 147);
            this.listBox1.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(53, 38);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(389, 20);
            this.textBox5.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1217, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1167, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1248, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1207, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_del_tarif);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.button_add_tarif);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(1170, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "- Тарифы -";
            // 
            // button_del_tarif
            // 
            this.button_del_tarif.Location = new System.Drawing.Point(16, 133);
            this.button_del_tarif.Name = "button_del_tarif";
            this.button_del_tarif.Size = new System.Drawing.Size(121, 23);
            this.button_del_tarif.TabIndex = 3;
            this.button_del_tarif.Text = "Удалить тариф";
            this.button_del_tarif.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(16, 69);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "Введите новый тариф";
            this.textBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox6_MouseClick);
            // 
            // button_add_tarif
            // 
            this.button_add_tarif.Location = new System.Drawing.Point(16, 104);
            this.button_add_tarif.Name = "button_add_tarif";
            this.button_add_tarif.Size = new System.Drawing.Size(121, 23);
            this.button_add_tarif.TabIndex = 1;
            this.button_add_tarif.Text = "Добавить тариф";
            this.button_add_tarif.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // busDataSet
            // 
            this.busDataSet.DataSetName = "busDataSet";
            this.busDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataMember = "bus";
            this.busBindingSource.DataSource = this.busDataSet;
            // 
            // busTableAdapter
            // 
            this.busTableAdapter.ClearBeforeFill = true;
            // 
            // db_busTableAdapter
            // 
            this.db_busTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "busStop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button click_seach;
        private System.Windows.Forms.TextBox textBox_gosnumber;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_del_tarif;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button_add_tarif;
        private System.Windows.Forms.ComboBox comboBox1;
        private busDataSet busDataSet;
        private System.Windows.Forms.BindingSource busBindingSource;
        private busDataSetTableAdapters.busTableAdapter busTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private busDataSet1 busDataSet1;
        private System.Windows.Forms.BindingSource dbbusBindingSource;
        private busDataSet1TableAdapters.db_busTableAdapter db_busTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbgosnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbmarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbdatevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbdatevvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbsumdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbsumcashDataGridViewTextBoxColumn;
    }
}

