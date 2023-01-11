using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Models
{
    public class AppointmentLibrary
    {
        [Key]
        public int IdAppoint { get; set; }

        [Required]
        public DateTime? DateAppoint { get; set; }

        public bool AddTakeOffAppoint { get; set; }

        [MaxLength(1)]
        public string? StateAppoint { get; set; }

        [MaxLength(1)]
        public string? Typeservice { get; set; }

        public int? NumberTrack { get; set; }

        public int? IdBraiderAppoint { get; set; }


        public int? IdOwner { get; set; }


        //navigation

        //Client
        public int IdClientAppoint { get; set; }

        //Style
        public int IdStyleAppoint { get; set; }


        //Length
        public int IdLenghtAppoint { get; set; }


        //Size
        public int IdSizeAppoint { get; set; }

        public int IdCompany { get; set; }

    }
}
