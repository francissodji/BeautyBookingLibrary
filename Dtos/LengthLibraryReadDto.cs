using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingLibrary.Dtos
{
    public class LengthLibraryReadDto
    {
        public int IdLength { get; set; }

        public string? TitleLength { get; set; }

        public bool IsDefault { get; set; }

        public int IdCompany { get; set; }
    }
}
