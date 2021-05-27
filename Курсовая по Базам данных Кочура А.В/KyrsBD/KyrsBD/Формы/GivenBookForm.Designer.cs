namespace KyrsBD.Формы
{
    partial class GivenBookForm
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
            System.Windows.Forms.Label код_книгиLabel;
            System.Windows.Forms.Label код_читателяLabel;
            System.Windows.Forms.Label дата_выдачиLabel;
            System.Windows.Forms.Label дата_возвратаLabel;
            System.Windows.Forms.Label отметка_о_возвратеLabel;
            this.libKyrsDataSet = new KyrsBD.LibKyrsDataSet();
            this.выданные_книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выданные_книгиTableAdapter = new KyrsBD.LibKyrsDataSetTableAdapters.Выданные_книгиTableAdapter();
            this.tableAdapterManager = new KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager();
            this.выданные_книгиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.отметка_о_возвратеCheckBox = new System.Windows.Forms.CheckBox();
            this.дата_возвратаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_выдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_читателяTextBox = new System.Windows.Forms.TextBox();
            this.код_книгиTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            код_книгиLabel = new System.Windows.Forms.Label();
            код_читателяLabel = new System.Windows.Forms.Label();
            дата_выдачиLabel = new System.Windows.Forms.Label();
            дата_возвратаLabel = new System.Windows.Forms.Label();
            отметка_о_возвратеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданные_книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданные_книгиDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_книгиLabel
            // 
            код_книгиLabel.AutoSize = true;
            код_книгиLabel.Location = new System.Drawing.Point(318, 36);
            код_книгиLabel.Name = "код_книгиLabel";
            код_книгиLabel.Size = new System.Drawing.Size(77, 17);
            код_книгиLabel.TabIndex = 2;
            код_книгиLabel.Text = "Код книги:";
            // 
            // код_читателяLabel
            // 
            код_читателяLabel.AutoSize = true;
            код_читателяLabel.Location = new System.Drawing.Point(292, 68);
            код_читателяLabel.Name = "код_читателяLabel";
            код_читателяLabel.Size = new System.Drawing.Size(103, 17);
            код_читателяLabel.TabIndex = 4;
            код_читателяLabel.Text = "Код читателя:";
            // 
            // дата_выдачиLabel
            // 
            дата_выдачиLabel.AutoSize = true;
            дата_выдачиLabel.Location = new System.Drawing.Point(518, 37);
            дата_выдачиLabel.Name = "дата_выдачиLabel";
            дата_выдачиLabel.Size = new System.Drawing.Size(99, 17);
            дата_выдачиLabel.TabIndex = 6;
            дата_выдачиLabel.Text = "Дата выдачи:";
            // 
            // дата_возвратаLabel
            // 
            дата_возвратаLabel.AutoSize = true;
            дата_возвратаLabel.Location = new System.Drawing.Point(507, 65);
            дата_возвратаLabel.Name = "дата_возвратаLabel";
            дата_возвратаLabel.Size = new System.Drawing.Size(110, 17);
            дата_возвратаLabel.TabIndex = 8;
            дата_возвратаLabel.Text = "Дата возврата:";
            // 
            // отметка_о_возвратеLabel
            // 
            отметка_о_возвратеLabel.AutoSize = true;
            отметка_о_возвратеLabel.Location = new System.Drawing.Point(250, 100);
            отметка_о_возвратеLabel.Name = "отметка_о_возвратеLabel";
            отметка_о_возвратеLabel.Size = new System.Drawing.Size(145, 17);
            отметка_о_возвратеLabel.TabIndex = 10;
            отметка_о_возвратеLabel.Text = "Отметка о возврате:";
            // 
            // libKyrsDataSet
            // 
            this.libKyrsDataSet.DataSetName = "LibKyrsDataSet";
            this.libKyrsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выданные_книгиBindingSource
            // 
            this.выданные_книгиBindingSource.DataMember = "Выданные книги";
            this.выданные_книгиBindingSource.DataSource = this.libKyrsDataSet;
            // 
            // выданные_книгиTableAdapter
            // 
            this.выданные_книгиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выданные_книгиTableAdapter = this.выданные_книгиTableAdapter;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ИздательстваTableAdapter = null;
            this.tableAdapterManager.КнигиTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            // 
            // выданные_книгиDataGridView
            // 
            this.выданные_книгиDataGridView.AutoGenerateColumns = false;
            this.выданные_книгиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выданные_книгиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.выданные_книгиDataGridView.DataSource = this.выданные_книгиBindingSource;
            this.выданные_книгиDataGridView.Location = new System.Drawing.Point(12, 46);
            this.выданные_книгиDataGridView.Name = "выданные_книгиDataGridView";
            this.выданные_книгиDataGridView.RowHeadersWidth = 51;
            this.выданные_книгиDataGridView.RowTemplate.Height = 24;
            this.выданные_книгиDataGridView.Size = new System.Drawing.Size(958, 292);
            this.выданные_книгиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код выдачи";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код выдачи";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код книги";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код книги";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код читателя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код читателя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата выдачи";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата возврата";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата возврата";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Отметка о возврате";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Отметка о возврате";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица \"Выданные книги\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(отметка_о_возвратеLabel);
            this.groupBox1.Controls.Add(this.отметка_о_возвратеCheckBox);
            this.groupBox1.Controls.Add(дата_возвратаLabel);
            this.groupBox1.Controls.Add(this.дата_возвратаDateTimePicker);
            this.groupBox1.Controls.Add(дата_выдачиLabel);
            this.groupBox1.Controls.Add(this.дата_выдачиDateTimePicker);
            this.groupBox1.Controls.Add(код_читателяLabel);
            this.groupBox1.Controls.Add(this.код_читателяTextBox);
            this.groupBox1.Controls.Add(код_книгиLabel);
            this.groupBox1.Controls.Add(this.код_книгиTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Корректировка списка";
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
            // отметка_о_возвратеCheckBox
            // 
            this.отметка_о_возвратеCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.выданные_книгиBindingSource, "Отметка о возврате", true));
            this.отметка_о_возвратеCheckBox.Location = new System.Drawing.Point(401, 95);
            this.отметка_о_возвратеCheckBox.Name = "отметка_о_возвратеCheckBox";
            this.отметка_о_возвратеCheckBox.Size = new System.Drawing.Size(104, 24);
            this.отметка_о_возвратеCheckBox.TabIndex = 11;
            this.отметка_о_возвратеCheckBox.UseVisualStyleBackColor = true;
            // 
            // дата_возвратаDateTimePicker
            // 
            this.дата_возвратаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выданные_книгиBindingSource, "Дата возврата", true));
            this.дата_возвратаDateTimePicker.Location = new System.Drawing.Point(623, 61);
            this.дата_возвратаDateTimePicker.Name = "дата_возвратаDateTimePicker";
            this.дата_возвратаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_возвратаDateTimePicker.TabIndex = 9;
            // 
            // дата_выдачиDateTimePicker
            // 
            this.дата_выдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выданные_книгиBindingSource, "Дата выдачи", true));
            this.дата_выдачиDateTimePicker.Location = new System.Drawing.Point(623, 33);
            this.дата_выдачиDateTimePicker.Name = "дата_выдачиDateTimePicker";
            this.дата_выдачиDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_выдачиDateTimePicker.TabIndex = 7;
            // 
            // код_читателяTextBox
            // 
            this.код_читателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выданные_книгиBindingSource, "Код читателя", true));
            this.код_читателяTextBox.Location = new System.Drawing.Point(401, 65);
            this.код_читателяTextBox.Name = "код_читателяTextBox";
            this.код_читателяTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_читателяTextBox.TabIndex = 5;
            // 
            // код_книгиTextBox
            // 
            this.код_книгиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выданные_книгиBindingSource, "Код книги", true));
            this.код_книгиTextBox.Location = new System.Drawing.Point(401, 33);
            this.код_книгиTextBox.Name = "код_книгиTextBox";
            this.код_книгиTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_книгиTextBox.TabIndex = 3;
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
            // GivenBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.выданные_книгиDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GivenBookForm";
            this.Text = "Выданные книги";
            this.Load += new System.EventHandler(this.GivenBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданные_книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданные_книгиDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibKyrsDataSet libKyrsDataSet;
        private System.Windows.Forms.BindingSource выданные_книгиBindingSource;
        private LibKyrsDataSetTableAdapters.Выданные_книгиTableAdapter выданные_книгиTableAdapter;
        private LibKyrsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView выданные_книгиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox отметка_о_возвратеCheckBox;
        private System.Windows.Forms.DateTimePicker дата_возвратаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_выдачиDateTimePicker;
        private System.Windows.Forms.TextBox код_читателяTextBox;
        private System.Windows.Forms.TextBox код_книгиTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}