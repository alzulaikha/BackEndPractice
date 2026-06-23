using FlightManagementSystem.Models;
using System.Numerics;
using System.Reflection;

namespace FlightManagementSystem
{
    public class Program
    {
     
        //system storage ( actual storage in memory for all lists ) 
            public static FlightContext context = new FlightContext
            {
                Passengers = new List<Passenger>(),
                Pilots = new List<Pilot>(),
                Bookings = new List<Booking>(),
                Aircraft = new List<Aircraft>(),
                Flights = new List<Flight>(),
            };
        //Main menu function
         public static void mainMenu()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("===  Flight Management System Services ===");
            Console.WriteLine("==========================================");
            Console.WriteLine("01 Register a Passenger");
            Console.WriteLine("02 Add an Aircraft");
            Console.WriteLine("03 Register a Pilot");
            Console.WriteLine("04 View All Flights");
            Console.WriteLine("05 Schedule a Flight");
            Console.WriteLine("06 Book a Flight");
            Console.WriteLine("07 Cancel a Booking");
            Console.WriteLine("08 Depart a Flight");
            Console.WriteLine("09 Cancel a Flight");
            Console.WriteLine("10 Passenger Booking History");
            Console.WriteLine("11 Flight Revenue & Load Factor Report");
            Console.WriteLine("0 Exit");
            Console.WriteLine("==========================================");
            
   


        }
        //Register a Passenger function
        public static void RegisterPassenger()
        {
            Console.WriteLine("\n=== Register New Passenger ===");

            int passengerId = context.Passengers.Count + 1;

            Console.Write("Enter passenger name: ");
            string name = Console.ReadLine();

            Console.Write("Enter passenger email : ");
            string email = Console.ReadLine();

            Console.Write("Enter passenger phone : ");
            string phoneNum = Console.ReadLine();

            Console.Write("Enter passport number : ");
            string passNum = Console.ReadLine();

            bool result = context.Passengers.Any(p => p.passportNumber == passNum);

            if (result)
            {
                Console.WriteLine("Passenger passport number already exit, please enter another passport number ");
                return;

            }
          
            Console.Write("Enter passenger nationality : ");
            string nationality = Console.ReadLine();

            context.Passengers.Add(
                new Passenger
                {
                    passengerId = passengerId,
                    passengerName = name,
                    passengerEmail = email,
                    passengerPhone = phoneNum,
                    passportNumber = passNum,
                    nationality = nationality

                }

                );

            Console.WriteLine($"Passenger registered successfully. Assigned ID: {passengerId}");

        }
        public static void AddAircraft()
        {
            Console.WriteLine("\n=== Register New Aircraft ===");

            int aircraftId = context.Aircraft.Count + 1;

            Console.Write("Enter aircraft model  / e.g. Boeing 737, Airbus A320/: ");
            Console.WriteLine();
            string model = Console.ReadLine();

            Console.Write("Enter total seats : ");
            int total = int.Parse(Console.ReadLine());

            context.Aircraft.Add(new Aircraft
            {
                aircraftId = aircraftId,
                model = model,
                totalSeats = total,
                isOperational = true
            });

            Console.WriteLine($"Aircraft registered successfully. Assigned ID: {aircraftId}");


        }
        static void Main(string[] args)
        {
           

            bool exit = false;
            while (exit == false)
            {
                mainMenu();
                Console.WriteLine("Enter your choice: _");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegisterPassenger(); //Register a Passenger
                        break;
                    case 2:
                        AddAircraft();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 0:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("invalid option please try again");
                        break;




                }//switch closed 

                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }// while closed
                
            }
        }
}
