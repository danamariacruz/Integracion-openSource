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
            //Se especifica la posicion del archivo
            var path = @"C:/Integracion open source/ejemplo.json";
            
            //Se confirma que el archivo existe en el path dado
            if (!File.Exists(path))
            {
                MessageBox.Show("Archivo no encontrado, favor de colocar el archivo en la ubicacion especifica " + path.ToString());
            }

            try
            {
                //Se lee el archivo y se guarda en un string
                List<string> input = new List<string>();
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        input.Add(sr.ReadLine());
                    }
                }

                //Se llena el objeto formulario en base a el string con formato json
                Formulario formulario = JsonConvert.DeserializeObject<Formulario>(input[0].ToString());

                //Se llenan los campos con los datos del objeto formulario
                rnc.Text = formulario.RNC.ToString();
                cuentaBeneficiario.Text = formulario.CuentaEncabezado.ToString();
                tipoMoneda.Text = formulario.TipoMoneda.ToString();
                montoTotal.Text = formulario.MontoTotal.ToString();
                dtpFechaRegistro.Value = formulario.FechaRegistro;
                cantRegistros.Text = formulario.TotalRegistros.ToString();
                //Notar que como formulario.detalles es una lista se puede utilizar como fuente de datos para el Datagridview y se autorellena el espacio del mismo con los campos de la lista
                dataGridView1.DataSource = formulario.detalles;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (FileNotFoundException ex){
                MessageBox.Show("No se ha podido leer el archivo: " + ex.ToString());
            }
        }
    }
}
