namespace KyrsBD.Формы
{
    partial class ReadersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label полLabel1;
            this.label1 = new System.Windows.Forms.Label();
            this.читателиDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.читателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libKyrsDataSet = new KyrsBD.LibKyrsDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.читателиTableAdapter = new KyrsBD.LibKyrsDataSetTableAdapters.ЧитателиTableAdapter();
            this.tableAdapterManager = new KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager();
            фИОLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            полLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.читателиDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(292, 18);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(46, 17);
            фИОLabel.TabIndex = 14;
            фИОLabel.Text = "ФИО:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(292, 45);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(115, 17);
            дата_рожденияLabel.TabIndex = 15;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(286, 72);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(52, 17);
            адресLabel.TabIndex = 17;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(281, 100);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 18;
            телефонLabel.Text = "Телефон:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(281, 131);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(148, 17);
            паспортные_данныеLabel.TabIndex = 19;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // полLabel1
            // 
            полLabel1.AutoSize = true;
            полLabel1.Location = new System.Drawing.Point(646, 18);
            полLabel1.Name = "полLabel1";
            полLabel1.Size = new System.Drawing.Size(38, 17);
            полLabel1.TabIndex = 20;
            полLabel1.Text = "Пол:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица \"Читатели\"";
            // 
            // читателиDataGridView
            // 
            this.читателиDataGridView.AutoGenerateColumns = false;
            this.читателиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.читателиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.читателиDataGridView.DataSource = this.читателиBindingSource;
            this.читателиDataGridView.Location = new System.Drawing.Point(12, 46);
            this.читателиDataGridView.Name = "читателиDataGridView";
            this.читателиDataGridView.RowHeadersWidth = 51;
            this.читателиDataGridView.RowTemplate.Height = 24;
            this.читателиDataGridView.Size = new System.Drawing.Size(958, 220);
            this.читателиDataGridView.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(полLabel1);
            this.groupBox1.Controls.Add(this.полComboBox);
            this.groupBox1.Controls.Add(паспортные_данныеLabel);
            this.groupBox1.Controls.Add(this.паспортные_данныеTextBox);
            this.groupBox1.Controls.Add(телефонLabel);
            this.groupBox1.Controls.Add(this.телефонTextBox);
            this.groupBox1.Controls.Add(адресLabel);
            this.groupBox1.Controls.Add(this.адресTextBox);
            this.groupBox1.Controls.Add(дата_рожденияLabel);
            this.groupBox1.Controls.Add(this.дата_рожденияDateTimePicker);
            this.groupBox1.Controls.Add(фИОLabel);
            this.groupBox1.Controls.Add(this.фИОTextBox);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 221);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Корректировка списка";
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читателиBindingSource, "Пол", true));
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.полComboBox.Location = new System.Drawing.Point(690, 15);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(121, 24);
            this.полComboBox.TabIndex = 21;
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читателиBindingSource, "Паспортные данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(435, 128);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(203, 22);
            this.паспортные_данныеTextBox.TabIndex = 20;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читателиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(359, 97);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(254, 22);
            this.телефонTextBox.TabIndex = 19;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читателиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(344, 69);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 22);
            this.адресTextBox.TabIndex = 18;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.читателиBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(413, 41);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_рожденияDateTimePicker.TabIndex = 16;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читателиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(344, 15);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(283, 22);
            this.фИОTextBox.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(238, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 14;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(112, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 30);
            this.button4.TabIndex = 13;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(6, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(137, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "------>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(6, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "<------";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(372, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 40);
            this.button6.TabIndex = 22;
            this.button6.Text = "Зал от 14 до 16";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(538, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 40);
            this.button7.TabIndex = 23;
            this.button7.Text = "Зал от 16 до 18";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(704, 171);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 40);
            this.button8.TabIndex = 24;
            this.button8.Text = "Зал больше 18";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // читателиBindingSource
            // 
            this.читателиBindingSource.DataMember = "Читатели";
            this.читателиBindingSource.DataSource = this.libKyrsDataSet;
            // 
            // libKyrsDataSet
            // 
            this.libKyrsDataSet.DataSetName = "LibKyrsDataSet";
            this.libKyrsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код читателя";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код читателя";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn5.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Паспортные данные";
            this.dataGridViewTextBoxColumn7.HeaderText = "Паспортные данные";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // читателиTableAdapter
            // 
            this.читателиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выданные_книгиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ИздательстваTableAdapter = null;
            this.tableAdapterManager.КнигиTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = this.читателиTableAdapter;
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.читателиDataGridView);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReadersForm";
            this.Text = "Читатели";
            this.Load += new System.EventHandler(this.ReadersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.читателиDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private LibKyrsDataSet libKyrsDataSet;
        private System.Windows.Forms.BindingSource читателиBindingSource;
        private LibKyrsDataSetTableAdapters.ЧитателиTableAdapter читателиTableAdapter;
        private LibKyrsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView читателиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}