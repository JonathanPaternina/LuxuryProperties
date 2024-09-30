using LuxuryProperties.API.Repository.IRepository;
using LuxuryProperties.Data;
using LuxuryProperties.Shared;

namespace LuxuryProperties.API.Repository
{
    public class OwnerRepository(LuxuryPropertyContext db) : IOwnerRepository
    {
        private readonly LuxuryPropertyContext _db = db;

        public ICollection<Owner> GetOwners()
        {
            return _db.Owner.ToList();
        }

        public Owner GetOwner(int ownerId)
        {
            return _db.Owner.FirstOrDefault(c => c.IdOwner == ownerId);
        }

        public bool CreateOwner(Owner owner)
        {
            _db.Owner.Add(owner);
            return _db.SaveChanges() >= 0;
        }

        public bool DeleteOwner(Owner owner)
        {
            _db.Owner.Remove(owner);
            return _db.SaveChanges() >= 0;
        }
        
    }
}
