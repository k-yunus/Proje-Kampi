using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstact
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        //List<Category> listAllCategory();
        //void AddCategory(Category category); // Void geriye deger dondurmuyor
        //void DeleteCategory(Category category);
        //void UpdateCategory(Category category);
        //Category GetById(int id);

        // Bunlar zaten IGeneric' de var ondan siliyoruz
        // Sonra yukaridaki gibi IGenericDal dan miras alacak ve
        //entitye gore olacak

    }
}
