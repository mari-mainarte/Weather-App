using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Cidade
    {
        public string Nome { get; set; }
        public string Temperatura { get; set; }
        public string Condicao { get; set; }
        public string Umidade { get; set; }
        public string Vento { get; set; }
    }
}
