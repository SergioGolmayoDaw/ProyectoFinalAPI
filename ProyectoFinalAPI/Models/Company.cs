using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Offer> Offers { get; set; }



    }
}
