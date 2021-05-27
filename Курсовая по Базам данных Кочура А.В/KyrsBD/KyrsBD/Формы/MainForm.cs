using KyrsBD.Формы;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrsBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Выданные книги
        {
            Form sf = new GivenBookForm();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Жанры
        {
            Form sf = new GenresForm();
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e) // Издательства
        {
            Form sf = new IzdForm();
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e) // Книги
        {
            Form sf = new BooksForm();
            sf.Show();
        }

        private void button5_Click(object sender, EventArgs e) // Читатели
        {
            Form sf = new ReadersForm();
            sf.Show();
        }

        private void button6_Click(object sender, EventArgs e) // Каталог
        {
            Form sf = new KatalogForm();
            sf.Show();
        }

        private void button7_Click(object sender, EventArgs e) // Книги на руках
        {
            Form sf = new BookOnHandForm();
            sf.Show();
        }
    }
}
