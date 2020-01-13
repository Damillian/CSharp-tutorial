using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HelloWorld
{
    class DownloadHelper
    {
        public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);

        public event FileDownloadedEventHandler FileDownloaded;

        protected virtual void OnFileDownloaded(File file)
        {
            if (FileDownloaded!= null)
            {
                FileDownloaded(this, new FileEventArgs(){ File = file});
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);

            OnFileDownloaded(file);
        }
    }
}
