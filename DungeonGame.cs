namespace ConsoleApp1
{
    internal class DungeonGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начинается бой!");
            int HPP = 10, HPM = 20;

            while (HPP >= 0 || HPM >= 0 )
            {
                Random rnd = new Random();
                int a = rnd.Next(1, 3);

                Console.WriteLine("ХП игрока:"+ HPP + " ХП монстра:" + HPM);
                Console.WriteLine("Лечиться(1) или Атаковать!(2)");
                char action = Convert.ToChar(Console.ReadLine());

                switch (action)
                {
                    case '1':
                    {
                        int HPPN = HPP;
                        HPP = HPP + rnd.Next(3, 6);
                        Console.WriteLine("Вы вылечились на: "+ (HPP - HPPN));
                        Thread.Sleep(500);
                    }
                        break;
                    case '2':
                    {
                        int HPMN = HPM;
                        HPM = HPM - rnd.Next(9, 11);
                        Console.WriteLine("Вы атаковали и нанесли урон равный: "+ (HPMN - HPM));
                        Thread.Sleep(500);
                    }
                        break;
                }
                
                if (a == 1)
                {
                    int HPMN = HPM;
                    HPM = HPM + rnd.Next(6, 8);
                    Console.WriteLine("Монстр вылечился на: "+ (HPM - HPMN));
                    Thread.Sleep(500);
                }
                else 
                {
                    int HPPN = HPP;
                    HPP = HPM - rnd.Next(4, 6);
                    Console.WriteLine("Монстр атаковал вас и вы получили урон: "+ (HPPN - HPP));
                    Thread.Sleep(500);
                }

                if (HPM <= 0 && HPP <= 0)
                {
                    Console.WriteLine("Ничья");
                    continue;  
                }
                else if (HPM <= 0)
                {
                    Console.WriteLine("Победа!");
                    continue;
                }
                else if (HPP <= 0)
                {
                    Console.WriteLine("Поражение!");
                    continue;
                }
                
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
