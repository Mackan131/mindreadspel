using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spel1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new Form13().ShowDialog();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new Form14().ShowDialog();
        }
    }
}
