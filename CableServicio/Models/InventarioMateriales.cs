﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CableServicio.Models
{
    [Table("InventarioMateriales")]
    public class InventarioMaterial
    {
        
        [ForeignKey("Material")]
        public int InventarioMaterialId { get; set; }

        public Material Material { get; set; }

        public int Existencia { get; set; }
    }
}