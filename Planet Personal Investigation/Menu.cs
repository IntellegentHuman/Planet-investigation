using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planet_Personal_Investigation
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Main main = new Main(ReadPathTextBox.Text, WriteDirectoyTextBox.Text, ExcelFileTextBox.Text);
            main.Show();
        }
    }
}
