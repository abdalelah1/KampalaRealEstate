using Kampala_Real_Estate.Core.Entities;

namespace Kampala_Real_Estate.Core.Services
{
    public interface IPaymentService
    {
        Task<bool> ProcessPaymentAsync(Payment payment);  // معالجة الدفع
        Task<Payment> GetPaymentByIdAsync(int paymentId);  // جلب بيانات دفع معينة
        Task<IEnumerable<Payment>> GetPaymentHistoryAsync(int userId);  // عرض سجل المدفوعات
    }
}
