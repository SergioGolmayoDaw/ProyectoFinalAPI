using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Inscription
    {
        public int InscriptionId { get; set; }
        public int UserId { get; set; }
        public int OfferId { get; set; }
        public string Message { get; set; }
    }
}
