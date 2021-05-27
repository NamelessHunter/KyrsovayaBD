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
    public partial class IzdForm : Form
    {
        public IzdForm()
        {
            InitializeComponent();
        }

        private void издательстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.издательстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);

        }

        private void IzdForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Издательства". При необходимости она может быть перемещена или удалена.
            this.издательстваTableAdapter.Fill(this.libKyrsDataSet.Издательства);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            издательстваBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            издательстваBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            издательстваBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.издательстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libKyrsDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            издательстваBindingSource.RemoveCurrent();
        }
    }
}
