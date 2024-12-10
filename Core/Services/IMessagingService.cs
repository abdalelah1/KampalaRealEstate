using Kampala_Real_Estate.Core.Entities;

namespace Kampala_Real_Estate.Core.Services
{
    public interface IMessagingService
    {
        Task SendMessageAsync(Message message);  // إرسال رسالة
        Task<IEnumerable<Message>> GetMessagesBetweenUsersAsync(int senderId, int receiverId);  // جلب الرسائل بين المستخدمين
        Task<IEnumerable<Message>> GetUnreadMessagesAsync(int userId);  // جلب الرسائل غير المقروءة
    }
}
