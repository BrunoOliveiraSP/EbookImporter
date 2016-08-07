using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookImporter.UI
{
    public class Capitulo
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public int PaginaInicial { get; set; }
        public int PaginaFinal { get; set; }
        public string Texto { get; set; }

        public List<Paragrafo> Paragrafos { get; set; }

    }

    public class Paragrafo
    {
        public int Orderm { get; set; }
        public string Texto { get; set; }
    }
}
