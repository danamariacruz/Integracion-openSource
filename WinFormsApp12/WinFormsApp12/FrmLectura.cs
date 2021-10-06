using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WinFormsApp12.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WinFormsApp12
{
    public partial class FrmLectura : Form
    {
        public FrmLectura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = @"C:/Integracion open source/ejemplo.json";
            List<string> input = new List<string>();

            if (!File.Exists(path))
            {
                MessageBox.Show("Archivo no encontrado, favor de colocar el archivo en la ubicacion especifica " + path.ToString());
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        input.Add(sr.ReadLine());
                    }
                }

                Formulario formulario = JsonConvert.DeserializeObject<Formulario>(input[0].ToString());

                rnc.Text = formulario.RNC.ToString();
                cuentaBeneficiario.Text = formulario.CuentaEncabezado.ToString();
                tipoMoneda.Text = formulario.TipoMoneda.ToString();
                montoTotal.Text = formulario.MontoTotal.ToString();
                dtpFechaRegistro.Value = formulario.FechaRegistro;
                cantRegistros.Text = formulario.TotalRegistros.ToString();
                //Desde aqui se deben coger los datos de la lista y pasarlas al datagridview, otra vez, no se como, seguro que con un while XD
                CedulaEmpleado.Text = formulario.detalles[0].Cedula.ToString();
                cuentaEmpleado.Text = formulario.detalles[0].CuentaDetalle.ToString();
                MontoEmpleado.Text = formulario.detalles[0].Monto.ToString();

            }
            catch (FileNotFoundException ex){
                MessageBox.Show("No se ha podido leer el archivo: " + ex.ToString());
            }
        }
    }
}
