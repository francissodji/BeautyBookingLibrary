using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Models
{
    public class LengthLibrary
    {
        [Key]
        public int IdLength { get; set; }

        [MaxLength(100)]
        public string? TitleLength { get; set; }

        public bool IsDefault { get; set; }

        public int IdCompany { get; set; }

    }
}
