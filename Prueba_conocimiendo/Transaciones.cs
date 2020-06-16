using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_conocimiendo
{
    class Transaciones
    {
        public int IdTransaccion { get; set; }
        public string propietario { get; set; }
        public string Cuenta_retirar { get; set; }
        public string Banco_retirar { get; set; }
        public int Mon_retirar { get; set; }
        public int GTM { get; set; }
        public int Saldo_retiro { get; set; }
        public string Cuenta_ingreso { get; set; }
        public string Banco_ingreso { get; set; }
        public int Saldo_ingresar { get; set; }


        public Transaciones() { }

        public Transaciones(int pIdTransaccion, string ppropietario, 
            string pCuenta_retirar, string pBanco_retirar, int pMon_retirar, 
            int pGTM, int pSaldo_retiro, string pCuenta_ingreso, string pBanco_ingreso,
            int pSaldo_ingresar)

        {

            this.IdTransaccion= pIdTransaccion;
            this.propietario = ppropietario;
            this.Cuenta_retirar = pCuenta_retirar;
            this.Banco_retirar = pBanco_retirar;
            this.Mon_retirar = pMon_retirar;
            this.GTM = pGTM;
            this.Saldo_retiro = pSaldo_retiro;
            this.Cuenta_ingreso = pCuenta_ingreso;
            this.Banco_ingreso = pBanco_ingreso;
            this.Saldo_ingresar = pSaldo_ingresar;

    }
    }
}
