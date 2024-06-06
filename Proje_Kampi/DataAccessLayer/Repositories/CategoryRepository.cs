using DataAccessLayer.Abstact;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {


        Context context = new();


        public async void AddCategory(Category category)
        {
            await context.AddAsync(category);
            await context.SaveChangesAsync();
        }

        public async void DeleteCategory(Category category)
        {
            context.Remove(category);
            await context.SaveChangesAsync();
        }

        public Category GetById(int id)
        {
            return context.Categories.Find(id);

        }

        public List<Category> listAllCategory()
        {

            return context.Categories.ToList();

        }

        public async void UpdateCategory(Category category)
        {
            context.Update(category);
            await context.SaveChangesAsync();
        }
    }
}
