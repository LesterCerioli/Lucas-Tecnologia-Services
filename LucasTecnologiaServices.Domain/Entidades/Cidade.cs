using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Domain.Entidades
{
    public class Cidade : Entity
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O nome da Cidade deve ser informado");
        }
    }
}
