using Blog_N_Post.Abstract;
using Blog_N_Post.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_N_Post.Implementation
{
    public class BlogPostRepository<T> : IRepository<T> where T : class
    {
        private readonly BlogPostContext _context;
        private readonly DbSet<T> table;

        public BlogPostRepository()
        {
            this._context = new BlogPostContext();
            table = _context.Set<T>();
        }
        public BlogPostRepository(BlogPostContext context, DbSet<T> table)
        {
            _context = context;
            this.table = table;
        }

        public void Add(T item)
        {
            table.Add(item);
        }

        public void Delete(int id)
        {
            T findId = table.Find(id);
            if (findId == null)
            {
                return;
            }
            table.Remove(findId);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            table.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
