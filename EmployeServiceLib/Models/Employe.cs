using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeServiceLib.Models {
    public class Employe {
        public int ID { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string Patronymic { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
    }
}
