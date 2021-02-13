using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer); // Herkes bu operasyonu kullanmak zorunda. yani tüm kişiler sisteme kayıtlanacak.

    }
}
