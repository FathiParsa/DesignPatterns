using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPatternSample
{
    public class Circle
    {
        private string _color;
        private int _x;
        private int _y;
        private int _radius;
        public Circle(string color)
        {
                this._color = color;
        }
        public void SetX(int x) { _x = x; }
        public void SetY(int y) { _y = y; }
        public void SetRadius(int radius) { _radius = radius; }
        public void Draw()
        {
            Console.WriteLine($"Circle : Draw() [ Color: {_color} , X : {_x} , Y : {_y} , Radius : {_radius}]");
        }
    }
}
