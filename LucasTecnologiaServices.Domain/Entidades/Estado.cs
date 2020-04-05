using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Domain.Entidades
{
    public class Estado : Entity
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public virtual Cidade Cidade { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O nome do Estado deve ser informado");
        }
    }
}
