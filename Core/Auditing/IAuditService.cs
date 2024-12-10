namespace Kampala_Real_Estate.Core.Auditing
{
    public interface IAuditService
    {
        Task LogActionAsync(string action, string userId, DateTime timestamp);
    }
}
