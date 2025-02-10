// Pedro Garcia
// COMP-003A
// Johnathan Cruz
// Inventory management application with a minimum of 10 elements in the colection.
namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = new string[10];
            int[] storage = new int[10];
            int number = 0;

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                number = int.Parse(Console.ReadLine());

                //try
                //{
                //    number = Convert.ToInt32(Console.ReadLine());
                //}
                //catch
                //{
                //    Console.WriteLine();
                //}


                if (number == 1)
                {
                    int index = Array.FindIndex(products, name => name == null);
                    Console.WriteLine("Product name: ");
                    products[index] = Console.ReadLine();

                    Console.WriteLine("Product Quantity: ");
                    try
                    {
                        storage[index] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else if (number == 2)
                {
                    Console.WriteLine("Enter Product Name: ");
                    string updateProduct = Console.ReadLine();
                    int indexUpdate = Array.FindIndex(products, product => product == updateProduct);

                    if (indexUpdate != -1)
                    {
                        Console.Write($"New quantity for {updateProduct}: ");
                        int updateQuantity = int.Parse(Console.ReadLine());

                        storage[indexUpdate] = updateQuantity;
                        Console.WriteLine($"New quantity of {updateProduct} updated to {updateQuantity} ");
                    }

                }
                else if (number == 3)
                {
                    double totalQuantity = 0;

                    Console.WriteLine("Inventory Summary: ");
                    for (int i = 0; i < storage.Length; i++)
                    {
                        if (products[i] != null)
                        {
                            Console.WriteLine($"{products[i]}: {storage[i]}");
                            totalQuantity += storage[i];

                        }


                    }

                    int totalProducts = products.Count(name => !string.IsNullOrEmpty(name));
                    double averageQuantity = storage.Average();

                    Console.WriteLine($"Total Products: {totalProducts}");
                    Console.WriteLine($"Total Quantity: {totalQuantity}");
                    Console.WriteLine($"Average Quantity: {averageQuantity}");
                }
                else if (number == 4)
                {
                    Console.WriteLine("Program Ending!");
                    return;
                }
                else
                {
                    Console.WriteLine("Unknown Input. Please try again!");
                }
            }
        }
    }
}
