using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_conocimiendo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDcone.ObtenerConexion();
            MessageBox.Show("conectado", "Estado conexion BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnTran_Click(object sender, EventArgs e)
        {
            Transaciones pTransaciones = new Transaciones();

            int saldoCuentaA = 110000000;
            int saldoCuentaB = 65000000;
            int saldoCuentaC = 500000;
            int saldoactual = 0;
            int saldofinal = 0;
            int saldofB = 0;
            int saldofC = 0;
            int G = 0;
            pTransaciones.propietario = "Jennifer";
            pTransaciones.Cuenta_retirar=txtcuentaO.Text.Trim();
            pTransaciones.Banco_retirar =txtbancoingre.Text.Trim();
            pTransaciones.Mon_retirar= Convert.ToInt32(txtvalorR.Text.Trim());

            string cuentaingreso = txtcuentaD.Text;
            if (cuentaingreso == "Efectivo" && Convert.ToInt32(txtvalorR.Text.Trim())>= 9600000)
            {
                G = (Convert.ToInt32(txtvalorR.Text) * 4) / 100;
                pTransaciones.GTM = G;
            }
            else
            {
                G = 00;
                pTransaciones.GTM = G;
            }
                

                string cuenta = txtcuentaO.Text;
            if (cuenta == "CuentaA")
            {
                int sa = saldoCuentaA - Convert.ToInt32(txtvalorR.Text.Trim()) - G;
                pTransaciones.Saldo_retiro = sa;

                saldoactual = sa;
            }
            else if (cuenta == "CuentaB")
            {
                saldofB = 165000000; 
                int sa = saldofB - Convert.ToInt32(txtvalorR.Text.Trim()) - G;
                pTransaciones.Saldo_retiro = sa;
                saldoactual = sa;
            }
            else if (cuenta == "CuentaC")
            {

                saldofC = 150500000;
                if (Convert.ToInt32(txtvalorR.Text.Trim()) >= 9600000)
                {
                    int sa = saldofC - Convert.ToInt32(txtvalorR.Text.Trim()) - G;
                    pTransaciones.Saldo_retiro = sa;
                    saldoactual = sa;
                }
                else
                {
                    saldofC = 150500000;
                    int sa = saldofC - Convert.ToInt32(txtvalorR.Text.Trim());
                    pTransaciones.Saldo_retiro = sa;
                    saldoactual = sa;
                }
                
            }

                pTransaciones.Cuenta_ingreso = txtcuentaD.Text.Trim();
            pTransaciones.Banco_ingreso = txtBancoDes.Text.Trim();

           
            if( cuentaingreso == "CuentaB")
            {
                int saldoi = saldoCuentaB + Convert.ToInt32(txtvalorR.Text.Trim());
                pTransaciones.Saldo_ingresar = saldoi;
                saldofinal = saldoi;
                
            }else if (cuentaingreso == "CuentaC")
            {
                int saldoi = saldoCuentaC + Convert.ToInt32(txtvalorR.Text.Trim());
                pTransaciones.Saldo_ingresar = saldoi;
                saldofinal = saldoi;
                
            }
            else if (cuentaingreso == "Efectivo")
            {
                pTransaciones.Saldo_ingresar = Convert.ToInt32(txtvalorR.Text.Trim());
                saldofinal= Convert.ToInt32(txtvalorR.Text.Trim());
            }
            

            int resultado = TransaccionDatos.Agregar(pTransaciones);

            if (resultado > 0)
            {
                MessageBox.Show("La transaccion fue realizada \n"+
                                "El monto a retiral fue: "+ Convert.ToInt32(txtvalorR.Text.Trim())+"\n"+
                                "El cobro GTM fue: "+G+"\n"+
                                "La cuenta y banco de retiro fueron \n"+
                                "Cuenta "+ cuenta +" Banco "+ txtbancoingre.Text+"\n"+
                                "El saldo en la cuenta retiro es: "+saldoactual+"\n" +
                                "La cuenta y el Banco o efectivo destino son \n"+
                                "Cuenta " + cuentaingreso + " Banco " + txtBancoDes.Text + "\n" +
                                "El saldo en la cuenta de final o efectivo es "+saldofinal+"\n", "Transaccion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else

            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas Gracias", "Final!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            txtBancoDes.Text = " ";
            txtbancoingre.Text = "";
            txtcuentaD.Text = "";
            txtcuentaO.Text = "";
            txtvalorR.Text = "";

        }
    }
}
