using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingLibrary.Dtos
{
    public class SizeLibraryReadDto
    {
        public int IdSize { get; set; }

        public string? TitleSize { get; set; }

        public bool? IsDefault { get; set; }

        public int? IdCompany { get; set; }
    }
}
