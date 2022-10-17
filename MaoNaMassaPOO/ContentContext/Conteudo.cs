using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassaPOO.ContentContext
{
    public abstract class Conteudo
    {
        public Conteudo()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Titulo{ get; set; }
        public string Url{ get; set; }
    }
}
