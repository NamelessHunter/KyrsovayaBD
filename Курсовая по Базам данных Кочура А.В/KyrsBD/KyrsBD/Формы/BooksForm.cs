using KyrsBD.Формы.ФункцииSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrsBD.Формы
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void книгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);

        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.libKyrsDataSet.Книги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            книгиBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            книгиBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            книгиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            книгиBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form sf = new SpisFun();
            sf.Show();
        }
    }
}
