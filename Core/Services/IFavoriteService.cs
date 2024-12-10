using Kampala_Real_Estate.Core.Entities;

namespace Kampala_Real_Estate.Core.Services
{
    public interface IFavoriteService
    {
        Task AddToFavoritesAsync(int userId, int propertyId);  // إضافة عقار للمفضلة
        Task RemoveFromFavoritesAsync(int userId, int propertyId);  // إزالة عقار من المفضلة
        Task<IEnumerable<Property>> GetFavoritesAsync(int userId);  // جلب قائمة المفضلة
    }
}
