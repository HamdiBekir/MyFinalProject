
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _CategoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //İş Kodları
            return _CategoryDal.GetAll();
        }

        public Category GetbyId(int categoryId)
        {
            return _CategoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
