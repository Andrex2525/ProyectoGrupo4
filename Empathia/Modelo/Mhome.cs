using System;
using System.Collections.Generic;
using System.Text;

namespace Empathia.Modelo
{
    public class Mhome
    {

        public string Pagina { get; set; }
        public string Icono { get; set; }
    }

    public class ImagenInicio
    {
        public int id { get; set; }
        public string title { get; set; }

        public string texto { get; set; }   
        public string country { get; set; }
        public string imgSource { get; set; }
        public string logo { get; set; }    
        public string duracion { get; set; }
    }
}
