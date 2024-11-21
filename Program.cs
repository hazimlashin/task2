namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string input;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("K - Clear the list");
                Console.WriteLine("F - Search for a number");

                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");
                input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "P":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("[] - The list is empty.");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (i == list.Count - 1) 
                                    Console.Write(list[i]);
                                else
                                    Console.Write(list[i] + " ");
                            }
                            Console.WriteLine(" ]");
                        }
                        break;

                    case "A":
                        bool isDuplicate = false;
                        Console.Write("Enter a number to add: ");
                        int value = int.Parse(Console.ReadLine()); 

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (value == list[i])
                            {
                                isDuplicate = true;
                                break;
                            }
                        }

                        if (isDuplicate)
                        {
                            Console.WriteLine("Repeated number. Please enter a different number.");
                        }
                        else
                        {
                            list.Add(value);
                            Console.WriteLine($"{value} added.");
                        }
                        break;

                    case "M":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data.");
                        }
                        else
                        {
                            int sum = 0;
                            for (int i = 0; i < list.Count; i++)
                            {
                                sum += list[i];
                            }

                            double mean = sum / (double)list.Count;
                            Console.WriteLine($"Mean: {mean}");
                        }
                        break;

                    case "S":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to determine smallest number - list is empty.");
                        }
                        else
                        {
                            int smallest = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                if (smallest > list[i])
                                    smallest = list[i];
                            }
                            Console.WriteLine($"Smallest number: {smallest}");
                        }
                        break;

                    case "L":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to determine largest number - list is empty.");
                        }
                        else
                        {
                            int largest = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                if (largest < list[i])
                                    largest = list[i];
                            }
                            Console.WriteLine($"Largest number: {largest}");
                        }
                        break;

                    case "K":
                        list.Clear();
                        Console.WriteLine("The list has been cleared. Current state: []");
                        break;

                    case "F":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("The list is empty. Unable to search.");
                        }
                        else
                        {
                            Console.Write("Enter the number to search for: ");
                            int searchValue = int.Parse(Console.ReadLine());
                            bool found = false;

                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] == searchValue)
                                {
                                    Console.WriteLine($"Number {searchValue} found at index {i}.");
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine($"Number {searchValue} not found in the list.");
                            }
                        }
                        break;

                    case "Q":
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select P, A, M, S, L, K, or Q.");
                        break;
                }

            } while (input != "Q");
        }
    }
}
