using BusinesLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class CategoryManeger : ICategoryService
    {

        EfCategoryRepository efCategoryRepository;

        public CategoryManeger()
        {
            efCategoryRepository = new EfCategoryRepository();
        }


        public void CategorDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategorUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
        }
            
        public Category GetById(int id)
        {
            return efCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
