using InterfacesAbstract.Abstract;
using InterfacesAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstract.Concrete
{
    public class StarBucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;


        public StarBucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not valid person");
            }
        }
    }
}
