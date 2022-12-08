using Accounting.ViewModels.Customers;
using System.Collections.Generic;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCusstomersByFilter(string parameter);
        List<ListCustomerViewModel> GetNameCustomers(string filter = "");
        Customers GetCustomerById(int customerId);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
        int GetCustomerIdByName(string name);
        string GetCustomerNameById(int customerId);
    }
}