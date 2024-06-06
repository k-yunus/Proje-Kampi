using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategorDelete(Category category);
        void CategorUpdate(Category category);
        List<Category> GetList();
        Category GetById(int id);
    }
}
