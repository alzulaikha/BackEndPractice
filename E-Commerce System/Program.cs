using E_Commerce_System.Modles;
using System.Net;

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
            if (string.IsNullOrEmpty(userName))//validation user name if empty or not
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            bool exit1 = context.Users.Any(u => u.userName == userName);//validation user name shoudl be unique
            if (exit1)
            {
                Console.WriteLine("User name already exit, please enter another name");
                return;

            }


            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            if (string.IsNullOrEmpty(email))//validation email shoudl not be empty
            {
                Console.WriteLine("Email cannot be empty!");
                return;
            }
            bool exit2 = context.Users.Any(u => u.email == email);//validation user email shoudl be unique
            if (exit2)
            {
                Console.WriteLine("User email already exit, please enter another email");
                return;

            }


            Console.Write("Enter password: ");
            string password= Console.ReadLine();
            bool result = context.Users.Any(u => u.passwordHash == password);//validation if password is already exit

            if (result)
            {
                Console.WriteLine("Password already exit, please enter another password ");
                return;

            }

            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine();
            if (string.IsNullOrEmpty(fullName))//validation full name shoudl not be empty
            {
                Console.WriteLine("Full name cannot be empty!");
                return;
            }


            Console.Write("Enter phone number : ");
            string phone = Console.ReadLine();

            Console.Write("Enter address : ");
            string address = Console.ReadLine();



            User newUser = new User
            {
                userName = userName,
                email = email,
                passwordHash = password,
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
        public static void NewProductCategory() //Add a New Product to a Category function


        {

            Console.WriteLine("\n=== Add New Product to category ===");
            Console.WriteLine("\n=== Category ===");

            var category = context.Categories.ToList();
            foreach (Category c in context.Categories)
            {
                Console.WriteLine($"  ID: {c.categoryId}  | Category name: {c.categoryName}");
            }
            Console.WriteLine("Enter category id: ");
            int categoryId = int.Parse( Console.ReadLine() );
            Category category1 = context.Categories.FirstOrDefault(c => c.categoryId ==categoryId);
        


            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter description (optional): ");
            string description = Console.ReadLine();

            Console.WriteLine("Enter product price (optional): ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter stock quantity: ");
            int stockQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter image Url: ");
            string imageUrl = Console.ReadLine();


            Product product = new Product
            {
                productName = productName,
                description = description,
                price = price,
                stockQuantity = stockQuantity,
                categoryId = categoryId,
                createdAt = DateTime.Now,
                isAvailable = true
            };

            context.Products.Add(product);
            context.SaveChanges();


            Console.WriteLine("=== Product added to category successfully. ===");
            Console.WriteLine($"User ID: {product.productId}");
        }

        //public static void PlaceOrder() //Place an Order function
        //{
        //    Console.WriteLine("=== Place New Order ===");


        //    Console.Write("Enter user ID: ");
        //    int userId = int.Parse(Console.ReadLine());
        //    User user = context.Users.FirstOrDefault(u => u.userId == userId);

        //    Console.Write("Enter shipping address: ");
        //    string shippingAddress = Console.ReadLine();
        //    Console.Write("Choose payment method: 1-CreditCard  2-DebitCard  3-PayPal  4-Cash");
        //    int paymentMethod1 = int.Parse(Console.ReadLine());
        //    string[] payMethods = { "CreditCard", "DebitCard", "PayPal", "Cash" };
        //    string paymentMethod = payMethods[paymentMethod1 - 1];
        //}

        public static void ProductReview() //Write a Product Review function
        {
            Console.WriteLine("\n===Write a Product Review ===");
            Console.WriteLine("===  available users:  ===");
            foreach (User user in context.Users)
            {
                Console.WriteLine($" User ID: {user.userId}  | User Name: {user.userName}");

            }
            Console.Write("Enter user ID: ");
            int userId = int.Parse(Console.ReadLine());
            User user1 = context.Users.FirstOrDefault(u => u.userId == userId);

            Console.WriteLine("===  available  products:  ===");
            foreach (Product product in context.Products)
            {
                Console.WriteLine($" Product ID: {product.productId}  |  Product Name: {product.productName}");

            }
            Console.WriteLine("=== Enter product id:  ===");
            int productId = int.Parse(Console.ReadLine());
            Product product1 = context.Products.FirstOrDefault(p => p.productId == productId);

            Console.WriteLine("Enter rating: (1–5)");
            int rating = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter comment: ");
            string comment = Console.ReadLine();



            Review review = new Review
            {
                userId = userId,
                productId = productId,
                rating = rating,
                comment = comment,
                reviewDate = DateTime.Now,

            };

            context.Reviews.Add(review);
            context.SaveChanges();


            Console.WriteLine("=== Review Write successfully. ===");
            Console.WriteLine($" Review ID: {review.reviewId}");
        }
        public static void UpdateProductPriceandAvailability() //Update Product Price and Availability function
        {
            Console.WriteLine("Enter Product id: ");
            int productId=int.Parse(Console.ReadLine());
            var product1 = context.Products.FirstOrDefault(p=>p.productId == productId);

           Console.WriteLine("Enter new price");
           double price = double.Parse(Console.ReadLine());
            
            Product product2 = new Product
            {
                price=price,
                isAvailable = false
            };
            context.Products.Add(product2);
            context.SaveChanges();

        }
        public static void DeleteReview() //Delete a Review function
        {
            Console.WriteLine("Enter review id:");
            int reviewId = int.Parse(Console.ReadLine());

            var review = context.Reviews.FirstOrDefault(r => reviewId == r.reviewId);
            if (review == null)
            {
                Console.WriteLine("Review not found!");

            }
            context.Reviews.Remove(review);
            context.SaveChanges();
        } 

        public static void ViewAllProducts()//View All Products function
            {
             var product = context.Products.ToList();
            foreach (Product p in context.Products)
            {
                Console.WriteLine($"Product Id: {p.productId}  | Product name: {p.productName} | Product price: {p.price} " +
                    $"| categoryName Stock: {p.Category.categoryName} Quantity: {p.stockQuantity} | availability status: {p.isAvailable}");
            }
}              

        public static void FilterProductsByCategoryPrice() // Filter Products by Category and Price Range function


        {
            Console.WriteLine("\n=== Filter Products By Category Price ===");
            Console.WriteLine();
            Console.WriteLine("=== Categories ====");

            foreach(Category c in context.Categories)
            {
                Console.WriteLine($" Category ID: {c.categoryId}  | Category Name  {c.categoryName}");
            }

            Console.WriteLine("Enter category id: ");
            int categoryid = int.Parse(Console.ReadLine());
            Category category = context.Categories.FirstOrDefault(c => c.categoryId == categoryid);

            Console.WriteLine("Enter  minimum price: ");
            double minPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter maximum price: ");
            double maxPrice = double.Parse(Console.ReadLine());

            var product = context.Products.Where(p=>categoryid== categoryid&&
                                           p.price >= minPrice&&
                                           p.price <= maxPrice)
                                           .OrderBy(p => p.price)
                                           .ToList();

            foreach(Product p in context.Products)
            {
                Console.WriteLine($" Product ID: {p.productId}  | Product Name: {p.productName} | Product Price: {p.price} " +
                    $"| stock Quantity : {p.stockQuantity}");
            }

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
                        RegisterUser();// Register a New User 
                        break;
                    case 2:
                        NewProductCategory(); //Add a New Product to a Category
                        break; 
                    case 3:
                        break;
                    case 4:
                        ProductReview();//Write a Product Review
                        break;
                    case 5: ////Update Product Price and Availability
                        UpdateProductPriceandAvailability();
                        break;
                    case 6:
                        break;
                    case 7:
                        DeleteReview(); //Delete a Review
                        break;
                    case 8:
                        ViewAllProducts();//view all product
                        break;
                    case 9:
                        FilterProductsByCategoryPrice(); // Filter Products by Category and Price Range
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
