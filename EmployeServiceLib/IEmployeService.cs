using EmployeServiceLib.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace EmployeServiceLib {
    [ServiceContract]
    public interface IEmployeService {
        [OperationContract]
        [WebGet]
        IEnumerable<Employe> GetEmployees(string firstName, string lastName, string patronymic);

        [OperationContract]
        [WebInvoke]
        void SetEmploye(Employe newEmploye);
    }
}
