using NUnitUsingDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitUsingDotNet.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int id);

        bool SaveProduct(Product product);
    }
}
