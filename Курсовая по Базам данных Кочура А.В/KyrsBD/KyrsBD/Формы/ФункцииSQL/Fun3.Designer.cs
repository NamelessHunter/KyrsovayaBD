namespace KyrsBD.Формы.ФункцииSQL
{
    partial class Fun3
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
            this.книги_по_издательствуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книги_по_издательствуTableAdapter = new KyrsBD.LibKyrsDataSetTableAdapters.Книги_по_издательствуTableAdapter();
            this.tableAdapterManager = new KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.idIToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idIToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.книги_по_издательствуDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги_по_издательствуBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.книги_по_издательствуDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // libKyrsDataSet
            // 
            this.libKyrsDataSet.DataSetName = "LibKyrsDataSet";
            this.libKyrsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книги_по_издательствуBindingSource
            // 
            this.книги_по_издательствуBindingSource.DataMember = "Книги по издательству";
            this.книги_по_издательствуBindingSource.DataSource = this.libKyrsDataSet;
            // 
            // книги_по_издательствуTableAdapter
            // 
            this.книги_по_издательствуTableAdapter.ClearBeforeFill = true;
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
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idIToolStripLabel,
            this.idIToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(982, 27);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // idIToolStripLabel
            // 
            this.idIToolStripLabel.Name = "idIToolStripLabel";
            this.idIToolStripLabel.Size = new System.Drawing.Size(175, 24);
            this.idIToolStripLabel.Text = "Название издательства:";
            // 
            // idIToolStripTextBox
            // 
            this.idIToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idIToolStripTextBox.Name = "idIToolStripTextBox";
            this.idIToolStripTextBox.Size = new System.Drawing.Size(500, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillToolStripButton.Text = "Найти";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // книги_по_издательствуDataGridView
            // 
            this.книги_по_издательствуDataGridView.AutoGenerateColumns = false;
            this.книги_по_издательствуDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.книги_по_издательствуDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.книги_по_издательствуDataGridView.DataSource = this.книги_по_издательствуBindingSource;
            this.книги_по_издательствуDataGridView.Location = new System.Drawing.Point(12, 30);
            this.книги_по_издательствуDataGridView.Name = "книги_по_издательствуDataGridView";
            this.книги_по_издательствуDataGridView.RowHeadersWidth = 51;
            this.книги_по_издательствуDataGridView.RowTemplate.Height = 24;
            this.книги_по_издательствуDataGridView.Size = new System.Drawing.Size(958, 411);
            this.книги_по_издательствуDataGridView.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Возрастная категория";
            this.dataGridViewTextBoxColumn3.HeaderText = "Возрастная категория";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Год издания";
            this.dataGridViewTextBoxColumn4.HeaderText = "Год издания";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Кол-во страниц";
            this.dataGridViewTextBoxColumn5.HeaderText = "Кол-во страниц";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Процент износа";
            this.dataGridViewTextBoxColumn6.HeaderText = "Процент износа";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Наименование жанра";
            this.dataGridViewTextBoxColumn7.HeaderText = "Наименование жанра";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn8.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Наименование издательства";
            this.dataGridViewTextBoxColumn9.HeaderText = "Наименование издательства";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Город";
            this.dataGridViewTextBoxColumn10.HeaderText = "Город";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn11.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // Fun3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.книги_по_издательствуDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fun3";
            this.Text = "Книги по изданию";
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги_по_издательствуBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.книги_по_издательствуDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibKyrsDataSet libKyrsDataSet;
        private System.Windows.Forms.BindingSource книги_по_издательствуBindingSource;
        private LibKyrsDataSetTableAdapters.Книги_по_издательствуTableAdapter книги_по_издательствуTableAdapter;
        private LibKyrsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel idIToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idIToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView книги_по_издательствуDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}