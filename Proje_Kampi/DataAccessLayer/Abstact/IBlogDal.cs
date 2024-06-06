using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstact
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        //List<Blog> LisAllBlog();
        //void AddBlog(Blog blog); // Void geriye deger dondurmuyor
        //void DeleteBlog(Blog blog);
        //void UpdateBlog(Blog blog);
        //Blog GetById(int id);

        // Bunlar zaten IGeneric' de var ondan siliyoruz
    }
}
