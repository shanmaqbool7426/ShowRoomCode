using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoomCode
{
    class Program
    {


        static void Main(string[] args)
        {
            showRoom c1 = new showRoom();
            c1.AddCar();
            Console.ReadLine();

        }
    }
    public class AutoCar
    {
        public int RegistrationNumber { get; set; }
        public int Modle { get; set; }
        public float FuelCapecity { get; set; }
        public AutoCar(int registration, int modle, float fuelcapecity)
        {
            this.RegistrationNumber = registration;
            this.Modle = modle;
            this.FuelCapecity = fuelcapecity;
        }
    }
    public class ElectricCar : AutoCar
    {
        public int ElectricCapecity { get; set; }
        public ElectricCar(int registration, int modle, float fuelcapecity, int electricCapecity) : base(registration, modle, fuelcapecity)
        {
            ElectricCapecity = electricCapecity;
        }
    }

    public class showRoom
    {
        public AutoCar[] cars = new AutoCar[40];
        public void AddCar()
        {
            int PlaceAtCar = indexAtInsert();
            Console.WriteLine("enter a car and Details");
            Console.WriteLine("Registration Number of a car!!");
            int registration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Modle of a car!!");
            int modle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fuel Capecity of a car!!");
            float fuelcapecity = float.Parse(Console.ReadLine());
            cars[PlaceAtCar] = new AutoCar(registration, modle, fuelcapecity);
        }
        public void SearchCar()
        {
            Console.WriteLine("Enter a Registration Number for search a car!!");
            int Search = Convert.ToInt32(Console.ReadLine());
            int carfind = FindACarAtindex(Search);
            if (carfind == -1)
            {
                Console.WriteLine("car is not found!");
            }
            else
            {
                Console.WriteLine(" car is found " + cars[carfind]);
            }
        }
        public void DeleteCar()
        {
            Console.WriteLine("enter a car  search to delete");
            int SearchforDelete = Convert.ToInt32(Console.ReadLine());
            int indexFind = FindACarAtindex(SearchforDelete);
            if (indexFind == -1)
            {
                Console.WriteLine("car is not found for delete....");
            }
            else
            {

                cars[indexFind] = null;
                Console.WriteLine("car is remove");
            }
        }
        public int FindACarAtindex(int SearchRegistrationNunmber)
        {
            int index = -1;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].RegistrationNumber == SearchRegistrationNunmber)
                {
                    return index = i;

                }

            }
            return index;
        }
        public int indexAtInsert()
        {
            int index = -1;
            for (int i = 0; i <= cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }

        //code is complated
    }

}
