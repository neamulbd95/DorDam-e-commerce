using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DorDam_ENTITY
{
    public class User_Info
    {
        public int Id { get; set; }
        [Required]
        public string User_name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z ]*$")]
        public string User_Full_name { get; set; }
        public string User_Email { get; set; }
        [RegularExpression(@"^[0-9]+$")]
        [StringLength(11,MinimumLength=11)]
        public string User_Mobile { get; set; }
        public string User_Gender { get; set; }
        public DateTime User_DateOfBirth { get; set; }

    }
}
