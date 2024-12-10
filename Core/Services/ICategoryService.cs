using Kampala_Real_Estate.Core.Entities;

namespace Kampala_Real_Estate.Core.Services
{
    public interface ICategoryService
    {
        Task<Category> AddCategoryAsync(Category category);  // إضافة تصنيف جديد
        Task UpdateCategoryAsync(Category category);  // تحديث تصنيف
        Task DeleteCategoryAsync(int categoryId);  // حذف تصنيف
        Task<IEnumerable<Category>> GetAllCategoriesAsync();  // جلب جميع التصنيفات
    }
}
