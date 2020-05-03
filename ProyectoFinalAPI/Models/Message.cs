using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        [ForeignKey("User")]
        public int SenderUserId { get; set; }
        [ForeignKey("User")]

        public int ReceiverUserId { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
