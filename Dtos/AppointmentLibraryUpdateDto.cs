using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingLibrary.DTOs
{
    public class AppointmentLibraryUpdateDto
    {
        public DateTime? DateAppoint { get; set; }

        public bool AddTakeOffAppoint { get; set; }

        public char StateAppoint { get; set; }

        public char Typeservice { get; set; }

        public int? NumberTrack { get; set; }

        public int? IDBraiderAppoint { get; set; }

        public int? IdBraiderOwner { get; set; }

        public int IDClientAppoint { get; set; }

        //Style
        public int IDStyleAppoint { get; set; }

        //Length
        public int IDLenghtAppoint { get; set; }

        //Size
        public int IdSizeAppoint { get; set; }
    }
}
