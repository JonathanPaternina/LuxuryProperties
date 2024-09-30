using LuxuryProperties.Shared;

namespace LuxuryProperties.API.Repository.IRepository
{
    public interface IPropertyRepository
    {
        ICollection<Property> GetProperties();
        Property GetPropertyById(int propertyId);
        IEnumerable<Property> GetPropertyByName(string name);
        Property GetPropertyByCodeInternal(int codeInternal);
        IEnumerable<Property> GetPropertyByYear(int year);
        IEnumerable<Property> GetPropertyByIdOwner(int idOwner);
        bool CreateProperty(Property property);
        bool ChangePriceProperty(Property property);
        bool UpdateProperty(Property property);         
        bool DeleteProperty(Property property);
    }
}
