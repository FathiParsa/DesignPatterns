using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPatternSample
{
    public class CircleFactory
    {
        private static Dictionary<string, Circle> _circleMap = new Dictionary<string, Circle>();

        public static Circle GetCircle(string color)
        {
            Circle circle = null;

            if (_circleMap.ContainsKey(color))
            {
                circle = _circleMap[color];
            }
            else
            {
                circle = new Circle(color);
                _circleMap[color] = circle;
                Console.WriteLine($"Creating Circle of Collor {color}");
            }
            return circle;
        }
    }
}
