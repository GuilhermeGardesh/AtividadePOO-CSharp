using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaoNaMassaPOO.NotificacaoContext
{
    public abstract class Notificavel
    {
        public List<Notificacao> Notificacoes{ get; set; }

        public Notificavel()
        {
            Notificacoes = new List<Notificacao>();
        }

        public void AddNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }
        public void AddNotificacoes(IEnumerable<Notificacao> notificacaos)
        {
            Notificacoes.AddRange(notificacaos);
        }

        public bool EInvalido => Notificacoes.Any();
    }
}
