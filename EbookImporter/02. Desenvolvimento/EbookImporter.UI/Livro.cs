using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookImporter.UI
{
    public class Livro
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Ano { get; set; }
        public List<Capitulo> Capitulos { get; set; }
    }
}
