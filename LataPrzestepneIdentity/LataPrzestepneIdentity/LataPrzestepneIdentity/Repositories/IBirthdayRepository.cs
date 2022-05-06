using LataPrzestepneIdentity.Models;

namespace LataPrzestepneIdentity.Repositories
{
    public interface IBirthdayRepository
    {
        void Add(Birthday birthday);
        void Delete(Birthday birthday);
        IQueryable<Birthday> GetAllBirthdays();

    }
}
