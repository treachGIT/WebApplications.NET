using LataPrzestepne.Dto;
using LataPrzestepne.Models;

namespace LataPrzestepne.Services
{
    public interface IBirthdayService
    {
        void AddEntry(Birthday bithday);
        void DeleteEntry(Birthday bithday);
        List<BirthdayDto> GetAllEntries();
        List<BirthdayDto> GetEntriesFromToday();
    }
}
