using System;
using System.Collections.Generic;
using System.Text;

namespace PropostaBlazzor.Domain.Entities
{
    public class User : Entity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string LastName { get; set; }
        public string Passwoed { get; set; }
        public bool EhAdministrador { get; set; }

        public virtual ICollection<UserProfile> UserProfiles { get; set; }


        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");

            if (string.IsNullOrEmpty(FirstName))
                AdicionarCritica("O Nome não foi informado");

            if (string.IsNullOrEmpty(LastName))
                AdicionarCritica("O Sobrenome não foi informado");

            if (string.IsNullOrEmpty(Passwoed))
                AdicionarCritica("Senha não foi informado");
        }
    }
}
