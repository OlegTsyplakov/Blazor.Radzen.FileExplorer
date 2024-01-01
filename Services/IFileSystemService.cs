using B.Models;
using Radzen;

namespace B.Services
{
    public interface IFileSystemService
    {
        Task<DrivesInfoModel> GetDrivesAsync();
        Task<RootDrivesInfoModel> GetRootDirectoriesAsync(IEnumerable<DriveInfo> drives);
        Task<NotificationMessage> CreateDirectoryAsync(string path);
        Task<NotificationMessage> DeleteDirectoryAsync(string path);
    }
}