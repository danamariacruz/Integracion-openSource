using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            var path = @"C:/Integracion open source/ejemplo.txt";

            List<string> formulario = new List<string>();

            if (!File.Exists(path))
            {
                MessageBox.Show("Archivo no encontrado, favor de colocar el archivo en la ubicacion especifica " + path.ToString());
            }

            try{
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        formulario.Add(sr.ReadLine());
                    }
                }

                MessageBox.Show("Archivo cargado exitosamente");

                tipoRegistro.Text = formulario[0].ToString();
                rnc.Text = formulario[1].ToString();
                fechaTransaccion.Text = formulario[2].ToString();
                cuentaBeneficiario.Text = formulario[3].ToString();
                tipoMoneda.Text = formulario[4].ToString();
                montoTotal.Text = formulario[5].ToString();
                tipoRegistroD.Text = formulario[6].ToString();
                cuentaEmpleado.Text = formulario[7].ToString();
                cedula.Text = formulario[8].ToString();
                monto.Text = formulario[9].ToString();
                tipoRegistroS.Text = formulario[10].ToString();
                cantRegistros.Text = formulario[11].ToString();

            }
            catch (FileNotFoundException ex){
                MessageBox.Show("No se ha podido leer el archivo: " + ex.ToString());
            }
        }
    }
}
