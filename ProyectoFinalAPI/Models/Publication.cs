using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Publication
    {
        public int PublicationId { get; set; }
        public int UserId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Valoration> Valorations { get; set; }
        public ICollection<Tag> Tags { get; set; }


    }
}
