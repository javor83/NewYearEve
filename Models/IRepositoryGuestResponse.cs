namespace NewYearEve.Models
{
    public interface IRepositoryGuestResponse
    {
        IEnumerable<GuestResponse> Get();

        void Insert(GuestResponse guest);

    }
}
