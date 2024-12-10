using Kampala_Real_Estate.Core.Entities;

namespace Kampala_Real_Estate.Core.Services
{
    public interface ISubscriptionService
    {
        Task<Subscription> AddSubscriptionAsync(Subscription subscription);  // إضافة اشتراك جديد
        Task<bool> IsSubscriptionActiveAsync(int userId);  // التحقق من صلاحية الاشتراك
        Task<decimal> CalculateSubscriptionCostAsync(string plan);  // حساب تكلفة الاشتراك
    }
}
