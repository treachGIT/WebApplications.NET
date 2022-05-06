using LataPrzestepneIdentity.Dto;
using LataPrzestepneIdentity.Models;
using LataPrzestepneIdentity.Repositories;

namespace LataPrzestepneIdentity.Services
{
    public class BirthdayService : IBirthdayService
    {
        private readonly IBirthdayRepository _birthdayRepository;
        public BirthdayService(IBirthdayRepository birthdayRepository)
        {
            _birthdayRepository = birthdayRepository;
        }
        public void AddEntry(Birthday bithday)
        {
            _birthdayRepository.Add(bithday);
        }

        public void DeleteEntry(Birthday bithday)
        {
            _birthdayRepository.Delete(bithday);
        }

        public List<BirthdayDto> GetAllEntries()
        {
            var birthdays = _birthdayRepository.GetAllBirthdays().OrderByDescending(x => x.CreatedDate);
            List<BirthdayDto> result = new List<BirthdayDto>();

            foreach (var birthday in birthdays)
            {
                var record = new BirthdayDto()
                {
                    Id = birthday.Id,
                    Year = birthday.Year,
                    FullName = birthday.Name + " " + birthday.Surname,
                    CreatedDate = birthday.CreatedDate,
                    ResultMessage = birthday.GetMessageForHistory(),
                    UserId = birthday.UserId
                };

                result.Add(record);
            }

            return result;
        }

        public List<BirthdayDto> GetEntriesFromToday()
        {
            var birthdays = _birthdayRepository.GetAllBirthdays().Where(b => b.CreatedDate >= DateTime.Today).OrderByDescending(x => x.CreatedDate);
            List<BirthdayDto> result = new List<BirthdayDto>();

            foreach (var birthday in birthdays)
            {
                var record = new BirthdayDto()
                {
                    Id = birthday.Id,
                    Year = birthday.Year,
                    FullName = birthday.Name + " " + birthday.Surname,
                    CreatedDate = birthday.CreatedDate,
                    ResultMessage = birthday.GetMessageForHistory(),
                    UserId = birthday.UserId
                };

                result.Add(record);
            }

            return result;
        }
    }
}
