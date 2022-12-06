namespace DPFlyweightProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 20;
            double y = 30;

            HouseFactory factory = new();
            House house = null;
            for(int i = 0; i < 10; i++)
            {
                Random rand = new();
                switch(rand.Next(2))
                {
                    case 0: house = factory.GetHouse("panel"); break;
                    case 1: house = factory.GetHouse("brick"); break;
                    default:
                        break;
                }
                if(house is not null)
                    house.Build(x, y);
                x += rand.Next(-10, 10);
                y += rand.Next(-10, 10);
            }
        }
    }
}