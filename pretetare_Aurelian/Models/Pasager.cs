using System;
using System.Collections.Generic;
using System.Text;

namespace pretetare_Aurelian.Models
{
    public class Pasager
    {
        public string ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public List<Ruta> Rute { get; set; }
    }
}
