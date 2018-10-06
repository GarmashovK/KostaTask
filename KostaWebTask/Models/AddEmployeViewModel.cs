using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KostaWebTask.Models {
    public class AddEmployeViewModel {
        [Display(Name ="FirstName")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required]
        public string LastName { get; set; }

        [Display(Name ="Patronymic")]
        public string Patronymic { get; set; }

        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
    }
}