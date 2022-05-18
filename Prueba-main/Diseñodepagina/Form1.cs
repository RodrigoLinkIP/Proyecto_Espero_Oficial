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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button15.Visible = true;
            button11.Visible = true;
            button13.Visible = true;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            button11.Visible = false;
            button13.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 english = new Form6();
            english.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 español = new Form1();
            español.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button14.Visible = true;
            button9.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button12.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            button8.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            button9.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button12.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 paginaprincipal = new Form1();
            paginaprincipal.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 vistaderutas = new Form2();
            vistaderutas.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginES login = new LoginES();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrarse registrarse = new Registrarse();
            registrarse.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 metodopago = new Form5();
            metodopago.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 travelquiz = new Form10();
            travelquiz.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gmail: turismore@example.com\nTelefono: 7894-5612\nInstagram: @TurismoreSV\nFacebook: Turismore_SV");
        }
    }
}
