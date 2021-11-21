namespace DescriptionBuilding
{
    class ConcreteBuildB1 : IBuild
    {
        private double height;          // Высота здания
        private int floors;             // Этажность здания
        private int numberOfApartments; // Количество квартир
        private int numberOfEntrances;  // Количество подъездов
        private int id;                 // Уникальный номер здания

        private static int lastId;      // Последний номер здания

        public ConcreteBuildB1()
        {

        }

        public ConcreteBuildB1(
            double height,
            int floors,
            int numberOfApartments,
            int numberOfEntrances)
        {
            this.height = height;
            this.floors = floors;
            this.numberOfApartments = numberOfApartments;
            this.numberOfEntrances = numberOfEntrances;
        }

        public int Id
        {
            get { return this.LastId(); }
            set { this.id = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int Floors
        {
            get { return this.floors; }
            set { this.floors = value; }
        }
        public int NumberOfApartments
        {
            get { return this.numberOfApartments; }
            set { this.numberOfApartments = value; }
        }
        public int NumberOfEntrances
        {
            get { return this.numberOfEntrances; }
            set { this.numberOfEntrances = value; }
        }


        public int LastId()
        {
            return lastId = ++id;
        }


        public string Operation()
        {
            string result =
                $" Номер здания - \t\t{id};\r\n" +
                $" Высота здания - \t\t{height};\r\n" +
                $" Этажность здания - \t\t{floors};\r\n" +
                $" Количество квартир - \t\t{numberOfApartments};\r\n" +
                $" Количество подъездов - \t{numberOfEntrances}.";
            return result;
        }
    }
}