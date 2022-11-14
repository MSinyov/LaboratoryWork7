using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush brush = Brushes.Lime;
            Graphics gr = this.CreateGraphics();
            gr.FillPie(brush, 20, 20, 200, 200, 200, 200);
            brush = Brushes.Fuchsia;
            gr.FillPie(brush, 40, 40, 80, 80, 80, 80);
            gr.Dispose();
        }
    }
}
