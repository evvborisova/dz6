namespace dz6
{
    class Cemetery
    {
        private string _name;
        private string _address;
        private List<BurialPlace> _places;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Count
        {
            get { return _places.Count; }
        }

        public List<BurialPlace> Places
        {
            get { return _places; }
        }

        public Cemetery(string name, string address)
        {
            _name = name;
            _address = address;
            _places = new List<BurialPlace>();
        }

        public void AddBurial(BurialPlace place)
        {
            _places.Add(place);
            Console.WriteLine("Захоронение добавлено в список");
        }

        public void Print()
        {
            foreach (BurialPlace place in _places)
            {
                Console.WriteLine();
                place.PrintInfo();
            }
        }

        public BurialPlace? Number(int number)
        {
            foreach (BurialPlace place in _places)
            {
                if (place.Number == number)
                {
                    return place;
                }
            }

            return null;
        }

        public decimal Cost()
        {
            decimal total = 0;

            foreach (BurialPlace place in _places)
            {
                total += place.CalculateCost();
            }

            return total;
        }

        public void MaintainAll()
        {
            foreach (BurialPlace place in _places)
            {
                place.Maintain();
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Название кладбища: {_name}");
            Console.WriteLine($"Адрес: {_address}");
            Console.WriteLine($"Количество захоронений: {Count}");
            Console.WriteLine($"Общая расчётная стоимость ухода: {Cost()}");
        }
    }
}
