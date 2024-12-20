namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя?");
            string name = Console.ReadLine();
            bool isKey = false;
            int tryAgain = 1;
            int o1 = 1;
            int o2 = 2;
            int o3 = 3;
            int o4 = 4;
            int art = 0;//артефакт
            Console.WriteLine("Вы находитесь в закулисах.");
            Console.WriteLine("Чтобы открыть дверь наружу вам надо найти три артефакта, которые активируют статую имеющую ключ от двери.\n");
            while (isKey == false)
            {
                Console.WriteLine("Вы можете: \n1.Открыть шкаф \n2.Посмотреть под столом \n3.Поискать в матрасе \n4.Открыть ящик \n5.Посмотреть под потолком \n6.Активировать статую");
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
                        art++;
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
                        art++;
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
                        art++;
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
                        if (tryAgain == 3)
                        {
                            Console.WriteLine("Вы нашли артефакт");
                            o4 = 0;
                            art++;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает сил, попробуйте ещё раз");
                            tryAgain++;
                        }
                    }
                }
                if (choice == 5)
                {
                    Console.WriteLine("Здесь пусто. Попробуй поискать в другом месте :)");
                }
                if (choice == 6)
                {
                    if (art == 4)
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

            Console.WriteLine("\nПоздравляю!!! Вы выбрались из закулис " + name);
            Console.ReadKey();
        }

    }
}