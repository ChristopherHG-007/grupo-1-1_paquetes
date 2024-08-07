using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorizacion.Abstracciones.Entidades
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public char? RoleCode { get; set; }
        public bool RoleStatus { get; set; }
        //Dates
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdate { get; set; }
        public DateTime DateDelete { get; set; }
    }
}
