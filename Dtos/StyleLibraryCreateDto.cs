using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingLibrary.Dtos
{
    public class StyleLibraryCreateDto
    {
        public string? TitleStyle { get; set; }

        public string? DescriptStyle { get; set; }

        public bool isHairProvided { get; set; } = false;

        public string? PictureStyle { get; set; }

        public int IdCompany { get; set; }
    }
}
