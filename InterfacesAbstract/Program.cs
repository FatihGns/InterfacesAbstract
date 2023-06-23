using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesAbstract.Abstract;
using InterfacesAbstract.Concrete;
using InterfacesAbstract.Entities;

namespace InterfacesAbstract
{
     class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000,11,3), FirstName = "Fatih", LastName = "Güneş", NationalityId = "1111111111" });
            Console.ReadLine();
        }
        
    }
}
