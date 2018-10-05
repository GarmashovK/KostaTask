using EmployeServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeHost {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Employees Server";

            var address = new Uri("http://localhost:4400/EmployeService.svc");
            var binding = new BasicHttpBinding();
            var contract = typeof(IEmployeService);
            try {
                var host = new ServiceHost(typeof(EmployeHostService));
                host.AddServiceEndpoint(contract, binding, address);
                host.Open();
                Console.WriteLine("Server has been started!");
                Console.WriteLine("Press any key to close the server!");
                Console.ReadKey();

                host.Close();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
