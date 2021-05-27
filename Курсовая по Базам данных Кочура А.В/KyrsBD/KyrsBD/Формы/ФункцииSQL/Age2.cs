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
    public partial class Age2 : Form
    {
        public Age2()
        {
            InitializeComponent();
        }

        private void Age2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Возраст_от_16_до_18". При необходимости она может быть перемещена или удалена.
            this.возраст_от_16_до_18TableAdapter.Fill(this.libKyrsDataSet.Возраст_от_16_до_18);

        }
    }
}
