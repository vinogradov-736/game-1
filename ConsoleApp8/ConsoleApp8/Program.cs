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
            int try2push = 1;
            int o1 = 1;
            int o2 = 2;
            int o3 = 3;
            int o4 = 4;
            int tr = 0;//артефакт
            Console.WriteLine("Вы находитесь в комнате.");
            Console.WriteLine("Чтобы открыть дверь наружу вам надо найти три артефакта, которые активируют статую имеющую ключ от двери.\n");
            while (isKey == false)
            {
                Console.WriteLine("Вы можете: 1.Открыть шкаф 2.Посмотреть под столом 3.Поискать в матрасе 4.Открыть ящик 5.Посмотреть под потолком 6.Активировать статую");
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
                    if (o4 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        if (try2push == 3)
                        {
                            Console.WriteLine("Вы нашли артефакт");
                            o4 = 0;
                            tr++;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает сил, попробуйте ещё раз");
                            try2push++;
                        }
                    }
                }
                if (choice == 5)
                {
                    Console.WriteLine("Здесь пусто. Попробуй поискать в другом месте :)");
                }
                if (choice == 6)
                {
                    if (tr == 4)
                    {
                        Console.WriteLine("Статуя была активирована.\nВы получили ключ от двери...");
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
