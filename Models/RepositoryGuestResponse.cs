
using NewYearEve.Interfaces;

namespace NewYearEve.Models
{
    public class RepositoryGuestResponse : IRepositoryGuestResponse
    {
        private List<GuestResponse> data = null;

        public RepositoryGuestResponse()
        {
            this.data = new List<GuestResponse>();
        }

        IEnumerable<GuestResponse> IRepositoryGuestResponse.Get()
        {
            return data;
        }

        void IRepositoryGuestResponse.Insert(GuestResponse guest)
        {
           this.data.Add(guest);
        }
    }
}
