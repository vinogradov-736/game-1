namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя?");
            string name = Console.ReadLine();
            bool openDoor = false;
            bool isKey = false;
            int o1 = 1;
            int o2 = 2;
            int o3 = 3;
            int tr = 0;
            Console.WriteLine("Вы находитесь в комнате.");
            Console.WriteLine("Чтобы открыть дверь наружу вам надо найти три артефакта, которые активируют статую имеющую ключ от двери.\n");
            while (isKey == false)
            {
                Console.WriteLine("Вы можете: 1.Открыть шкаф 2.Посмотреть под столом 3.Поискать в матрасе 4.Посмотреть под потолком 5.Активировать статую");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    if (o1 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли артефакт");
                        o1 = 0;
                        tr++;
                    }

                }
                if (choice == 2)
                {

                    if (o2 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли артефакт");
                        o2 = 0;
                        tr++;
                    }
                }
                if (choice == 3)
                {

                    if (o3 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли артефакт");
                        o3 = 0;
                        tr++;
                    }
                }
                if (choice == 4)
                {
                    Console.WriteLine("Здесь пусто. Попробуй поискать в другом месте :)");
                }
                if (choice == 5)
                {
                    if (tr == 3)
                    {
                        Console.WriteLine("Статую была активирована.\nВы получили ключ от двери...");
                        isKey = true;
                    }
                    else
                    {
                        Console.WriteLine("Найдите все артифакты");
                    }
                }
            }

            Console.WriteLine("\nПоздравляю!!! Вы выбрались из непонятной комнаты " + name);
            Console.ReadKey();
        }

    }
}