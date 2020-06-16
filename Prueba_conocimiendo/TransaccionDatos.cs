using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Prueba_conocimiendo
{
    class TransaccionDatos
    {
        public static int Agregar(Transaciones pTransaciones)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into  transacciones(propietario, Cuenta_retirar, Banco_retirar, Mon_retirar, GTM, Saldo_retiro, Cuenta_ingreso, Banco_ingreso, Saldo_ingresar) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                pTransaciones.propietario, pTransaciones.Cuenta_retirar, pTransaciones.Banco_retirar, pTransaciones.Mon_retirar, pTransaciones.GTM, pTransaciones.Saldo_retiro, pTransaciones.Cuenta_ingreso, pTransaciones.Banco_ingreso, pTransaciones.Saldo_ingresar), BDcone.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }
    }
}

