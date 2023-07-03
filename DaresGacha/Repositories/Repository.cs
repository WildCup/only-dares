using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DaresGacha.Data;
using Microsoft.EntityFrameworkCore;

namespace DaresGacha.Services
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        protected readonly DataContext _context;

        public Repository(DataContext context, IMapper mapper)
        {
            _context = context;
        }


        public async Task<int> Add(Base entity)
        {
            _context.Set<T>().Add((T)entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task Delete(int id)
        {
            var entity = await Get(id);
            if (entity == null) return;

            _context.Set<T>().Remove((T)entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T?> Get(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Update(Base entity)
        {
            _context.Set<T>().Update((T)entity);
            await _context.SaveChangesAsync();
        }
    }
}