using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
         Task1();  
        //Task2();  
        //Task3();  
        //Task4();  
    }

    // ==================== დავალება 1 ====================
   
    static void Task1()
    {
        Console.WriteLine("Enter the size of the array");
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];

        Console.WriteLine("Enter The Elements");
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("///////////////////");

        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        foreach (int num in arr1)
        {
            if (num % 2 == 0)
                even.Add(num);
            else
                odd.Add(num);
        }

        Console.WriteLine("even");
        foreach (int num in even)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nodd");
        foreach (int num in odd)
        {
            Console.WriteLine(num);
        }
    }

    // ==================== დავალება 2 ====================
    static void Task2()
    {
        var dictionary = new Dictionary<string, int>();

        while (true)
        {
            Console.WriteLine("\nChoose a number: ");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Delete contact");
            Console.WriteLine("3. Update phone");
            Console.WriteLine("4. Show all contacts");
            Console.WriteLine("0. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Phone: ");
                int mobile = int.Parse(Console.ReadLine());

                dictionary.Add(name, mobile);
                Console.WriteLine("Contact added.");
            }
            else if (choice == 2)
            {
                Console.Write("Name to delete: ");
                string deleteName = Console.ReadLine();

                if (dictionary.ContainsKey(deleteName))
                {
                    dictionary.Remove(deleteName);
                    Console.WriteLine("Contact deleted.");
                }
                else
                {
                    Console.WriteLine("Contact not found.");
                }
            }
            else if (choice == 3)
            {
                Console.Write("Name to update: ");
                string changeName = Console.ReadLine();

                if (dictionary.ContainsKey(changeName))
                {
                    Console.Write("Enter new phone: ");
                    dictionary[changeName] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Phone updated.");
                }
                else
                {
                    Console.WriteLine("Contact not found.");
                }
            }
            else if (choice == 4)
            {
                foreach (var item in dictionary)
                {
                    Console.WriteLine($"\n{item.Key}: {item.Value}");
                }
            }
            else if (choice == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    // ==================== დავალება 3 ====================
    static void Task3()
    {
        Console.WriteLine("Enter the size of the array");
        int k = int.Parse(Console.ReadLine());
        int[] arr2 = new int[k];

        Console.WriteLine("Enter the elements");
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        var Numbers = arr2.GroupBy(x => x)
                          .Select(g => new
                          {
                              Number = g.Key,
                              Count = g.Count(),
                              Sum = g.Sum()
                          });

        foreach (var item in Numbers)
        {
            Console.WriteLine($"{item.Number} appears {item.Count} times, sum {item.Sum}");
        }
    }

    // ==================== დავალება 4 ====================
    static void Task4()
    {
        Console.WriteLine("Enter the size of the array");
        int m = int.Parse(Console.ReadLine());
        int[] arr3 = new int[m];

        Console.WriteLine("Enter elements");
        for (int i = 0; i < arr3.Length; i++)
        {
            arr3[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("TOP:");
        int q = int.Parse(Console.ReadLine());

        var top = arr3.OrderByDescending(x => x)
                      .Take(q);

        Console.WriteLine($"Top {q} largest numbers:");
        foreach (var num in top)
        {
            Console.WriteLine(num);
        }
    }
}
