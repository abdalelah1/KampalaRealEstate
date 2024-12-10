using Kampala_Real_Estate.Core.Entities;

namespace Kampala_Real_Estate.Core.Services
{
    public interface IPropertyService
    {
        Task<Property> AddPropertyAsync(Property property);  // إضافة عقار جديد
        Task UpdatePropertyAsync(Property property);  // تعديل عقار
        Task DeletePropertyAsync(int propertyId);  // حذف عقار
        Task<IEnumerable<Property>> GetPropertiesByFiltersAsync(string location, decimal? minPrice, decimal? maxPrice);  // جلب العقارات باستخدام الفلاتر
        Task<bool> IsPropertyAvailableAsync(int propertyId);  // التحقق من توفر العقار
    }
}
