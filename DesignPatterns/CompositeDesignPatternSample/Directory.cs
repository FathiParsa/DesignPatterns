using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternSample
{
    public class Directory : FileSystemItem
    {

        private List<FileSystemItem> _items = new  List<FileSystemItem>();
        public Directory(string name) : base(name) { }

        public void Add(FileSystemItem item)
        {
            _items.Add(item);
        }

        public void Remove(FileSystemItem item) 
        {
            _items.Remove(item);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);

            foreach (var item in _items)
            {
                item.Display(depth + 2);
            }
        }
    }
}
