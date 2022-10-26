using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassaPOO.NotificacaoContext
{
    public sealed class Notificacao
    {
        public Notificacao()
        {
            HoraDoErro = DateTime.Now;
        }

        public Notificacao(string propriedadeComErro, string mensagem)
        {
            PropriedadeComErro = propriedadeComErro;
            Mensagem = mensagem;
            HoraDoErro = DateTime.Now;
        }

        public string PropriedadeComErro { get; set; }
        public string Mensagem { get; set; }
        public DateTime HoraDoErro { get; set; }
    }
}
