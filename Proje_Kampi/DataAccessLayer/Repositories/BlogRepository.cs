using DataAccessLayer.Abstact;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {

        public async void AddBlog(Blog blog)
        {
            using var context = new Context();
            await context.AddAsync(blog);
            await context.SaveChangesAsync();
        }

        public async void DeleteBlog(Blog blog)
        {
            using var context = new Context();
            context.Remove(blog);
            await context.SaveChangesAsync();
        }

        public  Blog GetById(int id)
        {
            using var context = new Context();
            return context.Blogs.Find(id);

        }

        public List<Blog> LisAllBlog()
        {
            using var context = new Context();
            return context.Blogs.ToList();
        }

        public async void UpdateBlog(Blog blog)
        {
            using var context = new Context();
            context.Update(blog);
            await context.SaveChangesAsync();
        }
    }
}
