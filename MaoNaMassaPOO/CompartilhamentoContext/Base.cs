using MaoNaMassaPOO.NotificacaoContext;
using System;

namespace MaoNaMassaPOO.CompartilhamentoContext
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
