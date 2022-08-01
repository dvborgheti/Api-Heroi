using EFcore.WebAPI.Data;
using EFcore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFcore.WebAPI.Services
{
    public class HeroiServices : IHeroiServices
    {
        private readonly DataContext _context;

        public HeroiServices(DataContext context)
        {
            _context = context; 
        }

        public async Task<List<Heroi>> Get()
        {
            try
            {
                var list = await _context.Herois.ToListAsync();
                return list;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Heroi> Get(int id)
        {
            try
            {
                var obj = await _context.Herois.FirstAsync(x => x.Id == id);
                return obj;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Heroi> Post(Heroi heroi)
        {
            _context.Herois.Add(heroi);
            await _context.SaveChangesAsync();

            return heroi;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var obj = await _context.Herois.FirstAsync(x => x.Id == id);
                _context.Herois.Remove(obj);
                var response = await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
