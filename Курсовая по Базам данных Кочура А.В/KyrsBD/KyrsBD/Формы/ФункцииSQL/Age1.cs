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
    public partial class Age1 : Form
    {
        public Age1()
        {
            InitializeComponent();
        }

        private void Age1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Возраст_от_14_до_16". При необходимости она может быть перемещена или удалена.
            this.возраст_от_14_до_16TableAdapter.Fill(this.libKyrsDataSet.Возраст_от_14_до_16);

        }
    }
}
