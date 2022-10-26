using MaoNaMassaPOO.CompartilhamentoContext;
using MaoNaMassaPOO.NotificacaoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaoNaMassaPOO.AssinaturaContext
{
    class Aluno : Base
    {
        public Aluno()
        {
            Assinaturas = new List<Assinatura>();
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }
        public IList<Assinatura> Assinaturas { get; set; }

        public void CriarAssinatura(Assinatura assinatura)
        {
            if (Premium)
            {
                AddNotificacao(new Notificacao("Premium", "o aluno já tem assinatura ativa"));
                return;
            }
            Assinaturas.Add(assinatura);
        }

        public bool Premium => Assinaturas.Any(x => !x.Inativo);
    }
}
