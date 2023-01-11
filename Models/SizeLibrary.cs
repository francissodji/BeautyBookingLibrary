using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Models
{
    public class SizeLibrary
    {
        [Key]
        public int IdSize { get; set; }

        [MaxLength(100)]
        public string? TitleSize { get; set; }

        public bool IsDefault { get; set; }

        public int IdCompany { get; set; }

        //Navigation Property

        //public ICollection<CombineLibrary>? Combines { get; set; }

        //To Appointment
       // public List<AppointmentLibrary>? Appointments { get; set; }

    }
}
