using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Valoration
    {
        public int ValorationId { get; set; }
        public int PublicationId { get; set; }
        public int UserId { get; set; }
        public float Score { get; set; }
        public string Comment { get; set; }


    }
}
