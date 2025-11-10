using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Quarto
    {
        public int id { get; set; }
        public String Descricao { get; set; }
        public Double ValorDiariaAldulto { get; set; }
        public Double ValorDiariaCrianca { get; set; }
        public string Imagem { get; set;  }

    }
}
