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
    public partial class GivenBookForm : Form
    {
        public GivenBookForm()
        {
            InitializeComponent();
        }

        private void выданные_книгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выданные_книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);

        }

        private void GivenBookForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Выданные_книги". При необходимости она может быть перемещена или удалена.
            this.выданные_книгиTableAdapter.Fill(this.libKyrsDataSet.Выданные_книги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            выданные_книгиBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            выданные_книгиBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            выданные_книгиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выданные_книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            выданные_книгиBindingSource.RemoveCurrent();
        }
    }
}
