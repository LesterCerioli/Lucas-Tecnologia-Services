using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Domain.Entidades
{
    public class Perfil : Entity
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int UsuarioId { get; set; }
        public bool EhAdministrador { get; set; }
        public virtual Usuario Usuario { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O nome do perfil não foi informado");

            

        }
    }
}
