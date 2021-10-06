using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp12.Model
{
    public class Formulario
    {
        public int RNC { get; set; }
        public int CuentaEncabezado { get; set; }
        public string TipoMoneda { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int MontoTotal { get; set; }
        public int TotalRegistros { get; set; }
        public List<Detalle> detalles { get; set; }

        public static explicit operator Formulario(JToken v)
        {
            throw new NotImplementedException();
        }
    }
}
