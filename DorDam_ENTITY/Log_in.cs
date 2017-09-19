using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DorDam_ENTITY
{
    public class Log_in
    {
        //[Key]
        public int Id { get; set; }
        
        public string User_Name { get; set; }
        public string Password { get; set; }
    }
}
