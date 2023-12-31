using B.Models;
using Radzen;


namespace B.Services
{

    public  class FileSystemService: IFileSystemService
    {


        public  Task<DrivesInfoModel> GetDrivesAsync()
        {
            DrivesInfoModel drivesInfoModel = new ();
            try
            {
                drivesInfoModel.DrivesInfo = DriveInfo.GetDrives().Where(x => x.IsReady);
                drivesInfoModel.NotificationMessage = new NotificationMessage()
                {
                    Severity = NotificationSeverity.Info,
                    Summary = "Drives:",
                    Detail = "loaded successfully"
                };
                return Task.FromResult(drivesInfoModel);
            }
            catch (Exception ex)
            {
                drivesInfoModel.DrivesInfo = new List<DriveInfo>();
                drivesInfoModel.NotificationMessage = new NotificationMessage() {
                    Severity = NotificationSeverity.Error,
                    Summary = "Drives error:",
                    Detail = ex.Message
                };
                return Task.FromResult(drivesInfoModel);
            }
        }

        public  Task<RootDrivesInfoModel> GetRootDirectoriesAsync(IEnumerable<DriveInfo> drives)
        {
            RootDrivesInfoModel rootDrivesInfoModel = new ();
            try
            {
                rootDrivesInfoModel.RootDrivesInfo = drives.Select(x => x.RootDirectory.FullName);
                rootDrivesInfoModel.NotificationMessage = new NotificationMessage()
                {
                    Severity = NotificationSeverity.Info,
                    Summary = "Root Drives:",
                    Detail = "loaded successfully"
                };
                return Task.FromResult(rootDrivesInfoModel);
            }
            catch (Exception ex)
            {

                rootDrivesInfoModel.RootDrivesInfo = new List<string>();
                rootDrivesInfoModel.NotificationMessage = new NotificationMessage()
                {
                    Severity = NotificationSeverity.Error,
                    Summary = "Root Drives error:",
                    Detail = ex.Message
                };
                return Task.FromResult(rootDrivesInfoModel);
            }

        }
        public Task<NotificationMessage> CreateDirectory(string path)
        {
            NotificationMessage message = new ();
            try
            {
                if (Directory.Exists(path))
                {
                    message.Severity = NotificationSeverity.Info;
                    message.Summary = "Directory creation:";
                    message.Detail = "Directory is already exists.";
                }

                DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
                message.Severity = NotificationSeverity.Info;
                message.Summary = "Directory creation:";
                message.Detail = $"Directory {directoryInfo.Name} created";
            }
            catch(Exception ex) {

                message.Severity = NotificationSeverity.Error;
                message.Summary = "Can't create directory:";
                message.Detail = ex.Message;
            }
           
            return Task.FromResult(message);
        }
        public Task<NotificationMessage> DeleteDirectory(string path)
        {
            NotificationMessage message = new();
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path);
                    DirectoryInfo directoryInfo = new (path);
                    message.Severity = NotificationSeverity.Info;
                    message.Summary = "Directory delelete:";
                    message.Detail = "Directory is deleted.";
                 
                    return Task.FromResult(message);
                }
                message.Severity = NotificationSeverity.Info;
                message.Summary = "Directory delelete:";
                message.Detail = $"Directory {path} does't exists.";
                return Task.FromResult(message);
            }
            catch (Exception ex)
            {
                message.Severity = NotificationSeverity.Error;
                message.Summary = "Can't delete directory:";
                message.Detail = ex.Message;
            }
            return Task.FromResult(message);
        }

    }
}