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
    public partial class Fun4 : Form
    {
        public Fun4()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.книги_после_заданного_годаTableAdapter.Fill(this.libKyrsDataSet.Книги_после_заданного_года, new System.Nullable<int>(((int)(System.Convert.ChangeType(sYearToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
