using CleanArchProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchProject.Domain.Interfaces
{
    public interface IproductRepository
    {
        IEnumerable<Product> GetAll();
        Product get(int id);
        void Add(Product product);
        //bool add(Product product);
        void Edit(Product product);

        void Delete(Product product);

        bool Delete(int id);

        void DeleteAll();

    }
}
