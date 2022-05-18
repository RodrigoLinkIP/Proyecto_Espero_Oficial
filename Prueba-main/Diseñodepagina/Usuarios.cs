using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Diseñodepagina
{
    public class Usuarios
    {
        public static int AgregarUsuarios(string nombre, string apellido, string correo, string encriptada)
        {
            int retorno = 0;
            MySqlCommand comando =  new MySqlCommand(string.Format("Insert into usuarios (Nombre_Usuario,Apellido_Usuario,Correo_Electronico,Password) values('{0}', '{1}', '{2}', '{3}')", nombre, apellido, correo, encriptada), Dato.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            if (retorno != 0)
            {
                MessageBox.Show("Usuario ingresado correctamente");
            }
            return retorno;
        }
        
        public static int Login(string correo, string contra)
        {
            int valor = 0;
            MySqlConnection conexion = Dato.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT id_usuario FROM usuarios WHERE correo_electronico = '" + correo + "' AND password = '" + contra + "' ", conexion);
            valor = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return valor;
        }
    }
}
