namespace ConsoleApp1
{
    internal class DungeonGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начинается бой!");
            
            Random rnd = new Random();
            int HPP = 10, HPM = 20;
            int a = rnd.Next(1, 2);
            
            while (HPP >= 0 || HPM >= 0 )
            {
                //ХП монстра: ХП игрока
                //Лечиться Атаковать!
                //Победа! Поражение!
                Console.WriteLine("ХП игрока:"+ HPP + " ХП монстра:" + HPM);
                Console.WriteLine("Лечиться(1) или Атаковать!(2)");
                char action = Convert.ToChar(Console.ReadLine());

                switch (action)
                {
                    case '1':
                    {
                        int HPPN = HPP;
                        HPP = HPP + rnd.Next(3, 6);
                        Console.WriteLine("You hills on: "+ (HPP - HPPN));
                        Thread.Sleep(500);
                    }
                        break;
                    case '2':
                    {
                        int HPMN = HPM;
                        HPM = HPM - rnd.Next(9, 11);
                        Console.WriteLine("You attacked on: "+ (HPMN - HPM));
                        Thread.Sleep(500);
                    }
                        break;
                }
                
                if (a == 1)
                {
                    int HPMN = HPM;
                    HPM = HPM + rnd.Next(6, 8);
                    Console.WriteLine("Monster hills on: "+ (HPM - HPMN));
                    Thread.Sleep(500);
                }
                else if (a == 2)
                {
                    int HPPN = HPP;
                    HPP = HPM - rnd.Next(4, 6);
                    Console.WriteLine("Monster attacked you on: "+ (HPPN - HPP));
                    Thread.Sleep(500);
                }

                Thread.Sleep(2000);
                Console.Clear();
            }

            if (HPP <= 0)
            {
                Console.WriteLine("Победа!");
            }
            else if (HPP <= 0)
            {
                Console.WriteLine("Поражение!");
            }
        }
    }
}