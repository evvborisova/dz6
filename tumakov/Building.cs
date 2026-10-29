namespace tumakov
{
    class Building
    {
        private static int lastNumber = 0;
        private int number;
        private double height;
        private int floors;
        private int apartments;
        private int entrances;

        public Building(double height, int floors, int apartments, int entrances)
        {
            lastNumber++;
            number = lastNumber;

            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

        public int Number()
        {
            return number;
        }

        public double Height()
        {
            return height;
        }

        public int Floors()
        {
            return floors;
        }

        public int Apartments()
        {
            return apartments;
        }

        public int Entrances()
        {
            return entrances;
        }

        public void Height(double height)
        {
            this.height = height;
        }

        public void Floors(int floors)
        {
            this.floors = floors;
        }

        public void Apartments(int apartments)
        {
            this.apartments = apartments;
        }

        public void Entrances(int entrances)
        {
            this.entrances = entrances;
        }

        public double FloorHeight()
        {
            return height / floors;
        }

        public int ApartmentsPerEntrance()
        {
            return apartments / entrances;
        }

        public int ApartmentsPerFloor()
        {
            return apartments / floors;
        }

        public void Print()
        {
            Console.WriteLine($"Номер здания: {number}");
            Console.WriteLine($"Высота здания: {height} м");
            Console.WriteLine($"Количество этажей: {floors}");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: {FloorHeight()} м");
            Console.WriteLine($"Квартир в подъезде: {ApartmentsPerEntrance()}");
            Console.WriteLine($"Квартир на этаже: {ApartmentsPerFloor()}");
        }
    }
}
