namespace KyrsBD.Формы.ФункцииSQL
{
    partial class Fun6
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
            this.читатели_должникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.читатели_должникиTableAdapter = new KyrsBD.LibKyrsDataSetTableAdapters.Читатели_должникиTableAdapter();
            this.tableAdapterManager = new KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager();
            this.читатели_должникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читатели_должникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читатели_должникиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // libKyrsDataSet
            // 
            this.libKyrsDataSet.DataSetName = "LibKyrsDataSet";
            this.libKyrsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // читатели_должникиBindingSource
            // 
            this.читатели_должникиBindingSource.DataMember = "Читатели должники";
            this.читатели_должникиBindingSource.DataSource = this.libKyrsDataSet;
            // 
            // читатели_должникиTableAdapter
            // 
            this.читатели_должникиTableAdapter.ClearBeforeFill = true;
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
            // читатели_должникиDataGridView
            // 
            this.читатели_должникиDataGridView.AutoGenerateColumns = false;
            this.читатели_должникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.читатели_должникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.читатели_должникиDataGridView.DataSource = this.читатели_должникиBindingSource;
            this.читатели_должникиDataGridView.Location = new System.Drawing.Point(12, 12);
            this.читатели_должникиDataGridView.Name = "читатели_должникиDataGridView";
            this.читатели_должникиDataGridView.RowHeadersWidth = 51;
            this.читатели_должникиDataGridView.RowTemplate.Height = 24;
            this.читатели_должникиDataGridView.Size = new System.Drawing.Size(958, 429);
            this.читатели_должникиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Наименование книги";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование книги";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Автор";
            this.dataGridViewTextBoxColumn2.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ФИО взявшего книгу";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО взявшего книгу";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата рождения читателя";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения читателя";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Наименование издательства";
            this.dataGridViewTextBoxColumn5.HeaderText = "Наименование издательства";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Наименование жанра";
            this.dataGridViewTextBoxColumn6.HeaderText = "Наименование жанра";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дата выдачи";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Дата возврата";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата возврата";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Отметка о возврате";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Отметка о возврате";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Возрастная категория";
            this.dataGridViewTextBoxColumn9.HeaderText = "Возрастная категория";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Процент износа";
            this.dataGridViewTextBoxColumn10.HeaderText = "Процент износа";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Кол-во страниц";
            this.dataGridViewTextBoxColumn11.HeaderText = "Кол-во страниц";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // Fun6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.читатели_должникиDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fun6";
            this.Text = "Читатели должники";
            this.Load += new System.EventHandler(this.Fun6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читатели_должникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читатели_должникиDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibKyrsDataSet libKyrsDataSet;
        private System.Windows.Forms.BindingSource читатели_должникиBindingSource;
        private LibKyrsDataSetTableAdapters.Читатели_должникиTableAdapter читатели_должникиTableAdapter;
        private LibKyrsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView читатели_должникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}