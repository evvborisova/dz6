using tumakov;

namespace dz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task71();
            Task72();
            Task73();
            Task74();
        }

        //Упражнение 7.1
        static void Task71()
        {
            Console.WriteLine("Упражнение 7.1");

            Console.Write("Введите начальный баланс счёта: ");
            decimal balance = Decimal();

            Console.Write("Введите тип счёта: ");
            string type = Console.ReadLine()!;

            Console.Write("Введите номер счёта: ");
            int number = Input();

            BankAccount account = new BankAccount(balance, type, number);

            Console.Write("Введите сумму пополнения: ");
            decimal amount = Decimal();

            account.Deposit(amount);

            account.Print();
        }

        //Упражнение 7.2
        static void Task72()
        {
            Console.WriteLine("Упражнение 7.2");

            Console.Write("Введите начальный баланс счёта: ");
            decimal balance = Decimal();

            Console.Write("Введите тип счёта: ");
            string type = Console.ReadLine()!;

            BankAccount account = new BankAccount(balance, type);

            account.Print();
        }

        //Упражнене 7.3

        static void Task73()
        {
            Console.WriteLine("Упражнене 7.3");

            Console.Write("Введите баланс счёта: ");
            decimal balance = Decimal();

            Console.Write("Введите тип счёта: ");
            string type = Console.ReadLine()!;

            BankAccount account = new BankAccount(balance, type);

            Console.Write("Введите сумму пополнения счёта: ");
            decimal deposit = Decimal();

            account.Deposit(deposit);

            Console.Write("Введите сумму снятия счёта: ");
            decimal withdrawal = Decimal();

            account.Withdrawal(withdrawal);

            Console.WriteLine("Cчёт:");
            account.Print();
        }

        //Домашнее задание 7.1

        static void Task74()
        {
            Console.WriteLine("Домашнее задание 7.1");

            Console.Write("Введите высоту здания: ");
            double height = Double();

            Console.Write("Введите количество этажей: ");
            int floors = Input();

            Console.Write("Введите количество квартир: ");
            int apartments = Input();

            Console.Write("Введите количество подъездов: ");
            int entrances = Input();

            Building building = new Building(height, floors, apartments, entrances);

            building.Print();
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

        static double Double()
        {
            if (double.TryParse(Console.ReadLine(), out double n))
            {
                return n;
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            return 0;
        }

        static decimal Decimal()
        {
            if (decimal.TryParse(Console.ReadLine(), out decimal n))
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
