using LuxuryProperties.API.Repository.IRepository;
using LuxuryProperties.Data;
using LuxuryProperties.Shared;

namespace LuxuryProperties.API.Repository
{
    public class PropertyRepository(LuxuryPropertyContext db) : IPropertyRepository
    {
        private readonly LuxuryPropertyContext _db = db;

        public bool ChangePriceProperty(Property property)
        {
            _db.Property.Update(property);
            return _db.SaveChanges() >= 0;
        }

        public bool CreateProperty(Property property)
        {
            _db.Property.Add(property);
            return _db.SaveChanges() >= 0;
        }

        public bool DeleteProperty(Property property)
        {
            _db.Property.Remove(property);
            return _db.SaveChanges() >= 0;
        }

        public ICollection<Property> GetProperties()
        {
            return _db.Property.ToList();
        }

        public Property GetPropertyByCodeInternal(int codeInternal)
        {
            return _db.Property.FirstOrDefault(c => c.CodeInternal == codeInternal);
        }

        public Property GetPropertyById(int propertyId)
        {
            return _db.Property.FirstOrDefault(c => c.IdProperty == propertyId);
        }

        public IEnumerable<Property> GetPropertyByIdOwner(int idOwner)
        {
            var propertyByIdOwner = _db.Property.Where(p => p.IdOwner == idOwner).ToList();
            return propertyByIdOwner;
        }

        public IEnumerable<Property> GetPropertyByName(string name)
        {
            var propertyByName = _db.Property.Where(p => p.Name.ToLower().Trim() == name.ToLower().Trim()).ToList();
            return propertyByName;
        }

        public IEnumerable<Property> GetPropertyByYear(int year)
        {
            var propertyByYear = _db.Property.Where(p => p.Year == year);
            return propertyByYear;
        }

        public bool UpdateProperty(Property property)
        {
            _db.Property.Update(property);
            return _db.SaveChanges() >= 0;
        }
    }
}
