using Kampala_Real_Estate.Core.Entities;

namespace Kampala_Real_Estate.Core.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();  // جلب جميع المستخدمين
        Task ApprovePropertyAsync(int propertyId);  // الموافقة على عقار
        Task RejectPropertyAsync(int propertyId);  // رفض عقار
    }
}
