
using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class AdvertRepository : IRepository<Advert>
    {
        private readonly ApplicationDbContext _context;

        public AdvertRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Advert> GetAsync(int id)
        {
            return await _context.Adverts.FindAsync(id);
        }

        public async Task<IEnumerable<Advert>> GetAllAsync()
        {
            return await _context.Adverts.ToListAsync();
        }

        public async Task<Advert> AddAsync(Advert entity)
        {
            await _context.Adverts.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Advert> UpdateAsync(Advert entity)
        {
            _context.Adverts.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Advert> DeleteAsync(int id)
        {
            var entity = await _context.Adverts.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _context.Adverts.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}