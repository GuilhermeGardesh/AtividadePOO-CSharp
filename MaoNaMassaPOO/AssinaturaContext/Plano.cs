using MaoNaMassaPOO.CompartilhamentoContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassaPOO.AssinaturaContext
{
    class Plano : Base
    {
        public string Titulo { get; set; }
        public double Preco { get; set; }
        public DateTime? DataFinal { get; set; }
    }
}
