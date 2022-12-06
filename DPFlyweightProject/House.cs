using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFlyweightProject
{
    abstract class House
    {
        protected int stages;
        public abstract void Build(double x, double y);
    }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            stages = 9;
        }

        public override void Build(double x, double y)
        {
            Console.WriteLine($"Panel House building on x:{x}, y:{y}");
        }
    }

    class BrickHouse : House
    {
        public BrickHouse()
        {
            stages = 5;
        }

        public override void Build(double x, double y)
        {
            Console.WriteLine($"Brick House building on x:{x}, y:{y}");
        }
    }

    class HouseFactory
    {
        Dictionary<string, House> housesPool = new();
        public HouseFactory()
        {

        }

        public House GetHouse(string key)
        {
            House house = null;
            if (!housesPool.ContainsKey(key))
            {  
                switch (key)
                {
                    case "panel": 
                        house = new PanelHouse();
                        Console.WriteLine("Panel House Construct");
                        break;
                    case "brick": 
                        house = new BrickHouse();
                        Console.WriteLine("Brick House Construct");
                        break;
                    default:
                        break;
                } 
                housesPool.Add(key, house);
            }

            return housesPool[key];
        }
    }
}
