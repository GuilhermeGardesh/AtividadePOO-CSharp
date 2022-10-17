using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassaPOO.ContentContext
{
    public class Modulo
    {
        public Modulo()
        {
            Aulas = new List<Aula>();
        }
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public IList<Aula> Aulas { get; set; }
    }
}
