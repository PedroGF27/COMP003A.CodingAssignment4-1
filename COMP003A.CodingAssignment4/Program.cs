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

            while (true)
            {
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                number = int.Parse(Console.ReadLine());

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                }

                number = 1;
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
                    int index = Array.IndexOf(products);
                }
                else if (number == 3)
                {
                    for (int i = 0; i < storage.Length; i++)
                    {
                        Console.WriteLine($"");
                    }
                }
            }
        }
    }
}
