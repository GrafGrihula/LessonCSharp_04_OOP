using System;

namespace DescriptionBuilding_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildingParameters buildingParameters = new BuildingParameters();
            buildingParameters.LastId();
            Console.WriteLine(
                $" Номер здания - \t\t{buildingParameters.Id(0)}\r\n" +
                $" Высота здания - \t\t{buildingParameters.Height(100.54)}\r\n" +
                $" Этажность здания - \t\t{buildingParameters.Floors(5)};\r\n" +
                $" Количество квартир - \t\t{buildingParameters.NumberOfApartments(300)}\r\n" +
                $" Количество подъездов - \t{buildingParameters.NumberOfEntrances(7)}");
            Console.WriteLine();
            Console.WriteLine(
                $" Номер здания - \t\t{buildingParameters.Id(1)}\r\n" +
                $" Высота здания - \t\t{buildingParameters.Height(125.32)}\r\n" +
                $" Этажность здания - \t\t{buildingParameters.Floors(10)};\r\n" +
                $" Количество квартир - \t\t{buildingParameters.NumberOfApartments(1700)}\r\n" +
                $" Количество подъездов - \t{buildingParameters.NumberOfEntrances(8)}");
        }
    }
}
