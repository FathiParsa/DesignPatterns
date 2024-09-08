using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternSample
{
    public abstract class FileSystemItem
    {
        public string Name { get;private set; }

        protected FileSystemItem(string name)
        {
            this.Name = name;
        }
        public abstract void Display(int depth);
    }
}
