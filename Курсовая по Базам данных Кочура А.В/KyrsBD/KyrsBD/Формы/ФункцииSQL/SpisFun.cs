using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrsBD.Формы.ФункцииSQL
{
    public partial class SpisFun : Form
    {
        public SpisFun()
        {
            InitializeComponent();
        }

        private void SpisFun_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Книги_на_списание". При необходимости она может быть перемещена или удалена.
            this.книги_на_списаниеTableAdapter.Fill(this.libKyrsDataSet.Книги_на_списание);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            книги_на_списаниеBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            книги_на_списаниеBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            книги_на_списаниеBindingSource.RemoveCurrent();
        }

        private void книги_на_списаниеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
