using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Models
{
    public class CatalogLibrary
    {
        [Key]
        public int IdCatalog { get; set; }

        [MaxLength(500)]
        public string? ImageLink { get; set; }

        public int IdCombine { get; set; }

        public int IdCompany { get; set; }
    }
}
