using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllbyCategoryId(int id);
        List<Product> GetAllbyUnitPrice(decimal min, decimal max);

        List<ProductDetailDto> GetProductDetails();

        Product GetbyId(int productId);
        IResult Add(Product product);
    }
}
