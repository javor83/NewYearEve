using NewYearEve.Models;

namespace NewYearEve.Interfaces
{
    public interface IRepositoryGuestResponse
    {
        IEnumerable<GuestResponse> Get();

        void Insert(GuestResponse guest);

    }
}
