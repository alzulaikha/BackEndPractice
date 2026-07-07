using E_Commerce_System.Modles;

namespace E_Commerce_System
{
    internal class Program
    {
        public static EcommerceContext context= new EcommerceContext();
        public static void RegisterUser()// Register a New User function
        {
            Console.WriteLine("\n=== Register New User ===");

            Console.Write("Enter username: ");
            string userName = Console.ReadLine();
            

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter password: ");
            string passwordHash = Console.ReadLine();

            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter phone number : ");
            string phone = Console.ReadLine();

            Console.Write("Enter address : ");
            string address = Console.ReadLine();



            User newUser = new User
            {
                userName = userName,
                email = email,
                passwordHash = passwordHash,
                fullName = fullName,
                phoneNumber = phone,
                address = address,
                registrationDate = DateTime.Now,
                isActive = true
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            Console.WriteLine("\nUser registered successfully.");
            Console.WriteLine($"User ID: {newUser.userId}");
        }


      
            static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine("        E-Commerce System       ");
                Console.WriteLine("========================================");
                Console.WriteLine(" 1. Register a New User");
                Console.WriteLine(" 2. Add a New Product to a Category");
                Console.WriteLine(" 3. Place an Order");
                Console.WriteLine(" 4. Write a Product Review");
                Console.WriteLine(" 5. Update Product Price and Availability");
                Console.WriteLine(" 6. Cancel an Order");
                Console.WriteLine(" 7. Delete a Review");
                Console.WriteLine(" 8. View All Products");
                Console.WriteLine(" 9. Filter Products by Category and Price Range");
                Console.WriteLine(" 10. Get Category with All Its Products");
                Console.WriteLine(" 11. View Order History with Full Details");
                Console.WriteLine(" 12. Product Summary Report");
                Console.WriteLine(" 0  - Exit");
                Console.WriteLine("========================================");
                Console.Write("Select option: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
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
                    case 12:
                        break; 
                    case 0:
                        break;
                    default:
                        break;

                }// closed switch
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }// closed while
    }
}
