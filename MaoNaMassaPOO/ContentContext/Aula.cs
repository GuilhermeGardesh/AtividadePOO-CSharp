using MaoNaMassaPOO.ContentContext.Enums;

namespace MaoNaMassaPOO.ContentContext
{
    public class Aula
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public int DucacaoEmMinutos { get; set; }
        public ENiveisDoConteudo Level { get; set; }
    }
}