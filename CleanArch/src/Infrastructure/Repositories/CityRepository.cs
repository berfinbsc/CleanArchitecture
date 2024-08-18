using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CityRepository : IRepository<City>
    {
        private readonly ApplicationDbContext _context;

        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<City> GetAsync(int id)
        {
            return await _context.Cities.FindAsync(id);
        }

        public async Task<IEnumerable<City>> GetAllAsync()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> AddAsync(City entity)
        {
            await _context.Cities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<City> UpdateAsync(City entity)
        {
            _context.Cities.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<City> DeleteAsync(int id)
        {
            var entity = await _context.Cities.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _context.Cities.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }


    }
}