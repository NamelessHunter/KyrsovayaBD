namespace KyrsBD.Формы
{
    partial class GenresForm
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
            System.Windows.Forms.Label описаниеLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.libKyrsDataSet = new KyrsBD.LibKyrsDataSet();
            this.жанрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.жанрыTableAdapter = new KyrsBD.LibKyrsDataSetTableAdapters.ЖанрыTableAdapter();
            this.tableAdapterManager = new KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager();
            this.жанрыDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            наименованиеLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(описаниеLabel);
            this.groupBox1.Controls.Add(this.описаниеTextBox);
            this.groupBox1.Controls.Add(наименованиеLabel);
            this.groupBox1.Controls.Add(this.наименованиеTextBox);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 221);
            this.groupBox1.TabIndex = 4;
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
            // libKyrsDataSet
            // 
            this.libKyrsDataSet.DataSetName = "LibKyrsDataSet";
            this.libKyrsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // жанрыBindingSource
            // 
            this.жанрыBindingSource.DataMember = "Жанры";
            this.жанрыBindingSource.DataSource = this.libKyrsDataSet;
            // 
            // жанрыTableAdapter
            // 
            this.жанрыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KyrsBD.LibKyrsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выданные_книгиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = this.жанрыTableAdapter;
            this.tableAdapterManager.ИздательстваTableAdapter = null;
            this.tableAdapterManager.КнигиTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            // 
            // жанрыDataGridView
            // 
            this.жанрыDataGridView.AutoGenerateColumns = false;
            this.жанрыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.жанрыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.жанрыDataGridView.DataSource = this.жанрыBindingSource;
            this.жанрыDataGridView.Location = new System.Drawing.Point(12, 46);
            this.жанрыDataGridView.Name = "жанрыDataGridView";
            this.жанрыDataGridView.RowHeadersWidth = 51;
            this.жанрыDataGridView.RowTemplate.Height = 24;
            this.жанрыDataGridView.Size = new System.Drawing.Size(966, 280);
            this.жанрыDataGridView.TabIndex = 5;
            this.жанрыDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.жанрыDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Таблица \"Жанры\"";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(297, 45);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(110, 17);
            наименованиеLabel.TabIndex = 14;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.жанрыBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(413, 42);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(300, 22);
            this.наименованиеTextBox.TabIndex = 15;
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(329, 81);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(78, 17);
            описаниеLabel.TabIndex = 15;
            описаниеLabel.Text = "Описание:";
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.жанрыBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(413, 78);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(539, 22);
            this.описаниеTextBox.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код жанра";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код жанра";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // GenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.жанрыDataGridView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenresForm";
            this.Text = "Жанры";
            this.Load += new System.EventHandler(this.GenresForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libKyrsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LibKyrsDataSet libKyrsDataSet;
        private System.Windows.Forms.BindingSource жанрыBindingSource;
        private LibKyrsDataSetTableAdapters.ЖанрыTableAdapter жанрыTableAdapter;
        private LibKyrsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView жанрыDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}