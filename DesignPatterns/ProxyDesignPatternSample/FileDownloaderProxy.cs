using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternSample
{
    public class FileDownloaderProxy : IFileDownloader
    {
        private RealFileDownloader _realFileDownloader;
        private string _cachedUrl;

        public void DownloadFile(string url)
        {
            if (_realFileDownloader == null || _cachedUrl != url)
            {
                _realFileDownloader = new RealFileDownloader();
                _realFileDownloader.DownloadFile(url);
                _cachedUrl = url;
            }
            else 
            {
                Console.WriteLine($"Returning Chached File For {url}");
            }
        }
            

    }
}

