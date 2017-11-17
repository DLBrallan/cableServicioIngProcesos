﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CableServicio.Models
{
    [Table("Tecnicos")]
    public class Tecnico
    {
        public string TecnicoId { get; set; }

        public ApplicationUser AppUser { get; set; }
    }
}