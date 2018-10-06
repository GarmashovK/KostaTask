using System;
using System.Linq;
using System.ServiceModel;
using EmployeServiceLib;
using EmployeServiceLib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceTestsProject {
    [TestClass]
    public class WCFTests {
        private IEmployeService channel;

        public WCFTests() {
            var address = new Uri("http://localhost:4400/EmployeService.svc");

            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(address);

            ChannelFactory<IEmployeService> factory = new ChannelFactory<IEmployeService>(binding, endpoint);
            channel = factory.CreateChannel(); 
        }

        [TestMethod]
        public void WCFSuccessAddition() {
            var newEmploye = new Employe() {
                FirstName = "Константин",
                LastName = "Гармашов",
                Patronymic = "Сергеевич",
                BirthDay = new DateTime(1995,1, 5)
            };
            var newEmploye2 = new Employe() {
                FirstName = "Иван",
                LastName = "Сидоров",
                Patronymic = "Петрович",
                BirthDay = new DateTime(1997, 6, 25)
            };

            channel.SetEmploye(newEmploye);
            channel.SetEmploye(newEmploye2);
            var result = channel.GetEmployees("Константин", "Гармашов", "Сергеевич");

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() >= 1);

        }
    }
}
