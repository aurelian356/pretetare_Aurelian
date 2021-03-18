using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pretetare_Aurelian.Models
{
        public enum Class
        {
            Econom, Business, VIP
        }

        public class Ruta
        {
            public string IDRuta { get; set; }
            public string Destinatia { get; set; }
            public double Pret { get; set; }
            public Class Class { get; set; }
            public Pasager Pasager { get; set; }
        }
    
}
