using NUnitUsingDotNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitUsingDotNet
{
    public class ShoppingCart
    {
        private readonly IProductRepository _productRepository;

        public ShoppingCart(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }

        public string AddItem(int productId) 
        {
            var product = _productRepository.GetProductById(productId);

            if (product == null) 
            {
                return "Product not found.";
            }

            return $"Added {product.Name}";
        }
    }
}
