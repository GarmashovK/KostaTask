using EmployeServiceLib.Models;
using System.Data.Entity;

namespace EmployeHost.Data {
    public class EmployeDbContext : DbContext {
        public DbSet<Employe> Employees { get; set; }

        public EmployeDbContext() : base("EmployeConnection") {

        }
    }
}
