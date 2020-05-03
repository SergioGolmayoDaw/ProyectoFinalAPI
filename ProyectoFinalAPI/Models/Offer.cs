using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Offer
    {
        public int OfferId { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public ICollection<Tag> Tags { get; set; }

    }
}
