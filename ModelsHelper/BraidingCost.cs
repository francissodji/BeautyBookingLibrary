using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingLibrary.ModelsHelper
{
    public class BraidingCost
    {
        public int IdStyle { get; set; }

        public int IdSize { get; set; }

        public int IdLength { get; set; }

        public char TypeService { get; set; }

        public bool IsTakeDown { get; set; }

        public decimal CostStyle { get; set; }

        public decimal CostTakeDown { get; set; }

        public decimal CostTouchUp { get; set; }

        public decimal CostHairDeduct { get; set; }

        public decimal CostStyleBusyTime { get; set; }

        public decimal TotalTouchUpCost { get; set; }

        public decimal TotalExtraSizeLengthCost { get; set; }

        public decimal TotalCost { get; set; }
    }
}
