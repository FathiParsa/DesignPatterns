namespace ProxyDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileDownloader fileDownloader = new FileDownloaderProxy();

            fileDownloader.DownloadFile("https://example.com/file1.txt");
            fileDownloader.DownloadFile("https://example.com/file1.txt");
            fileDownloader.DownloadFile("https://example.com/file2.txt");
        }
    }
}
