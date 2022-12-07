internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Программа по выдаче таблице кубов");
        Console.WriteLine("Введите количество итераций");
        int N = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        Console.WriteLine("Вывод таблицы кубов при N = {0}",N);
        for(int i=1; i <= N; i++){
            result = Convert.ToInt32(Math.Pow(i, 3));
            
            Console.WriteLine(result);
        }
        
        }
}