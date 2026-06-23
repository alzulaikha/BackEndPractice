using FlightManagementSystem.Models;
using System.Numerics;

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
            Console.WriteLine("Select your choice: ");
   


        }
        static void Main(string[] args)
        {

            mainMenu();
            bool exit = false;
            while (exit == false)
            {
                mainMenu();
                Console.WriteLine("Enter your choice: _");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
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
