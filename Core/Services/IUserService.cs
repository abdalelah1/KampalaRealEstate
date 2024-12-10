using Kampala_Real_Estate.Core.Entities;

namespace Kampala_Real_Estate.Core.Services
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(User user);  // إنشاء مستخدم جديد
        Task<User> GetUserByIdAsync(int id);  // جلب مستخدم حسب معرفه
        Task<bool> IsEmailTakenAsync(string email);  // التحقق من استخدام البريد الإلكتروني
        Task UpdateUserProfileAsync(User user);  // تحديث بيانات المستخدم
        Task DeactivateUserAsync(int userId);  // تعطيل حساب مستخدم
    }
}
