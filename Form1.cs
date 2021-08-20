using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sudoku;

namespace SudokuWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel63_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel83_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel53_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel43_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox79_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            Field field = new Field();
            field.ApplyRandomChanges(40);
            var controls = Block1.Controls.OfType<Control>();

        }
    }
}
