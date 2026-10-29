namespace dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.WriteLine("Тема кладбище");

            Cemetery cemetery = new Cemetery("Центральное кладбище", "Главная улица");

            Grave grave = new Grave("Иванов Иван", "Участок 1", 2020, 2.5, true);

            FamilyGrave familyGrave = new FamilyGrave("Петров Пётр", "Участок 2", 2018, 4, 2);

            cemetery.AddBurial(grave);
            cemetery.AddBurial(familyGrave);

            Console.WriteLine("Информация о кладбище:");
            cemetery.PrintInfo();

            Console.WriteLine("Список захоронений:");
            cemetery.Print();

            Console.WriteLine("Поиск захоронения");
            Console.Write("Введите номер захоронения: ");
            int number = Input();

            BurialPlace? found = cemetery.Number(number);

            if (found != null)
            {
                found.PrintInfo();
            }
            else
            {
                Console.WriteLine("Захоронение не найдено");
            }

            Console.WriteLine("Обслуживание всех захоронений:");
            cemetery.MaintainAll();

            Console.WriteLine($"Общая стоимость ухода: {cemetery.Cost()}");
        }

        static int Input()
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                return n;
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            return 0;
        }

    }
}