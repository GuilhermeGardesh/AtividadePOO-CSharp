using MaoNaMassaPOO.CompartilhamentoContext;
using MaoNaMassaPOO.ConteudoContext.Enums;

namespace MaoNaMassaPOO.ConteudoContext
{
    public class Aula : Base
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public int DucacaoEmMinutos { get; set; }
        public ENiveisDoConteudo Level { get; set; }
    }
}