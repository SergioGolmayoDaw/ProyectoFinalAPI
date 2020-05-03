using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string Position { get; set; }
        public int CompanyId { get; set; }
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CurriculumId { get; set; }

    }
}
