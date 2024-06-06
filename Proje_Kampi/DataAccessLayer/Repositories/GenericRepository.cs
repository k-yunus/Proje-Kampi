using DataAccessLayer.Abstact;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{

    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        //Context context = new();
        // Veri tabani baglanti bunuda kullanabilirsin

        public async void Delete(T t)
        {
            using var context = new Context();
            context.Remove(t);
            await context.SaveChangesAsync();
        }

        public T GetByID(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var context = new Context();
            return context.Set<T>().ToList();  
        }

        public async void Insert(T t)
        {
            using var context = new Context();
            context.Add(t);
            await context.SaveChangesAsync();
        }

        public async void Update(T t)
        {
            using var context = new Context();
            context.Update(t);
            await context.SaveChangesAsync();
        }
    }
}
