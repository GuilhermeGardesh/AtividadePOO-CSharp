using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassaPOO.NotificacaoContext
{
    public abstract class Notificavel
    {
        public List<Notificacao> Notificacoes{ get; set; }

        public void Add(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }
        public void AddRange(IEnumerable<Notificacao> notificacaos)
        {
            Notificacoes.AddRange(notificacaos);
        }

    }
}
