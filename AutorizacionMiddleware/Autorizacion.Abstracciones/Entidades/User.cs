using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizacion.Abstracciones.Entidades
{
    public class User
    {
        //ID
        public Guid UserId { get; set; }

        //---
        public char? UserCode { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool UserStatus { get; set; }
        public string UserAddress { get; set; }

        //Dates
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdate { get; set; }
        public DateTime DateDelete { get; set; }

    }
}
