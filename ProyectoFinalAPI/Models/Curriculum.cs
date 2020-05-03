using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Curriculum
    {
        public int CurriculumId { get; set; }
        public int UserId { get; set; }
        public ICollection<Formation> Formations { get; set; }
        public ICollection<Experience> Experiences { get; set; }

    }
}
