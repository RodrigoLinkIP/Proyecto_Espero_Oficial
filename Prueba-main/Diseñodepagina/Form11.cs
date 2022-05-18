using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseñodepagina
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Hide();
            label8.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 travelquiz = new Form10();
            travelquiz.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Show();
            label8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Show();
            label8.Show();
        }
    }
}
