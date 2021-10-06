using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormsApp12.Model;
using Newtonsoft.Json;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var path = @"C:/Integracion open source/ejemplo.json";

            Formulario formulario = new Formulario();
            formulario.RNC = int.Parse(rnc.Text);
            formulario.CuentaEncabezado = int.Parse(cuentaBeneficiario.Text);
            formulario.TipoMoneda = tipoMoneda.Text;
            formulario.FechaRegistro = dtpFechaRegistro.Value.Date;
            formulario.MontoTotal = int.Parse(montoTotal.Text);
            formulario.TotalRegistros = int.Parse(cantRegistros.Text);
            //Esto hay que sacarlo del datagridview y no se, hacer un while para que agrege cada registro
            formulario.detalles = new List<Detalle> {
                new Detalle {Cedula = int.Parse(cedula.Text), CuentaDetalle = int.Parse(cuentaEmpleado.Text), Monto = int.Parse(monto.Text)},
            };

            string output = JsonConvert.SerializeObject(formulario);

            try
            {
                using (TextWriter fs = File.CreateText(path))
                {
                    fs.WriteLine(output);
                    MessageBox.Show("Archivo generado exitosamente en: " + path.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLectura frml = new FrmLectura();
            frml.Show();
        }
    }
}
