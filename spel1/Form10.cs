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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new Form11().ShowDialog();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new Form12().ShowDialog();
        }
    }
}
