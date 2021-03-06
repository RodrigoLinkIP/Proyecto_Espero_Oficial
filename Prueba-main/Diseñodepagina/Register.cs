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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 homepage = new Form6();
            homepage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, apellido, correo, encriptada;
            if (txtapellido.Text.Trim() != "" && txtnombre.Text.Trim() != "" && txtcorreo.Text.Trim() != "" && txtcontra1.Text == txtcontra2.Text)
            {
                correo = txtcorreo.Text;
                encriptada = Encriptar(txtcontra1.Text);
                nombre = txtnombre.Text;
                apellido = txtapellido.Text;
                Usuarios.AgregarUsuarios(nombre, apellido, correo, encriptada);
            }
            else
            {
                MessageBox.Show("Wrong data, please check");
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

        private void txtcontra1_TextChanged(object sender, EventArgs e)
        {
            txtcontra1.UseSystemPasswordChar = true;
        }

        private void txtcontra2_TextChanged(object sender, EventArgs e)
        {
            txtcontra2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtcontra1.Text;
            if (checkBox1.Checked)
            {
                txtcontra1.UseSystemPasswordChar = false;
                txtcontra1.Text = text;
            }
            else
            {
                txtcontra1.UseSystemPasswordChar = true;
                txtcontra1.Text = text;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtcontra2.Text;
            if (checkBox2.Checked)
            {
                txtcontra2.UseSystemPasswordChar = false;
                txtcontra2.Text = text;
            }
            else
            {
                txtcontra2.UseSystemPasswordChar = true;
                txtcontra2.Text = text;
            }
        }
    }
}
