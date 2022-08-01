using EFcore.WebAPI.Data;
using EFcore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFcore.WebAPI.Services
{
    public interface IHeroiServices
    {
        Task<List<Heroi>> Get();
        Task<Heroi> Get(int id);
        Task<Heroi> Post(Heroi heroi);
        Task<bool> Delete(int id);

    }
}
