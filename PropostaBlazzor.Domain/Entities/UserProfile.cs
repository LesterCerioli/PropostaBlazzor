using System;
using System.Collections.Generic;
using System.Text;

namespace PropostaBlazzor.Domain.Entities
{
    public class UserProfile : Entity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int UerId { get; set; }
        public bool DefaultUser { get; set; }
        public bool AdminUser { get; set; }
        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
