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
            //Se establece la ruta del archivo
            var path = @"C:/Integracion open source/ejemplo.json";

            //Se crea un objeto Formulario y se llena con los campos del Form
            //Aun no acepta campos nulos
            Formulario formulario = new Formulario();
            formulario.RNC = int.Parse(rnc.Text);
            formulario.CuentaEncabezado = int.Parse(cuentaBeneficiario.Text);
            formulario.TipoMoneda = tipoMoneda.Text;
            formulario.FechaRegistro = dtpFechaRegistro.Value.Date;
            formulario.MontoTotal = int.Parse(montoTotal.Text);
            formulario.TotalRegistros = int.Parse(cantRegistros.Text);
            
            //Se crea una lista tipo Detalle para llenarlo con los datos del Datagridview
            List<Detalle> detalles = new List<Detalle>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Detalle deta = new Detalle();
                deta.Cedula = int.Parse(row.Cells[0].Value.ToString());
                deta.Cuenta = int.Parse(row.Cells[1].Value.ToString());
                deta.Monto = int.Parse(row.Cells[2].Value.ToString());
                detalles.Add(deta);
            }
            formulario.detalles = detalles;

            //Se genera la linea string en base a convertir el objeto formulario
            string output = JsonConvert.SerializeObject(formulario);

            //Se procede crear y escribir el archivo con el string output
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
            //Muestra el formulario de lectura del archivo
            FrmLectura frml = new FrmLectura();
            frml.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se asegura que al celda que se clickeo sea la de "eliminar y elimina la fila de esa celda
            if (e.RowIndex < 0 || e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            else
            {
                return;
            }
        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            //Añade una fila al Datagridview, esto para evitar errores a la hora de eliminar filas no confirmadas
            dataGridView1.Rows.Add();
        }
    }
}
