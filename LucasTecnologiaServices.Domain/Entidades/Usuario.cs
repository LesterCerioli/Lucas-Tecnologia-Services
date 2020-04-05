using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Domain.Entidades
{
    public class Usuario : Entity
    {


        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int PerfilId { get; set; }
        public virtual ICollection<Perfil> Perfils { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não foi informado");

            if (string.IsNullOrEmpty(Login))
                AdicionarCritica("Login não foi informado");

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome não foi informado");

            if (string.IsNullOrEmpty(Sobrenome))
                AdicionarCritica("Sobrenome não foi informado");
        }
    }
}
