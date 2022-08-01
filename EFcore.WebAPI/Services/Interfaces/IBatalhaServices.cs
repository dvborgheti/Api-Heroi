using EFcore.WebAPI.Data;
using EFcore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFcore.WebAPI.Services
{
    public interface IBatalhaServices
    {
        Task<List<Batalha>> Get();
        Task<Batalha> Get(int id);
        Task<Batalha> Post(Batalha batalha);
        Task<bool> Delete(int id);

    }
}
