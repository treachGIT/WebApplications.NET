using LataPrzestepneIdentity.Dto;
using LataPrzestepneIdentity.Models;

namespace LataPrzestepneIdentity.Services
{
    public interface IBirthdayService
    {
        void AddEntry(Birthday bithday);
        void DeleteEntry(Birthday bithday);
        List<BirthdayDto> GetAllEntries();
        List<BirthdayDto> GetEntriesFromToday();
    }
}
