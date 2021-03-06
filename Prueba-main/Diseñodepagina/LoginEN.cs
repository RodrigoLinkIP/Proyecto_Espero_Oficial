using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Diseñodepagina
{
    public partial class LoginEN : Form
    {
        public LoginEN()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtcontra.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string correo, contra;
            correo = txtcorreo.Text;
            contra = Encriptar(txtcontra.Text);
            int valor = Usuarios.Login(correo, contra);
            if (valor != 0)
            {
                this.Hide();
                Form6 pagprincipal = new Form6();
                pagprincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error / Username and/or password do not exist");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 homepage = new Form6();
            homepage.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtcontra.Text;
            if (checkBox1.Checked)
            {
                txtcontra.UseSystemPasswordChar = false;
                txtcontra.Text = text;
            }
            else
            {
                txtcontra.UseSystemPasswordChar = true;
                txtcontra.Text = text;
            }
        }
        string key = "Nimbus2001";
        public string Encriptar(string texto)
        {
            byte[] keyArray;
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
            tdes.Clear();
            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }
    }
}
