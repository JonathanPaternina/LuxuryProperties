using LuxuryProperties.Shared;

namespace LuxuryProperties.API.Repository.IRepository
{
    public interface IPropertyImageRepository
    {
        bool AddImageProperty(PropertyImage propertyImage);
        bool DisableOthersImageProperty(); 
    }
}
