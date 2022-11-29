using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_N_Post.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
        T GetById(object id);
        IEnumerable<T> GetAll();
    }
}
