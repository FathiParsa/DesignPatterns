using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternSample
{
    public class RealFileDownloader : IFileDownloader
    {
        public void DownloadFile(string url)
        {
            Console.WriteLine($"Downloading File From {url}");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Download Completed.");
        }
    }
}
