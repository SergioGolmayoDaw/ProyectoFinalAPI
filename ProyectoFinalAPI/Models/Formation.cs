using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Formation
    {
        public int FormationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Center { get; set; }
        public int CurriculumId { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }



    }
}
