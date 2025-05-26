using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;

namespace Services
{
    public class CabinetService<T> where T : class
    {
        private GenericRepository<T> _repo = new();
        //public BookService(DbdesignQlchBansachContext _context)
        //{
        //    _repo = new GenericRepository<T>(_context);
        //}

        public List<T> GetAll()
        {
            return _repo.GetAll();
        }
        public void Add(T item)
        {
            _repo.Add(item);
        }
        public void Remove(T item)
        {
            _repo.Delete(item);
        }
        public void Update(T item)
        {
            _repo.Update(item);
        }
    }
}
