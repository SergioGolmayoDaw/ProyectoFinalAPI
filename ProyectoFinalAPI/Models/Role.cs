﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
