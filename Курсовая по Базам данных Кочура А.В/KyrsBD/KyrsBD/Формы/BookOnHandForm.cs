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
    public partial class BookOnHandForm : Form
    {
        public BookOnHandForm()
        {
            InitializeComponent();
        }

        private void BookOnHandForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libKyrsDataSet.Книги_на_руках". При необходимости она может быть перемещена или удалена.
            this.книги_на_рукахTableAdapter.Fill(this.libKyrsDataSet.Книги_на_руках);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sf = new Fun5();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sf = new Fun6();
            sf.Show();
        }
    }
}
