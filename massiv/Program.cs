internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Столбцов: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Строк: ");
        int m = int.Parse(Console.ReadLine());
        int[,] mas = new int[n, m];
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Введите элементы массива: ");
                mas[i, j] = int.Parse(Console.ReadLine());;
            }
        }
        Console.WriteLine();

        int rows = mas.GetUpperBound(0) + 1;
        int columns = mas.Length / rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mas[i, j]} \t");
            }
            Console.WriteLine();
        }

        int result = 0;
        int[] mas1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (mas[j, i] % 2 == 0 && result == 0)
                {
                    result = mas[j, i];
                }
            }
            mas1[i] = result;
            result = 0;
        }
        Console.WriteLine("\n");
        for (int i = 0; i < mas1.Length; i++)
        {
            Console.WriteLine($"{mas1[i]} \t");
        }   
    }
}
