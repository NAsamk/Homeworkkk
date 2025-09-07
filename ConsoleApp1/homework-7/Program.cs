
class Program
{

    static void Main()
    {
        Task1();
        //Task2();  
        //Task3();  
        //Task4();  
        //Task5();  
        //Task6();
    } 

    static void Task1()
    {
        /* var r = int.Parse(Console.ReadLine());
         Console.WriteLine(2 * r * r);*/
        Console.WriteLine(2 * Math.Pow(double.Parse(Console.ReadLine()), 2));
    }

    static void Task2()
    {

        /*  var count = 0;
          List<string> items = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();
          bool allEqual = true;

          for (int i = 1; i < items.Count; i++)
          {
              if (items[i] != items[0])
              {
                  allEqual = false;
                  break;
              }
          }

          Console.WriteLine(allEqual ? "YES" : "NO");*/

        Console.WriteLine(Console.ReadLine().Split(',').Select(s => s.Trim()).Distinct().Count() == 1 ? "Yes" : "No");


    }


    static void Task3()
    {
        /*List<int> points = new List<int> {
                    int.Parse(Console.ReadLine()) * 3,  
                    int.Parse(Console.ReadLine()) * 1,  
                    int.Parse(Console.ReadLine()) * 0   
                };

        Console.WriteLine(points.Sum());*/


        var points = new List<int> { 3, 1, 0 }.Select(x => int.Parse(Console.ReadLine()) * x).ToList();

        Console.WriteLine(points.Sum());
    }


    static void Task4()
    {
        /*  int[] hours = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            var total = 0;

            for (var day = 0; day < 7; day++)
            {
                var h = hours[day];
                var pay = (h <= 8 ? h * 10 : 8 * 10 + (h - 8) * 15);

                if (day >= 5) // შაბათი ან კვირა
                    pay *= 2;

                total += pay;
            }

            Console.WriteLine(total);*/


        Console.WriteLine(Console.ReadLine().Split(',').Select(int.Parse).Take(7) // პირველი 7 მნიშვნელობა
        .Select((h, day) => (day >= 5
            ? (h <= 8 ? h * 10 : 8 * 10 + (h - 8) * 15) * 2
            : (h <= 8 ? h * 10 : 8 * 10 + (h - 8) * 15)))
        .Sum());

    }

    static void Task5()
    {
        /*string[] words = { "Hello", "World", "Programming", "communication" };

        Console.Write("n: ");
        int N = int.Parse(Console.ReadLine());

        var result = words.Where(w => w.Length == N).ToArray();

        if (result.Length > 0)
            Console.WriteLine(string.Join(", ", result));
        else
            Console.WriteLine("No elements found");  */

        string[] words = { "Hello", "World", "Programming", "communication" };
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(
            string.Join(", ", words.Where(w => w.Length == n).DefaultIfEmpty("No elements found"))
        );
    }

    static void Task6()
    {
        /*var count = 0;
        int[] days = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        for (var i = 0; i < days.Length - 1; i++)
        {
            if (days[i] < days[i + 1])
            {
                count++;
            }

        }

        Console.WriteLine(count);*/
        int[] days = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        int count = days.Zip(days.Skip(1), (a, b) => a < b ? 1 : 0).Sum();

        Console.WriteLine(count);
    }
}