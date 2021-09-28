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
            var path = @"C:\Users\Dana M. Cruz Paulino\Desktop\Apec\Noveno cuatrimetre\Integracion open source\ejemplo.txt";

            List<string> formulario = new List<string>();

            formulario.Add(tipoRegistro.Text);
            formulario.Add(rnc.Text);
            formulario.Add(fechaTransaccion.Text);
            formulario.Add(cuentaBeneficiario.Text);
            formulario.Add(tipoMoneda.Text);
            formulario.Add(tipoRegistroD.Text);
            formulario.Add(cuentaEmpleado.Text);
            formulario.Add(cedula.Text);
            formulario.Add(monto.Text);
            formulario.Add(montoTotal.Text);
            formulario.Add(tipoRegistroS.Text);
            formulario.Add(cantRegistros.Text);

            
                using (TextWriter fs = File.CreateText(path))
                {
                    foreach (var item in formulario)
                    {
                        fs.WriteLine(item.ToString());
                    }
                   
                }
        }
    }
}
