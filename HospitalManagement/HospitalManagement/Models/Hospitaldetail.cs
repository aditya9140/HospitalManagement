using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Hospitaldetail
    {
        public int HospitalId { get; set; }

        [Required]
        public string HospitalName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phoneno { get; set; }

        [Required]
        public string Mobileno { get; set; }

        [Required]
        public string Website { get; set; }
    }
}