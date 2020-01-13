using System.Collections;
using System.IO;

namespace HelloWorld
{


    class Program
    {

        static void Main(string[] args)
        {
            var file = new File() { Title = "File 1" };
            var downloadHelper = new DownloadHelper();
            var unpackService = new UnpackService();
            var notificationService = new NotificationService();
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += notificationService.OnFileDownloaded;

            downloadHelper.Download(file);
        }

    }
}
