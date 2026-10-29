namespace tumakov
{
    public class BankAccount
    {
        private static int _nextNumber = 1;
        private int _accountNumber;
        private decimal _balance;
        private string _accountType;

        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public string AccountType
        {
            get { return _accountType; }
        }

        public BankAccount()
        {
            _accountNumber = GenerateNumber();
            _balance = 0;
            _accountType = "Обычный";
        }

        public BankAccount(decimal balance, string accountType, int number)
        {
            _balance = balance;
            _accountType = accountType;
            _accountNumber = number;

            if (number >= _nextNumber)
            {
                _nextNumber = number + 1;
            }
        }

        public BankAccount(decimal balance, string accountType)
        {
            _accountNumber = GenerateNumber();
            _balance = balance;
            _accountType = accountType;
        }

        public static int GenerateNumber()
        {
            return _nextNumber++;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма должна быть положительной");
                return;
            }
            _balance += amount;
        }

        public void Withdrawal(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма должна быть положительной");
                return;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Недотаточно средств");
                return;
            }
            _balance -= amount;
        }

        public void Print()
        {
            Console.WriteLine($"Номер счета: {_accountNumber}");
            Console.WriteLine($"Баланс: {_balance}");
            Console.WriteLine($"Тип счёта: {_accountType}");
        }
    }
}
