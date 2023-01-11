using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.ModelsHelper
{
    public class CatalogCombine
    {
        public int IdCatalog { get; set; }

        public string? ImageLink { get; set; }

        public int IdCombine { get; set; }

        public int IdCompany { get; set; }

        public int IdStyle { get; set; }

        public string? TitleStyle { get; set; }

        public int IdSize { get; set; }

        public string? TitleSize { get; set; }

        public int IdLength { get; set; }

        public string? TitleLength { get; set; }

        public decimal? CostStyle { get; set; } = 0;

        public decimal? CostTakeDown { get; set; } = 0;

        public decimal? CostTouchUp { get; set; } = 0;

        public decimal? CostHairDeduct { get; set; } = 0;

        public decimal? CostStyleBusyTime { get; set; } = 0;
    }
}
