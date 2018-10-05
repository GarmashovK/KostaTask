using EmployeHost.Data;
using EmployeServiceLib;
using EmployeServiceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeHost {
    public class EmployeHostService : IEmployeService {
        private EmployeDbContext _db = new EmployeDbContext();

        public IEnumerable<Employe> GetEmployees(string firstName, string lastName, string patronymic) {
            var result = _db.Employees
                .Where(e => e.FirstName == firstName &&
                    e.LastName == lastName && e.Patronymic == patronymic).ToList();
            return result;
        }

        public void SetEmploye(Employe newEmploye) {
            if (newEmploye.FirstName != null && newEmploye.LastName != null && newEmploye.BirthDay != null) {
                var res = _db.Employees.Add(newEmploye);
                _db.SaveChanges();
                Console.WriteLine("Emlploye {0} {1} {2} that was born {3}", res.LastName, res.FirstName, res.Patronymic, res.BirthDay.ToString("dd.mm.yyyy"));
            } else throw new ApplicationException("FirstName, LastName or Birthday are incorrect!");
        }
    }
}
