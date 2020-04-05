using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Domain.Entidades
{
    public class Cliente : Entity
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeMeio { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public bool PF { get; set; }
        public bool PJ { get; set; }
        public int PJId { get; set; }
        public virtual ICollection<PJ> PJs { get; set; }
        public virtual ICollection<PF> PFs { get; set; }

        public string Identidade { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string NommeContato { get; set; }
        
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }
        public int PaisId { get; set; }
        public string EnderecoCompleto { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string Mobile { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
