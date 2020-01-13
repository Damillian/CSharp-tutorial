using System;

namespace HelloWorld
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("Notifying user that file {0} is downloaded...", e.File.Title);
        }
    }
}
