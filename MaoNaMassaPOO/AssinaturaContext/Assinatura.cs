using MaoNaMassaPOO.CompartilhamentoContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassaPOO.AssinaturaContext
{
    class Assinatura : Base
    {
        public Plano Plano { get; set; }
        public DateTime? DataFinal { get; set; }

        public bool Inativo => DataFinal < DateTime.Now;
    }
}
