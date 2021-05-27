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
    public partial class KatalogForm : Form
    {
        public KatalogForm()
        {
            InitializeComponent();
        }

        private void KatalogForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Каталог". При необходимости она может быть перемещена или удалена.
            this.каталогTableAdapter.Fill(this.libKyrsDataSet.Каталог);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sf = new Fun1();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sf = new Fun2();
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form sf = new Fun3();
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form sf = new Fun4();
            sf.Show();
        }

    }
}
