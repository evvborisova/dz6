namespace dz6
{
    class Grave : BurialPlace
    {
        private double _area;
        private bool _monument;

        public double Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public bool Monument
        {
            get { return _monument; }
            set {  _monument = value; }
        }

        public Grave(string name, string location, int year) : base(name, location, year)
        {
            _area = 2;
            _monument = false;
        }

        public Grave(string name, string location, int year, double area, bool monument) : base(name, location, year)
        {
            _area = area;
            _monument = monument;
        }

        public override string Description()
        {
            return "Обычные могилы";
        }

        public override decimal CalculateCost()
        {
            decimal cost = (decimal)_area * 500;

            if (_monument)
            {
                cost += 1000;
            }
            return cost;
        }

        public void InstallMonument()
        {
            _monument = true;
            Console.WriteLine("Памятник установлен");
        }

        public void RemoveMonument()
        {
            _monument = false;
            Console.WriteLine("Памятник отсутсвует");
        }

        public void ChangeArea(double area)
        {
            _area = area;
        }

        public void Print()
        {
            PrintInfo();
            Console.WriteLine($"Площадь: {_area} м²");
            Console.WriteLine($"Памятник: {(_monument ? "Есть" : "Нет")}");
        }
    }
}
