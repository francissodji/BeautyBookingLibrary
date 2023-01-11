using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingLibrary.Dtos
{
    public class LengthLibraryUpdateDto
    {
        public string? TitleLength { get; set; }

        public int IdStyle { get; set; }
    }
}
