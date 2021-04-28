﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogWebApi.Dtos
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }
    }
}
