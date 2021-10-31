using System;
using System.Collections.Generic;
using System.Text;

namespace DescriptionBuilding_1
{
    class BuildingParameters
    {
        private double height;          // Высота здания
        private int floors;             // Этажность здания
        private int numberOfApartments; // Количество квартир
        private int numberOfEntrances;  // Количество подъездов
        private int id;                 // Уникальный номер здания
        private static int lastId;      // Последний номер здания


        public BuildingParameters()
        {

        }

        public BuildingParameters(
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


        public int LastId()
        {
            return lastId = id;
        }

        public int Id(int lastId)
        {
            return ++lastId;
        }

        public double Height(double height)
        {
            this.height = height;
            return height;
        }

        public int Floors(int floors)
        {
            this.floors = floors;
            return floors;
        }

        public int NumberOfApartments(int numberOfApartments)
        {
            this.numberOfApartments = numberOfApartments;
            return numberOfApartments;
        }

        public int NumberOfEntrances(int numberOfEntrances)
        {
            this.numberOfEntrances = numberOfEntrances;
            return numberOfEntrances;
        }

        public double HeightFloor(int floors, double height)
        {
            var heightFloor = height / floors;
            return heightFloor;
        }

        public int NumberApartmentsInEntrance(int numberOfApartments, int numberOfEntrances)
        {
            var numberApartmentsInEntrance = numberOfApartments / numberOfEntrances;
            return numberApartmentsInEntrance;
        }

        public int NumberApartmentsInFloor(int numberOfApartments, int numberOfEntrances, int floors)
        {
            var numberApartmentsInFloor = numberOfApartments / numberOfEntrances / floors;
            return numberApartmentsInFloor;
        }
    }
}
