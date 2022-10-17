using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassaPOO.ContentContext
{
    public class Curso : Conteudo
    {
        public Curso()
        {
            Modulos = new List<Modulo>();
        }
        public string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; }
    }
}
