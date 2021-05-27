namespace KyrsBD.Формы.ФункцииSQL
{
    partial class SpisFun
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
            this.libKyrsDataSet = new KyrsBD.LibKyrsDataSet();
            this.книги_на_списаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книги_на_списаниеTableAdapter = new KyrsBD.LibKyrsDataSetTableAdapters.Книги_на_списаниеTableAdapter();
            this.tableAdapterManager = new KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager();
            this.книги_на_списаниеDataGridView = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.кодКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЖанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастнаяКатегорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодИздательстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годИзданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоСтраницDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процентИзносаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги_на_списаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги_на_списаниеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // libKyrsDataSet
            // 
            this.libKyrsDataSet.DataSetName = "LibKyrsDataSet";
            this.libKyrsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книги_на_списаниеBindingSource
            // 
            this.книги_на_списаниеBindingSource.DataMember = "Книги на списание";
            this.книги_на_списаниеBindingSource.DataSource = this.libKyrsDataSet;
            // 
            // книги_на_списаниеTableAdapter
            // 
            this.книги_на_списаниеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выданные_книгиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ИздательстваTableAdapter = null;
            this.tableAdapterManager.КнигиTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            // 
            // книги_на_списаниеDataGridView
            // 
            this.книги_на_списаниеDataGridView.AutoGenerateColumns = false;
            this.книги_на_списаниеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.книги_на_списаниеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКнигиDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.кодЖанраDataGridViewTextBoxColumn,
            this.возрастнаяКатегорияDataGridViewTextBoxColumn,
            this.кодИздательстваDataGridViewTextBoxColumn,
            this.годИзданияDataGridViewTextBoxColumn,
            this.колвоСтраницDataGridViewTextBoxColumn,
            this.процентИзносаDataGridViewTextBoxColumn});
            this.книги_на_списаниеDataGridView.DataSource = this.книги_на_списаниеBindingSource;
            this.книги_на_списаниеDataGridView.Location = new System.Drawing.Point(12, 12);
            this.книги_на_списаниеDataGridView.Name = "книги_на_списаниеDataGridView";
            this.книги_на_списаниеDataGridView.RowHeadersWidth = 51;
            this.книги_на_списаниеDataGridView.RowTemplate.Height = 24;
            this.книги_на_списаниеDataGridView.Size = new System.Drawing.Size(958, 456);
            this.книги_на_списаниеDataGridView.TabIndex = 1;
            this.книги_на_списаниеDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.книги_на_списаниеDataGridView_CellContentClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(274, 493);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 40);
            this.button5.TabIndex = 15;
            this.button5.Text = "Списать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(143, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "------>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(12, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "<------";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // кодКнигиDataGridViewTextBoxColumn
            // 
            this.кодКнигиDataGridViewTextBoxColumn.DataPropertyName = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn.HeaderText = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодКнигиDataGridViewTextBoxColumn.Name = "кодКнигиDataGridViewTextBoxColumn";
            this.кодКнигиDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодКнигиDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            this.авторDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодЖанраDataGridViewTextBoxColumn
            // 
            this.кодЖанраDataGridViewTextBoxColumn.DataPropertyName = "Код жанра";
            this.кодЖанраDataGridViewTextBoxColumn.HeaderText = "Код жанра";
            this.кодЖанраDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодЖанраDataGridViewTextBoxColumn.Name = "кодЖанраDataGridViewTextBoxColumn";
            this.кодЖанраDataGridViewTextBoxColumn.Width = 125;
            // 
            // возрастнаяКатегорияDataGridViewTextBoxColumn
            // 
            this.возрастнаяКатегорияDataGridViewTextBoxColumn.DataPropertyName = "Возрастная категория";
            this.возрастнаяКатегорияDataGridViewTextBoxColumn.HeaderText = "Возрастная категория";
            this.возрастнаяКатегорияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.возрастнаяКатегорияDataGridViewTextBoxColumn.Name = "возрастнаяКатегорияDataGridViewTextBoxColumn";
            this.возрастнаяКатегорияDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодИздательстваDataGridViewTextBoxColumn
            // 
            this.кодИздательстваDataGridViewTextBoxColumn.DataPropertyName = "Код издательства";
            this.кодИздательстваDataGridViewTextBoxColumn.HeaderText = "Код издательства";
            this.кодИздательстваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодИздательстваDataGridViewTextBoxColumn.Name = "кодИздательстваDataGridViewTextBoxColumn";
            this.кодИздательстваDataGridViewTextBoxColumn.Width = 125;
            // 
            // годИзданияDataGridViewTextBoxColumn
            // 
            this.годИзданияDataGridViewTextBoxColumn.DataPropertyName = "Год издания";
            this.годИзданияDataGridViewTextBoxColumn.HeaderText = "Год издания";
            this.годИзданияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.годИзданияDataGridViewTextBoxColumn.Name = "годИзданияDataGridViewTextBoxColumn";
            this.годИзданияDataGridViewTextBoxColumn.Width = 125;
            // 
            // колвоСтраницDataGridViewTextBoxColumn
            // 
            this.колвоСтраницDataGridViewTextBoxColumn.DataPropertyName = "Кол-во страниц";
            this.колвоСтраницDataGridViewTextBoxColumn.HeaderText = "Кол-во страниц";
            this.колвоСтраницDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колвоСтраницDataGridViewTextBoxColumn.Name = "колвоСтраницDataGridViewTextBoxColumn";
            this.колвоСтраницDataGridViewTextBoxColumn.Width = 125;
            // 
            // процентИзносаDataGridViewTextBoxColumn
            // 
            this.процентИзносаDataGridViewTextBoxColumn.DataPropertyName = "Процент износа";
            this.процентИзносаDataGridViewTextBoxColumn.HeaderText = "Процент износа";
            this.процентИзносаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.процентИзносаDataGridViewTextBoxColumn.Name = "процентИзносаDataGridViewTextBoxColumn";
            this.процентИзносаDataGridViewTextBoxColumn.Width = 125;
            // 
            // SpisFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.книги_на_списаниеDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpisFun";
            this.Text = "Книги на списание";
            this.Load += new System.EventHandler(this.SpisFun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги_на_списаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги_на_списаниеDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibKyrsDataSet libKyrsDataSet;
        private System.Windows.Forms.BindingSource книги_на_списаниеBindingSource;
        private LibKyrsDataSetTableAdapters.Книги_на_списаниеTableAdapter книги_на_списаниеTableAdapter;
        private LibKyrsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView книги_на_списаниеDataGridView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЖанраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастнаяКатегорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодИздательстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годИзданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоСтраницDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процентИзносаDataGridViewTextBoxColumn;
    }
}