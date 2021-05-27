namespace KyrsBD.Формы
{
    partial class BooksForm
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
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label авторLabel;
            System.Windows.Forms.Label код_жанраLabel;
            System.Windows.Forms.Label код_издательстваLabel;
            System.Windows.Forms.Label возрастная_категорияLabel;
            System.Windows.Forms.Label год_изданияLabel;
            System.Windows.Forms.Label кол_во_страницLabel;
            System.Windows.Forms.Label процент_износаLabel;
            this.libKyrsDataSet = new KyrsBD.LibKyrsDataSet();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new KyrsBD.LibKyrsDataSetTableAdapters.КнигиTableAdapter();
            this.tableAdapterManager = new KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager();
            this.книгиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.процент_износаTextBox = new System.Windows.Forms.TextBox();
            this.кол_во_страницTextBox = new System.Windows.Forms.TextBox();
            this.год_изданияTextBox = new System.Windows.Forms.TextBox();
            this.возрастная_категорияTextBox = new System.Windows.Forms.TextBox();
            this.код_издательстваTextBox = new System.Windows.Forms.TextBox();
            this.код_жанраTextBox = new System.Windows.Forms.TextBox();
            this.авторTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            наименованиеLabel = new System.Windows.Forms.Label();
            авторLabel = new System.Windows.Forms.Label();
            код_жанраLabel = new System.Windows.Forms.Label();
            код_издательстваLabel = new System.Windows.Forms.Label();
            возрастная_категорияLabel = new System.Windows.Forms.Label();
            год_изданияLabel = new System.Windows.Forms.Label();
            кол_во_страницLabel = new System.Windows.Forms.Label();
            процент_износаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(282, 18);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(110, 17);
            наименованиеLabel.TabIndex = 14;
            наименованиеLabel.Text = "Наименование:";
            // 
            // авторLabel
            // 
            авторLabel.AutoSize = true;
            авторLabel.Location = new System.Drawing.Point(341, 48);
            авторLabel.Name = "авторLabel";
            авторLabel.Size = new System.Drawing.Size(51, 17);
            авторLabel.TabIndex = 15;
            авторLabel.Text = "Автор:";
            // 
            // код_жанраLabel
            // 
            код_жанраLabel.AutoSize = true;
            код_жанраLabel.Location = new System.Drawing.Point(653, 18);
            код_жанраLabel.Name = "код_жанраLabel";
            код_жанраLabel.Size = new System.Drawing.Size(82, 17);
            код_жанраLabel.TabIndex = 16;
            код_жанраLabel.Text = "Код жанра:";
            // 
            // код_издательстваLabel
            // 
            код_издательстваLabel.AutoSize = true;
            код_издательстваLabel.Location = new System.Drawing.Point(653, 45);
            код_издательстваLabel.Name = "код_издательстваLabel";
            код_издательстваLabel.Size = new System.Drawing.Size(131, 17);
            код_издательстваLabel.TabIndex = 17;
            код_издательстваLabel.Text = "Код издательства:";
            // 
            // возрастная_категорияLabel
            // 
            возрастная_категорияLabel.AutoSize = true;
            возрастная_категорияLabel.Location = new System.Drawing.Point(310, 85);
            возрастная_категорияLabel.Name = "возрастная_категорияLabel";
            возрастная_категорияLabel.Size = new System.Drawing.Size(161, 17);
            возрастная_категорияLabel.TabIndex = 18;
            возрастная_категорияLabel.Text = "Возрастная категория:";
            // 
            // год_изданияLabel
            // 
            год_изданияLabel.AutoSize = true;
            год_изданияLabel.Location = new System.Drawing.Point(583, 85);
            год_изданияLabel.Name = "год_изданияLabel";
            год_изданияLabel.Size = new System.Drawing.Size(95, 17);
            год_изданияLabel.TabIndex = 19;
            год_изданияLabel.Text = "Год издания:";
            // 
            // кол_во_страницLabel
            // 
            кол_во_страницLabel.AutoSize = true;
            кол_во_страницLabel.Location = new System.Drawing.Point(356, 114);
            кол_во_страницLabel.Name = "кол_во_страницLabel";
            кол_во_страницLabel.Size = new System.Drawing.Size(115, 17);
            кол_во_страницLabel.TabIndex = 20;
            кол_во_страницLabel.Text = "Кол-во страниц:";
            // 
            // процент_износаLabel
            // 
            процент_износаLabel.AutoSize = true;
            процент_износаLabel.Location = new System.Drawing.Point(583, 114);
            процент_износаLabel.Name = "процент_износаLabel";
            процент_износаLabel.Size = new System.Drawing.Size(119, 17);
            процент_износаLabel.TabIndex = 21;
            процент_износаLabel.Text = "Процент износа:";
            // 
            // libKyrsDataSet
            // 
            this.libKyrsDataSet.DataSetName = "LibKyrsDataSet";
            this.libKyrsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.libKyrsDataSet;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выданные_книгиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ИздательстваTableAdapter = null;
            this.tableAdapterManager.КнигиTableAdapter = this.книгиTableAdapter;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            // 
            // книгиDataGridView
            // 
            this.книгиDataGridView.AutoGenerateColumns = false;
            this.книгиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.книгиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.книгиDataGridView.DataSource = this.книгиBindingSource;
            this.книгиDataGridView.Location = new System.Drawing.Point(12, 46);
            this.книгиDataGridView.Name = "книгиDataGridView";
            this.книгиDataGridView.RowHeadersWidth = 51;
            this.книгиDataGridView.RowTemplate.Height = 24;
            this.книгиDataGridView.Size = new System.Drawing.Size(958, 280);
            this.книгиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код книги";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код книги";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Автор";
            this.dataGridViewTextBoxColumn3.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код жанра";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код жанра";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Возрастная категория";
            this.dataGridViewTextBoxColumn5.HeaderText = "Возрастная категория";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код издательства";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код издательства";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Год издания";
            this.dataGridViewTextBoxColumn7.HeaderText = "Год издания";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Кол-во страниц";
            this.dataGridViewTextBoxColumn8.HeaderText = "Кол-во страниц";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Процент износа";
            this.dataGridViewTextBoxColumn9.HeaderText = "Процент износа";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица \"Книги\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(процент_износаLabel);
            this.groupBox1.Controls.Add(this.процент_износаTextBox);
            this.groupBox1.Controls.Add(кол_во_страницLabel);
            this.groupBox1.Controls.Add(this.кол_во_страницTextBox);
            this.groupBox1.Controls.Add(год_изданияLabel);
            this.groupBox1.Controls.Add(this.год_изданияTextBox);
            this.groupBox1.Controls.Add(возрастная_категорияLabel);
            this.groupBox1.Controls.Add(this.возрастная_категорияTextBox);
            this.groupBox1.Controls.Add(код_издательстваLabel);
            this.groupBox1.Controls.Add(this.код_издательстваTextBox);
            this.groupBox1.Controls.Add(код_жанраLabel);
            this.groupBox1.Controls.Add(this.код_жанраTextBox);
            this.groupBox1.Controls.Add(авторLabel);
            this.groupBox1.Controls.Add(this.авторTextBox);
            this.groupBox1.Controls.Add(наименованиеLabel);
            this.groupBox1.Controls.Add(this.наименованиеTextBox);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 225);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Корректировка списка";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(398, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(304, 30);
            this.button6.TabIndex = 23;
            this.button6.Text = "Книги на списание";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // процент_износаTextBox
            // 
            this.процент_износаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Процент износа", true));
            this.процент_износаTextBox.Location = new System.Drawing.Point(708, 111);
            this.процент_износаTextBox.Name = "процент_износаTextBox";
            this.процент_износаTextBox.Size = new System.Drawing.Size(100, 22);
            this.процент_износаTextBox.TabIndex = 22;
            // 
            // кол_во_страницTextBox
            // 
            this.кол_во_страницTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Кол-во страниц", true));
            this.кол_во_страницTextBox.Location = new System.Drawing.Point(477, 111);
            this.кол_во_страницTextBox.Name = "кол_во_страницTextBox";
            this.кол_во_страницTextBox.Size = new System.Drawing.Size(100, 22);
            this.кол_во_страницTextBox.TabIndex = 21;
            // 
            // год_изданияTextBox
            // 
            this.год_изданияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Год издания", true));
            this.год_изданияTextBox.Location = new System.Drawing.Point(684, 82);
            this.год_изданияTextBox.Name = "год_изданияTextBox";
            this.год_изданияTextBox.Size = new System.Drawing.Size(100, 22);
            this.год_изданияTextBox.TabIndex = 20;
            // 
            // возрастная_категорияTextBox
            // 
            this.возрастная_категорияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Возрастная категория", true));
            this.возрастная_категорияTextBox.Location = new System.Drawing.Point(477, 82);
            this.возрастная_категорияTextBox.Name = "возрастная_категорияTextBox";
            this.возрастная_категорияTextBox.Size = new System.Drawing.Size(100, 22);
            this.возрастная_категорияTextBox.TabIndex = 19;
            // 
            // код_издательстваTextBox
            // 
            this.код_издательстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Код издательства", true));
            this.код_издательстваTextBox.Location = new System.Drawing.Point(790, 42);
            this.код_издательстваTextBox.Name = "код_издательстваTextBox";
            this.код_издательстваTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_издательстваTextBox.TabIndex = 18;
            // 
            // код_жанраTextBox
            // 
            this.код_жанраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Код жанра", true));
            this.код_жанраTextBox.Location = new System.Drawing.Point(741, 15);
            this.код_жанраTextBox.Name = "код_жанраTextBox";
            this.код_жанраTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_жанраTextBox.TabIndex = 17;
            // 
            // авторTextBox
            // 
            this.авторTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Автор", true));
            this.авторTextBox.Location = new System.Drawing.Point(398, 45);
            this.авторTextBox.Name = "авторTextBox";
            this.авторTextBox.Size = new System.Drawing.Size(242, 22);
            this.авторTextBox.TabIndex = 16;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(398, 15);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(242, 22);
            this.наименованиеTextBox.TabIndex = 15;
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
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.книгиDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BooksForm";
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibKyrsDataSet libKyrsDataSet;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private LibKyrsDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private LibKyrsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView книгиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox процент_износаTextBox;
        private System.Windows.Forms.TextBox кол_во_страницTextBox;
        private System.Windows.Forms.TextBox год_изданияTextBox;
        private System.Windows.Forms.TextBox возрастная_категорияTextBox;
        private System.Windows.Forms.TextBox код_издательстваTextBox;
        private System.Windows.Forms.TextBox код_жанраTextBox;
        private System.Windows.Forms.TextBox авторTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.Button button6;
    }
}