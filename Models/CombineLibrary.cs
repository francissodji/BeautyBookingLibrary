using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Models
{
    public class CombineLibrary
    {
        [Key]
        public int IdCombine { get; set; }

        [Required]
        public int IdStyle { get; set; }

        public int IdSize { get; set; }

        public int IdLength { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? CostStyle { get; set; } = 0; //0 = Default value

        [Column(TypeName = "decimal(18,4)")]
        public decimal? CostTakeDown { get; set; } = 0;

        [Column(TypeName = "decimal(18,4)")]
        public decimal? CostTouchUp { get; set; } = 0;

        [Column(TypeName = "decimal(18,4)")]
        public decimal? CostHairDeduct { get; set; } = 0;

        [Column(TypeName = "decimal(18,4)")]
        public decimal? CostStyleBusyTime { get; set; } = 0;

        public int IdCompany { get; set; }
        //public StyleLibrary? Style { get; set; }
        //public SizeLibrary? Size { get; set; }
        //public LengthLibrary? Length { get; set; }
    }
}
