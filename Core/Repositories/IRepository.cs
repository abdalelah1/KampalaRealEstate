namespace Kampala_Real_Estate.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();  // جلب جميع العناصر
        Task<T> GetByIdAsync(int id);       // جلب عنصر حسب المعرف
        Task AddAsync(T entity);            // إضافة عنصر جديد
        Task UpdateAsync(T entity);         // تحديث عنصر موجود
        Task DeleteAsync(int id);           // حذف عنصر حسب المعرف
    }
}
