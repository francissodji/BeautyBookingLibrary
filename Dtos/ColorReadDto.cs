﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingLibrary.DTOs
{
    public class ColorReadDto
    {

        public int IdColor { get; set; }

        //[MaxLength(100)]
        public string TitleColor { get; set; }

        //[MaxLength(20)]
        public string RefColor { get; set; }
    }
}
