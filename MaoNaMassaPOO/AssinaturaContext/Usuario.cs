using MaoNaMassaPOO.CompartilhamentoContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassaPOO.AssinaturaContext
{
    class Usuario : Base
    {
        public string NomeDeUsuario { get; set; }
        public string Senha { get; set; }
    }
}
