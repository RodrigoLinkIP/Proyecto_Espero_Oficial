using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Diseñodepagina
{
    public class Dato
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database = ptc_login_agregar; Uid = root; ");
            conectar.Open();
            return conectar;
        }
    }
}
