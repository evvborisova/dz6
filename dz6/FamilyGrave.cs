using System.Numerics;

namespace dz6
{
    class FamilyGrave : BurialPlace 
    {
        private int _places;
        private int _occupiedPlaces;

        public int Places
        {
            get { return _places; }
            set { _places = value; }
        }

        public int OccupiedPlaces
        {
            get { return _occupiedPlaces; }
            set { _occupiedPlaces = value; }
        }

        public FamilyGrave(string name, string location, int year) : base(name, location, year)
        {
            _places = 4;
            _occupiedPlaces = 1;
        }

        public FamilyGrave(string name, string location, int year, int places, int occupiedPlaces) : base(name, location, year)
        {
            _places = places;
            _occupiedPlaces = occupiedPlaces;
        }

        public override string Description()
        {
            return "Семейное захоронение";
        }

        public override decimal CalculateCost()
        {
            return _places * 1000m;
        }

        public void AddBurial()
        {
            if (_occupiedPlaces < _places)
            {
                _occupiedPlaces++;
                Console.WriteLine("Захоронение добавлено");
            }
            else
            {
                Console.WriteLine("Свободных мест нет");
            }
        }

        public int FreePlaces()
        {
            return _places - _occupiedPlaces;
        }

        public void ChangePlaces(int places)
        {
            if (places >= _occupiedPlaces)
            {
                _places = places;
            }
            else
            {
                Console.WriteLine("Нельзя указать мест меньше, чем занято");
            }
        }

        public void PrintFamilyInfo()
        {
            PrintInfo();
            Console.WriteLine($"Всего мест: {_places}");
            Console.WriteLine($"Занято мест: {_occupiedPlaces}");
            Console.WriteLine($"Свободно мест: {FreePlaces}");
        }
    }
}
