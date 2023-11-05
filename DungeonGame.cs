namespace ConsoleApp1
{
    internal class DungeonGame
    {
        static void Main()
        {
            Console.WriteLine("Начинается бой!");
            int hpp = 10, hpm = 20;

            while (true)
            {
                Random rnd = new Random();
                int a = rnd.Next(1, 3);

                Console.WriteLine("ХП игрока:"+ hpp + " ХП монстра:" + hpm);
                Console.WriteLine("Лечиться(h) или Атаковать!(a)");
                char action = Convert.ToChar(Console.ReadLine());

                switch (action)
                {
                    case 'h':
                    {
                        int hppn = hpp;
                        hpp = hpp + rnd.Next(3, 6);
                        Console.WriteLine("Вы вылечились на: "+ (hpp - hppn));
                        Thread.Sleep(500);
                    }
                        break;
                    case 'a':
                    {
                        int hpmn = hpm;
                        hpm = hpm - rnd.Next(9, 11);
                        Console.WriteLine("Вы атаковали и нанесли урон равный: "+ (hpmn - hpm));
                        Thread.Sleep(500);
                    }
                        break;
                    default:
                        Console.WriteLine("Ты подскользнулся и сломал шею!");
                        return;
                }
                
                if (a == 1)
                {
                    int hpmn = hpm;
                    hpm = hpm + rnd.Next(6, 8);
                    Console.WriteLine("Монстр вылечился на: "+ (hpm - hpmn));
                    Thread.Sleep(500);
                }
                else 
                {
                    int hppn = hpp;
                    hpp = hpp - rnd.Next(4, 6);
                    Console.WriteLine("Монстр атаковал вас и вы получили урон: "+ (hppn - hpp));
                    Thread.Sleep(500);
                }

                if (hpm <= 0 && hpp <= 0)
                {
                    Console.WriteLine("Ничья");
                    break;  
                }
                
                if (hpm <= 0)
                {
                    Console.WriteLine("Победа!");
                    break;
                }
                
                if (hpp <= 0)
                {
                    Console.WriteLine("Поражение!");
                    break;
                }
                
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
