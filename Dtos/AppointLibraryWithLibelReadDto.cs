using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingLibrary.Dtos
{
    public class AppointLibraryWithLibelReadDto
    {
        public int IdAppoint { get; set; }

        public DateTime? DateAppoint { get; set; }

        public bool? AddTakeOffAppoint { get; set; }

        public char? StateAppoint { get; set; }

        public char? Typeservice { get; set; }

        public int? NumberTrack { get; set; }

        public int? IdBraiderAppoint { get; set; }

        public int? IdBraiderOwner { get; set; }

        public int? IdClientAppoint { get; set; }

        //public Client client { get; set; }

        //Style
        public int? IdStyleAppoint { get; set; }

        //Length
        public int IdLenghtAppoint { get; set; }

        //Size
        public int IdSizeAppoint { get; set; }

        public string? DesigStyle { get; set; }

        public string? TitleSize { get; set; }

        public string? TitleExtrat { get; set; }

        public string? ClientFullName { get; set; }

        public string? ServiceTitle { get; set; }
        public string TakeDownTitle { get; set; }

        public double TotalCostBraiding { get; set; }
    }
}
