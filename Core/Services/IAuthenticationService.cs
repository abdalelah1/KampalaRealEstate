namespace Kampala_Real_Estate.Core.Services
{
    public interface IAuthenticationService
    {
        Task<string> RegisterAsync(string name, string email, string password);  // تسجيل مستخدم جديد
        Task<string> LoginAsync(string email, string password);  // تسجيل الدخول
        Task<bool> ValidateTokenAsync(string token);  // التحقق من صلاحية التوكن
    }
}
