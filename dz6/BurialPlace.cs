namespace dz6
{
    abstract class BurialPlace
    {
        private static int _lastNumber = 0;

        private int _number;
        private string _name;
        private string _location;
        private int _year;
        private bool _maintained;

        public int Number
        {
            get { return _number; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public bool Maintained
        {
            get { return _maintained; }
            set { _maintained = value; }
        }

        public BurialPlace(string name, string location, int year)
        {
            _lastNumber++;
            _number = _lastNumber;
            _name = name;
            _location = location;
            _year = year;
            _maintained = false;
        }

        public abstract string Description();

        public abstract decimal CalculateCost();

        public void Maintain()
        {
            _maintained = true;
            Console.WriteLine("Уход за местом захоронения выполнен");
        }

        public void ChangeLocation(string location)
        {
            this._location = location;
        }

        public void ChangeYear(int year)
        {
            this._year = year;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Номер: {_number}");
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Местоположение: {_location}");
            Console.WriteLine($"Год захоронения: {_year}");
            Console.WriteLine($"Уход выполнен: {(_maintained ? "Да" : "Нет")}");
            Console.WriteLine($"Тип: {Description()}");
            Console.WriteLine($"Расчётная стоимость ухода: {CalculateCost()}");
        }
    }
}
