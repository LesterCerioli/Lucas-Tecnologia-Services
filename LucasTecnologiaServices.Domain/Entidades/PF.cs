using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Domain.Entidades
{
    public class PF : Entity
    {

        public int Id { get; set; }
        public string CPF { get; set; }
        public virtual Cliente Cliente { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(CPF))
                AdicionarCritica("O preenchimento é obrigatório!!");
        }
    }
}
