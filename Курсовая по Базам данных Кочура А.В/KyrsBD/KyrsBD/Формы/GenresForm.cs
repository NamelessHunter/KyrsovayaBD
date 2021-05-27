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
    public partial class GenresForm : Form
    {
        public GenresForm()
        {
            InitializeComponent();
        }

        private void жанрыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.жанрыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);

        }

        private void GenresForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this.libKyrsDataSet.Жанры);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            жанрыBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            жанрыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            жанрыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.жанрыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            жанрыBindingSource.RemoveCurrent();
        }

        private void жанрыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
