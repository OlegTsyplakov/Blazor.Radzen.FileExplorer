using Radzen;

namespace B.Models
{
    public class DrivesInfoModel
    {
        public IEnumerable<DriveInfo> DrivesInfo { get; set; }
        public NotificationMessage NotificationMessage { get; set; }
    }
}
