using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Domain.Entidades
{
    public class Pais : Entity
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O nome do Pais deve ser informado");
        }
    }
}
