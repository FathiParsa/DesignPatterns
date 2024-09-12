using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribeDesignPatternSample
{
    public class Publisher
    {
        public event EventHandler<string> DataPublished;

        public void Publish(string data)
        {
            Console.WriteLine($"Publisher : Publishing data '{data}'...");
            OnDataPublished(data);
        }

        protected virtual void OnDataPublished(string data)
        {
            DataPublished?.Invoke(this, data);
        }
    }
}
