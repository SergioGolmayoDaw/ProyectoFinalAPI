using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Descripcion { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string ImageUrl { get; set; }
        public int CompanyId { get; set; }
        public int CurriculumId { get; set; }
        public ICollection<Role> Roles {get;set;}
        public ICollection<Publication> Publications { get; set; }
        public ICollection<Valoration> Valorations { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Inscription> Inscriptions { get; set; }












    }
}
