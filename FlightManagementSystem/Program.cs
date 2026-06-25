using FlightManagementSystem.Models;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

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
            if (string.IsNullOrEmpty(name)) 
            { 
                Console.WriteLine("Name cannot be empty!");
                return;
            }


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
        //Add an Aircraft function
        public static void AddAircraft()
        {
            Console.WriteLine("\n=== Register New Aircraft ===");

            int aircraftId = context.Aircraft.Count + 1;

            Console.Write("Enter aircraft model  / e.g. Boeing 737, Airbus A320/: ");
            Console.WriteLine();
            string model = Console.ReadLine();

            Console.Write("Enter total seats : ");
            int total = int.Parse(Console.ReadLine());
            if(total<= 0)
            {
                Console.WriteLine("Total seats should be greater than zero!");
                return;
            }

            context.Aircraft.Add(new Aircraft
            {
                aircraftId = aircraftId,
                model = model,
                totalSeats = total,
                isOperational = true
            });

            Console.WriteLine($"Aircraft registered successfully. Assigned ID: {aircraftId}");


        }
        //Register a Pilot function
        public static void RegisterPilot()
        {
            Console.WriteLine("\n=== Register New Pilot ===");

            int pilotID = context.Pilots.Count + 1;

            Console.Write("Enter pilot name: ");
            string pName = Console.ReadLine();

            Console.Write("Enter pilot phone : ");
            string pPhone = Console.ReadLine();

            Console.Write("Enter pilot license number : ");
            string licenseNumber = Console.ReadLine();
            bool result1 = context.Pilots.Any(p => p.licenseNumber == licenseNumber);

            if (result1)
            {
                Console.WriteLine("Pilot licenseNumber already exit, please enter another passport number ");
                return;

            }

            Console.Write("Enter flight hours : ");
            int flightHours = int.Parse(Console.ReadLine());

            context.Pilots.Add(new Pilot
            {
                pilotId = pilotID,
                pilotName = pName,
                pilotPhone = pPhone,
                licenseNumber = licenseNumber,
                flightHours = flightHours,
                isAvailable = true
            });

            Console.WriteLine($"Pilot registered successfully. Assigned ID: {pilotID}");
        }
        //View All Flights function
        public static void ViewAllFlights()
        {
         
            Console.WriteLine("\n=== All Flights ===");
          
            if(context.Flights.Count == 0)
            {
                Console.WriteLine("No flight available");
                return;
            }
            foreach (Flight f in context.Flights)
            {
                Console.WriteLine($"Code: {f.flightCode}  |  Origin: {f.origin}  |  Destination: {f.destination}" +
                                  $"  |  Departure Date: {f.departureTime}  |  Ticket Price: {f.ticketPrice} + | Available Seats: { f.availableSeats}"+
           
                                  $"  |  Status: {f.status} |Flight Duration: {f.flightDuration} ");

            }
        }
        //Schedule a Flight
        public static void ScheduleFlight()
        {

            Console.WriteLine("\n=== Schedule Flights ===");

            //choose available aircraft 
            foreach (Aircraft a in context.Aircraft)
            {
                Console.WriteLine($"Aircraft ID: {a.aircraftId}  | Model  : {a.model} | TotalSeats : {a.totalSeats} ");
            }

            Console.WriteLine("Enter aircraft id: ");
            int aircraftId= int .Parse(Console.ReadLine());

            Aircraft aircraft = context.Aircraft.FirstOrDefault(a => a.aircraftId == aircraftId);
            if(aircraft == null) 
            {
                Console.WriteLine("Aircraft not found! ");
                return;
            }
            if (!aircraft.isOperational)
            {
                Console.WriteLine("Aircraft isn't operational!");
                return;
            }


            //choose  pilot
            foreach (Pilot p in context.Pilots)
            {
                Console.WriteLine($"Pilot ID: {p.pilotId}  | Pilot Name : {p.pilotName} ");
            }

            Console.WriteLine("Enter pilot id: ");
            int pilotId = int.Parse(Console.ReadLine());

            Pilot pilot = context.Pilots.FirstOrDefault(p => p.pilotId == pilotId);
            if (pilot == null)
            {
                Console.WriteLine("Pilot not found ");
            }

            Console.WriteLine("=== flight record ===");
            Console.WriteLine(" Departure airport / city : ");
            string origin= Console.ReadLine();
            Console.WriteLine(" Arrival airport / city : ");
            string destination= Console.ReadLine();
            Console.WriteLine(" Departure Date");
            string depDate = Console.ReadLine();
            Console.WriteLine(" Departure Time ");
            string depTime= Console.ReadLine();
            Console.WriteLine(" TicketPrice ");
            decimal price= decimal.Parse(Console.ReadLine());
            if (price <= 0)
            { 
               Console.WriteLine($"Invalid ticket price!");
            }
            Console.WriteLine("Flight Duration");
            string flightDuration= Console.ReadLine();

            int flightID = context.Flights.Count + 1; //flight id is generated automatically by the system.
            int flightCode= context.Flights.Count + 1; //flight code is generated automatically by the system.


            context.Flights.Add(
               new Flight
               {
                   flightId = flightID,
                   flightCode= "OA-"+ flightCode,
                   destination = destination,
                   departureDate = depDate,
                   departureTime = depTime,
                   ticketPrice = price,
                   availableSeats = aircraft.totalSeats,
                   flightDuration=flightDuration,
                   origin=origin,
                   status = "Scheduled"
               }

               );
            Console.WriteLine($"Schedule Flights successfully. Assigned ID: {flightID}");
        }
        //Book a Flight function
        public static void BookingFlight()
        {
     
            Console.WriteLine("=== Booking Flight === ");
       
            Console.WriteLine("Enter your id: ");

            int passId= int.Parse(Console.ReadLine());


            Passenger selectpassenger = context.Passengers.FirstOrDefault(p => p.passengerId == passId);
            if (selectpassenger == null)
            {
                Console.WriteLine("Passenger Id not found ");
            }
            Console.WriteLine("Enter your destination: ");
            string destination= Console.ReadLine();


            List<Flight> matched = context.Flights
                                  .Where(f => f.destination.ToLower() == destination &&
                                               f.status == "Scheduled" &&
                                               f.availableSeats > 0).ToList();

            foreach (var f in matched)
            {
                Console.WriteLine($" Flight ID: {f.flightId}  | destination: {f.destination} | Departure Date: {f.departureDate} | Departure Time: {f.departureTime}| ticketPrice: {f.ticketPrice} |status: {f.status}");
            }

            Console.Write("Enter flight ID: ");
            int flightid = int.Parse(Console.ReadLine());


            Flight selectflight = context.Flights.FirstOrDefault(f=> f.flightId == flightid);
            if (selectflight == null)
            {
                Console.WriteLine("Flight Id not found ");
            }

          

            context.Bookings.Add(
                new Booking
                {
                    bookingId = context.Bookings.Count + 1,
                    flightId = flightid,
                    passengerId =passId,
                    totalPrice=selectflight.ticketPrice,
                    status= "Confirmed",
                    bookingDate=DateTime.Now.ToShortDateString(),
                    seatNumber = "S"+selectflight.availableSeats,

                });
            selectflight.availableSeats--;

            Console.WriteLine($"Schedule Flights successfully.");



        }
        //Cancel a Booking function
        public static void CancelBooking() 
        {
        Console.WriteLine("Enter booking id:");
         int bookingid=int.Parse(Console.ReadLine());


          Booking selectbooking = context.Bookings.FirstOrDefault(b => b.bookingId == bookingid);
            if (selectbooking == null)
            {
                Console.WriteLine("Booking not found ");
            }
            if(selectbooking.status== "Cancelled")
            {
                Console.WriteLine("Booking already cancelled");
            }
            Flight selectflight = context.Flights.FirstOrDefault(f => f.flightId == selectbooking.flightId);
            selectbooking.status = "Cancelled";

            selectflight.availableSeats++;

            Console.WriteLine("Booking cancelled successfully");
        }
        // Depart a Flight function
        public static void DepartFlight()
        {

            Console.WriteLine("Enter flight id: ");
           int flightid= int.Parse(Console.ReadLine());

            Flight selectflight = context.Flights.FirstOrDefault(f => f.flightId == flightid);
            if (selectflight== null)
            {
                Console.WriteLine("flight not found ");
                return;
            }
            if(selectflight.status== "Cancelled")
            {
                Console.WriteLine("flight is cancelled  ");
                return;
            }

            selectflight.status = "Departed";

            Pilot pilot = context.Pilots.FirstOrDefault(p => p.pilotId == flightid);
            if (pilot != null)
            {
                Console.WriteLine("Enter flight hours  : ");
                int hours=int.Parse(Console.ReadLine());
                pilot.flightHours += hours;

            }

            Console.WriteLine("Depart Flight successfully");

        }
        // Cancel a Flight function
        public static void CancelFlight()
        {
            Console.WriteLine("Enter Flight id to Canceled: ");
            int flightid=int.Parse(Console.ReadLine());


            Flight selectflight = context.Flights.FirstOrDefault(f => f.flightId == flightid);
            if (selectflight == null)
            {
                Console.WriteLine("flight not found ");
                return;
            }
            

            selectflight.status = "Cancelled";
           var select=context.Bookings.Where(b=>b.flightId == flightid);
            int bookingCancel=select.Count();

            Pilot pilot=context.Pilots.FirstOrDefault(p=>p.pilotId==flightid);
            if(pilot != null)
            {
                pilot.isAvailable=true;
            }
            
           Console.WriteLine("Bookings were affected:"+bookingCancel);



        }
        // Passenger Booking History function
        public static void PassengerBookingHistory()
        {
            Console.WriteLine("\n=== Passenger Booking History ===");

            Console.WriteLine("Enter passenger Id: ");
            int passId = int.Parse(Console.ReadLine());


            Passenger selectpassenger = context.Passengers.FirstOrDefault(p => p.passengerId == passId);
            if (selectpassenger == null)
            {
                Console.WriteLine("Passenger not found ");
                return;
            }

            foreach (Booking b in context.Bookings.Where(b => b.passengerId == passId)) ;

            foreach (Flight f in context.Flights)
            {
                Console.WriteLine($"Flight Code: {f.flightCode}  |   Origin: {f.origin}  |  Destination: {f.destination}" +
                                  $"  |  departure date: {f.departureDate}  | Seat Number: {f.availableSeats}" +
                                  $"  |  Price: {f.ticketPrice}  |  Status: {f.status}");
            }


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
                        AddAircraft(); //Add an Aircraft
                        break;
                    case 3:
                        RegisterPilot(); // Register a Pilot
                        break;
                    case 4:
                        ViewAllFlights(); //View All Flights
                        break;
                    case 5:
                        ScheduleFlight(); //Schedule a Flight
                        break;
                    case 6:
                        BookingFlight(); // Book a Flight
                        break;
                    case 7:
                        CancelBooking(); //Cancel a Booking
                        break;
                    case 8:
                        DepartFlight();
                        break;
                    case 9:
                        CancelFlight();
                        break;
                    case 10:
                        PassengerBookingHistory();


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
