using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Dtos
{
    public class CombineLibraryCreateDto
    {
        public int IdStyle { get; set; }

        public int IdSize { get; set; }

        public int IdLength { get; set; }

        public decimal? CostStyle { get; set; } = 0; //0 = Default value

        public decimal? CostTakeDown { get; set; } = 0;

        public decimal? CostTouchUp { get; set; } = 0;

        public decimal? CostHairDeduct { get; set; } = 0;

        public decimal? CostStyleBusyTime { get; set; } = 0;

        public int IdCompany { get; set; }
    }
}
