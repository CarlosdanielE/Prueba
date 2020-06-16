using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Prueba_conocimiendo
{
    public class BDcone
    {
        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database = db_prueba; Uid = root; pwd =;");

            conectar.Open();

            return conectar;
        }
    }
}
