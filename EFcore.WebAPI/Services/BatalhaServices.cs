using EFcore.WebAPI.Data;
using EFcore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFcore.WebAPI.Services
{
    public class BatalhaServices : IBatalhaServices
    {
        private readonly DataContext _context;

        public BatalhaServices(DataContext context)
        {
            _context = context; 
        }

        public async Task<List<Batalha>> Get()
        {
            try
            {
                var list = await _context.Batalhas.ToListAsync();
                return list;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Batalha> Get(int id)
        {
            try
            {
                var obj = await _context.Batalhas.FirstAsync(x => x.Id == id);
                return obj;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Batalha> Post(Batalha batalha)
        {
            _context.Batalhas.Add(batalha);
            await _context.SaveChangesAsync();

            return batalha;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var obj = await _context.Batalhas.FirstAsync(x => x.Id == id);
                _context.Batalhas.Remove(obj);
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
