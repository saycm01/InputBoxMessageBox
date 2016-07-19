using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClickHere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Input1.Text);
        }
    }
}
