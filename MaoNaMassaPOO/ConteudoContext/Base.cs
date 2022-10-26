using MaoNaMassaPOO.NotificacaoContext;
using System;

namespace MaoNaMassaPOO.ConteudoContext
{
    public abstract class Base : Notificavel
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
