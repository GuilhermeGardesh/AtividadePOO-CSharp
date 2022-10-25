using MaoNaMassaPOO.ContentContext.Enums;
using System.Collections.Generic;

namespace MaoNaMassaPOO.ContentContext
{
    public class Curso : Conteudo
    {
        public Curso(string titulo, string url)
            : base(titulo, url)
        {
            Modulos = new List<Modulo>();
        }
        public string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; }
        public int DucacaoEmMinutos { get; set; }
        public ENiveisDoConteudo Level { get; set; }
    }
}
