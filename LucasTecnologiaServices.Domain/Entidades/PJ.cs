using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Domain.Entidades
{
    public class PJ : Entity
    {

        public int IdPJ { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public virtual Cliente Cliente { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(CNPJ))
                AdicionarCritica("O preenchimento é obrigatório!!");
            if (string.IsNullOrEmpty(RazaoSocial))
                AdicionarCritica("O preenchimento é obrigatório!!");
            if (string.IsNullOrEmpty(NomeFantasia))
                AdicionarCritica("O preenchimento é obrigatório!!");
        }
    }
}
