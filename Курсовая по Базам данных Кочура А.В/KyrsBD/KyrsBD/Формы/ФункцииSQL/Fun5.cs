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
    public partial class Fun5 : Form
    {
        public Fun5()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.список_книг__взятых_конкретным_читателемTableAdapter.Fill(this.libKyrsDataSet._Список_книг__взятых_конкретным_читателем, nameReadToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
