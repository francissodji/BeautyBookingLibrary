using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Models
{
    public class StyleLibrary
    {
        [Key]
        public int IdStyle { get; set; }

        [Required]
        [MaxLength(200)]
        public string? TitleStyle { get; set; }

        [MaxLength(3000)]
        public string? DescriptStyle { get; set; }

        public bool isHairProvided { get; set; } = false;

        
        [MaxLength(1000)]
        public string? PictureStyle { get; set; }
       
        public int IdCompany { get; set; }


        //Navigation Property

        //public ICollection<Combine>? Combines { get; set; }

        //To Appointment
        //public List<AppointmentLibrary>? Appointments { get; set; }
    }
}
