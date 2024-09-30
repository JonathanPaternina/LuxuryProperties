using LuxuryProperties.Shared;

namespace LuxuryProperties.API.Repository.IRepository
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();

        Owner GetOwner(int OwnerId);

        bool CreateOwner(Owner owner);

        bool DeleteOwner(Owner owner);
    }
}
