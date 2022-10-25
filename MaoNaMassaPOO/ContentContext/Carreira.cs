using System.Collections.Generic;

namespace MaoNaMassaPOO.ContentContext
{
    class Carreira : Conteudo
    {
        public Carreira(string titulo, string url)
            : base(titulo, url)
        {
            Itens = new List<ItensDaCarreira>();
        }
        public IList<ItensDaCarreira> Itens { get; set; }
        public int TotalDeCursos => Itens.Count;
    }
}
