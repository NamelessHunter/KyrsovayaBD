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
    public partial class Age3 : Form
    {
        public Age3()
        {
            InitializeComponent();
        }

        private void Age3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.возраст_больше_18". При необходимости она может быть перемещена или удалена.
            this.возраст_больше_18TableAdapter.Fill(this.libKyrsDataSet.возраст_больше_18);

        }
    }
}
