using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KostaWebTask.Models {
    public class GetEmployeViewModel {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirtDay { get; set; }
        public int Age { get; set; }
    }
}