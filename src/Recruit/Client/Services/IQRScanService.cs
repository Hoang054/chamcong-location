using Recruit.Shared.ViewModels;

namespace Recruit.Client.Services
{
    public interface IQRScanService
    {
        Task<string> createQRCode();
        Task<int> changeStatus(Double PsnPrkID, int TrangThai);
    }
}
