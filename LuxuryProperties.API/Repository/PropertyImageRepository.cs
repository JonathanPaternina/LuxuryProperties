using LuxuryProperties.API.Repository.IRepository;
using LuxuryProperties.Data;
using LuxuryProperties.Shared;

namespace LuxuryProperties.API.Repository
{
    public class PropertyImageRepository(LuxuryPropertyContext db) : IPropertyImageRepository
    {
        private readonly LuxuryPropertyContext _db = db;

        public bool AddImageProperty(PropertyImage propertyImage)
        {
            _db.PropertyImage.Add(propertyImage);
            return _db.SaveChanges() >= 0;
        }

        public bool DisableOthersImageProperty()
        {
            var image = _db.PropertyImage.ToList();
            foreach (var item in image)
            {
                item.Enabled = false;
            }
            return _db.SaveChanges() >= 0;
        }
    }
}
