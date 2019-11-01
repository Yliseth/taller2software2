using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_poo
{
    public partial class AprobacionCredito : Form
    {
        public AprobacionCredito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AprobacionCredito_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((cbTipoIdentificacion.SelectedItem as string) == "Pasaporte")
            {

                if (e.KeyChar != 8)
                    if (!(e.KeyChar >= 48 && e.KeyChar <= 57) &&
                    !(e.KeyChar >= 65 && e.KeyChar <= 90) &&
                        !(e.KeyChar >= 97 && e.KeyChar <= 122))
                    {
                        e.Handled = true;
                    }

            }

            else if (cbTipoIdentificacion.SelectedItem as string != "Pasaporte")
            {
                if (e.KeyChar != 8)
                    if (!(e.KeyChar >= 48 && e.KeyChar <= 57))
                    {
                        e.Handled = true;
                    }

            }
        }

        private void txbMontoTotalCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
                if (!(e.KeyChar >= 48 && e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
        }

        private void txbPlazoPagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
                if (!(e.KeyChar >= 48 && e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
                if (!(e.KeyChar >= 48 && e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
        }

        private void tbxNombresApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32)
                if (!(e.KeyChar >= 65 && e.KeyChar <= 90) &&
                !(e.KeyChar >= 97 && e.KeyChar <= 122))
                {
                    e.Handled = true;
                }
        }

        private void txbNombreAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 8 && e.KeyChar != 32)
                if (!(e.KeyChar >= 65 && e.KeyChar <= 90) &&
                !(e.KeyChar >= 97 && e.KeyChar <= 122))
                {
                    e.Handled = true;
                }
        }

        private void calculo_Click(object sender, EventArgs e)
        {
            Double numeroCreditos = Convert.ToDouble(numeroCreditosAbiertos.Text);
            double montoCredito = double.Parse(txbMontoTotalCredito.Text.Replace("$", " ")
                    .Replace(",", "")
                    .Replace(".", "")
                .Replace(" ", ""));
         
            double totalMontosCancelados = double.Parse(montosCancelados.Text.Replace("$", " ")
                    .Replace(",", "")
                    .Replace(".", "")
                .Replace(" ", ""));
            Double montoMaximoVivienda = 200000000;
            Double promedio = totalMontosCancelados / numeroCreditos;
            Double mitadPromedio = promedio / 2;
            Double pagos = Convert.ToDouble(Numerosdepagos.Text);

            Double montoMaximoEducacion = 50000000;
            Double promedioEducacion = totalMontosCancelados / numeroCreditos;
            Double mitadPromedioEducacion = promedioEducacion / 2;

            Double montoMaximoLibreinversion = 15000000;
            Double promedioLibreinversion = totalMontosCancelados / numeroCreditos;
            Double mitadPromedioLibreinversion = promedioLibreinversion / 2;



            //variables cliente plata
            Double montoMaximoViviendaPlata = 100000000;
            Double siCreditoViviendaPlata = 150000000;
           

            // regalos aleatorios
         
          Random regalo = new Random();
          int index = regalo.Next(0, listaRegalos.Items.Count);

            // variables cliente plata educacion
          Double montoMaximoEducacionPlata = 20000000;
          Double siCreditoEducacionPlata = 30000000;
          Random regalo2 = new Random();
          int index2 = regalo2.Next(0, listaRegalosEducacion.Items.Count);

           // variables cliente plata Credito Libre inversion
           Double montoMaximoLibreinversionPlata = 7000000;
           Double siCreditoLibreinversionPlata = 10000000;


            // variables cliente bronce
           Double montoMaximoViviendaBronce = 50000000;   
           Double montoMaximoEducacionBronce= 15000000;
           Double montoMaximoLibreinversionBronce=5000000;

            //oro
            if (cbxTipoCliente.SelectedItem as string == "Oro")
            {

                //vivienda

                {
                    if ((tipoCredito.SelectedItem as string == "Vivienda" && numeroCreditos > 3) ||
                        (tipoCredito.SelectedItem as string == "Vivienda" && pagos > 4 && pagoatiempo.SelectedItem as string == "NO")
                       || (tipoCredito.SelectedItem as string == "Vivienda" && montoCredito >= montoMaximoVivienda ))
                    { MessageBox.Show("El credito para vivienda ha sido rechazado"); }

                    else if ((tipoCredito.SelectedItem as string == "Vivienda" && numeroCreditos < 1 && montoCredito <= montoMaximoVivienda) ||
                            (tipoCredito.SelectedItem as string == "Vivienda" && (numeroCreditos >= 1 && numeroCreditos <= 3) &&
                            (montoCredito <= (montoMaximoVivienda + mitadPromedio))))
                    { MessageBox.Show("El credito para vivienda ha sido aprobado"); }
                }

                //Educación
                {
                    if ((tipoCredito.SelectedItem as string == "Educación" && numeroCreditos > 3)
                       || (tipoCredito.SelectedItem as string == "Educación" && pagos > 4 && pagoatiempo.SelectedItem as string == "NO")
                         || (tipoCredito.SelectedItem as string == "Educación" && montoCredito >= montoMaximoEducacion))
                    { MessageBox.Show("El credito ha sido rechazado"); }

                    else if ((tipoCredito.SelectedItem as string == "Educación" && numeroCreditos < 1 && montoCredito <= montoMaximoEducacion) ||
                            (tipoCredito.SelectedItem as string == "Educación" && (numeroCreditos >= 1 && numeroCreditos <= 3) &&
                            (montoCredito <= (montoMaximoEducacion + mitadPromedioEducacion))))
                    { MessageBox.Show(" El credito para educacion ha sido aprobado"); }
                }

                //Libreinversión

                {
                    if ((tipoCredito.SelectedItem as string == "Libre inversión" && numeroCreditos > 3) ||
                        (tipoCredito.SelectedItem as string == "Libre inversión" && pagos > 4 && pagoatiempo.SelectedItem as string == "NO")
                        || (tipoCredito.SelectedItem as string == "Libre inversión" && montoCredito >= montoMaximoLibreinversion))
                    { MessageBox.Show("El credito ha sido rechazado"); }

                    else if ((tipoCredito.SelectedItem as string == "Libre inversión" && numeroCreditos < 1 && montoCredito <= montoMaximoLibreinversion) ||
                       (tipoCredito.SelectedItem as string == "Libre inversión" && (numeroCreditos >= 1 && numeroCreditos <= 3) &&
                        (montoCredito <= (montoMaximoLibreinversion + mitadPromedioLibreinversion))))
                    { MessageBox.Show(" El credito de libre inversion ha sido aprobado"); }
                }

            }

            ///Plata



            if (cbxTipoCliente.SelectedItem as string == "Plata")
            {

                //vivienda

                {
                    if ((tipoCredito.SelectedItem as string == "Vivienda" && numeroCreditos > 2) ||
                        (tipoCredito.SelectedItem as string == "Vivienda" && pagos > 2 && pagoatiempo.SelectedItem as string == "NO")
                        || (tipoCredito.SelectedItem as string == "Vivienda" && montoCredito >= montoMaximoViviendaPlata))
                    { MessageBox.Show("El credito para vivienda ha sido rechazado"); }

                    else if ((tipoCredito.SelectedItem as string == "Vivienda" && numeroCreditos < 1 && montoCredito <= montoMaximoViviendaPlata) ||
                            (tipoCredito.SelectedItem as string == "Vivienda" && (numeroCreditos >= 1 && numeroCreditos <= 2) &&
                            (montoCredito <= siCreditoViviendaPlata)))
                    { MessageBox.Show("El credito para vivienda ha sido aprobado;" + "  y Recibiras los siguientes regalos " + listaRegalos.Items[index].ToString() ); }


                }
                // educacion

                {
                    if ((tipoCredito.SelectedItem as string == "Educación" && numeroCreditos > 3)
                       || (tipoCredito.SelectedItem as string == "Educación" && pagos > 4 && pagoatiempo.SelectedItem as string == "NO")
                       || (tipoCredito.SelectedItem as string == "Educación" && montoCredito >= montoMaximoEducacionPlata)) 
                    { MessageBox.Show("El credito ha sido rechazado"); }

                    else if ((tipoCredito.SelectedItem as string == "Educación" && numeroCreditos < 1 && montoCredito <= montoMaximoEducacionPlata) ||
                            (tipoCredito.SelectedItem as string == "Educación" && (numeroCreditos >= 1 && numeroCreditos <= 3) &&
                            (montoCredito <= siCreditoEducacionPlata)))
                    { MessageBox.Show(" El credito para educacion ha sido aprobado;" +
                        "  y Recibiras los siguientes regalos " + listaRegalosEducacion.Items[index].ToString()); }
                }
                //Libreinversión

                {
                    if ((tipoCredito.SelectedItem as string == "Libre inversión" && numeroCreditos > 3) ||
                        (tipoCredito.SelectedItem as string == "Libre inversión" && pagos > 4 && pagoatiempo.SelectedItem as string == "NO")
                           || (tipoCredito.SelectedItem as string == "Libre inversión" && montoCredito >= montoMaximoLibreinversionPlata)) 
                    { MessageBox.Show("El credito ha sido rechazado"); }

                    else if ((tipoCredito.SelectedItem as string == "Libre inversión" && numeroCreditos < 1 && montoCredito <= montoMaximoLibreinversionPlata) ||
                       (tipoCredito.SelectedItem as string == "Libre inversión" && (numeroCreditos >= 1 && numeroCreditos <= 3) &&
                        (montoCredito <= siCreditoLibreinversionPlata)))
                    { MessageBox.Show(" El credito de libre inversion ha sido aprobado"); }
                }
            }

            // bronce
                if (cbxTipoCliente.SelectedItem as string == "Bronce")
                {
                    { if((tipoCredito.SelectedItem as string == "Vivienda" && numeroCreditos >= 1)||
                        (tipoCredito.SelectedItem as string == "Vivienda" && pagos > 1 && pagoatiempo.SelectedItem as string == "NO")
                       || (tipoCredito.SelectedItem as string == "Vivienda" && montoCredito >= montoMaximoViviendaBronce))
                    { MessageBox.Show("El credito para vivienda ha sido rechazado"); }
                    
                    else if (tipoCredito.SelectedItem as string == "Vivienda" && numeroCreditos < 1 && montoCredito <= montoMaximoViviendaBronce)                       
                    { MessageBox.Show("El credito para vivienda ha sido aprobado;" ); } 
                    
                    }
                   
                    {if((tipoCredito.SelectedItem as string == "Educacion" && numeroCreditos >= 1)||
                        (tipoCredito.SelectedItem as string == "Educacion" && pagos > 1 && pagoatiempo.SelectedItem as string == "NO")
                         || (tipoCredito.SelectedItem as string == "Educacion" && montoCredito >= montoMaximoEducacionBronce))
                    { MessageBox.Show("El credito para vivienda ha sido rechazado"); }

                     else if (tipoCredito.SelectedItem as string == "Educacion" && numeroCreditos < 1 && montoCredito <= montoMaximoEducacionBronce)                       
                    { MessageBox.Show("El credito para vivienda ha sido aprobado;" ); } 
                    }
                   
                    {if((tipoCredito.SelectedItem as string == "Libre inversión " && numeroCreditos >= 1)||
                        (tipoCredito.SelectedItem as string == "Libre inversión" && pagos > 1 && pagoatiempo.SelectedItem as string == "NO")
                        || (tipoCredito.SelectedItem as string == "Libre inversión" && montoCredito >= montoMaximoLibreinversionBronce))
                    { MessageBox.Show("El credito para vivienda ha sido rechazado"); } 
                     else if (tipoCredito.SelectedItem as string == "Libre inversión" && numeroCreditos < 1 && montoCredito <= montoMaximoLibreinversionBronce)                       
                    { MessageBox.Show("El credito para vivienda ha sido aprobado;" ); } 
                    }
                }
            }

        private void ResumenInformacion_Click(object sender, EventArgs e)
        {
            try
            {
                string Tipodecliente = cbxTipoCliente.SelectedItem as string;
                string Tipodeidentificacion = cbTipoIdentificacion.SelectedItem as string;
                string Numerodeidentificacion = Numerodedocumento.Text;
                string Nombreyapellidos = tbxNombresApellidos.Text;
                string creditosconlacompañia = numeroCreditosAbiertos.Text;
                string TiposdeCreditos = tipoCredito.SelectedItem as string;
                double montodelcredito = double.Parse(txbMontoTotalCredito.Text.Replace("$", " ")
                    .Replace(",", "")
                    .Replace(".", "")
                .Replace(" ", ""));

                string plazodepagos = txbPlazoPagos.Text;
                double montoscancelados = double.Parse(montosCancelados.Text.Replace("$", " ")
                    .Replace(",", "")
                    .Replace(".", "")
                .Replace(" ", "")) ;
                string numerosdepagos1 = Numerosdepagos.Text;
                string pagojustoatiempo = pagoatiempo.SelectedItem as string;

                 string RInformacion = @"TIPO DE CLIENTE: " + Tipodecliente + "\n" + "TIPO DE IDENTIFICACIÓN: " + Tipodeidentificacion + "\n" + 
                     "NUMERO DE IDENTIFICACIÓN: " + Numerodeidentificacion + "\n" + "NOMBRES Y APELLIDOS DEL CLIENTE " + Nombreyapellidos + "\n" + "NUMEROS DE CREDITOS OBTENIDOS CON LA COMPAÑIA: " + creditosconlacompañia + "\n" +
                     "TIPO DE CREDITO A SOLICITAR: " + TiposdeCreditos + "\n" + "MONTO DEL CREDITO A SOLICITAR: " + montodelcredito + "\n" + "PLAZO DE PAGOS: " + plazodepagos + "\n" +
                     "MONTOS CANCELADOS A LA COMPAÑIA POR CREDITOS: " + montoscancelados + "\n" + "NUMERO DE PAGOS REALIZADOS A LA COMPAÑIA: " + numerosdepagos1 + "\n" +
                     "¿REALIZO A TIEMPO TODOS LOS PAGOS?: " + pagojustoatiempo;
                 MessageBox.Show("CLIENTE GUARDADO: " + RInformacion, "CLIENTE ",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            catch (Exception exc) { MessageBox.Show("Error al guardar al cliente:   " + exc.Message, "CLIENTE",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information); }
        }

        private void numeroCreditosAbiertos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
                if (!(e.KeyChar >= 48 && e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
        }

        private void Numerosdepagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
                if (!(e.KeyChar >= 48 && e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
        }
        }

       
}

