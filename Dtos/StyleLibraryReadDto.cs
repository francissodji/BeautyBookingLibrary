using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingLibrary.Dtos
{
    public class StyleLibraryReadDto
    {
        public int IdStyle { get; set; }

        public string? TitleStyle { get; set; }

        public string? DescriptStyle { get; set; }

        public bool isHairProvided { get; set; } = false;

        public string? PictureStyle { get; set; }

        public int IdCompany { get; set; }
    }
}
