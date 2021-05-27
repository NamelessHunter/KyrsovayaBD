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
    public partial class ReadersForm : Form
    {
        public ReadersForm()
        {
            InitializeComponent();
        }

        private void читателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);

        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.libKyrsDataSet.Читатели);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            читателиBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            читателиBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            читателиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            читателиBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form sf = new Age1();
            sf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form sf = new Age2();
            sf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form sf = new Age3();
            sf.Show();
        }
    }
}
