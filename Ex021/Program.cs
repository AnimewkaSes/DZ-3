
internal class Program 
{
    private static void Main()
    {
        Console.WriteLine("Введите X,Y,Z для первой точки");
        double X1 = Convert.ToDouble(Console.ReadLine());
        double Y1 = Convert.ToDouble(Console.ReadLine());
        double Z1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите X,Y,Z для второй точки");
        double X2 = Convert.ToDouble(Console.ReadLine());
        double Y2 = Convert.ToDouble(Console.ReadLine());
        double Z2 = Convert.ToDouble(Console.ReadLine());

        Distan(X1,Y1,Z1,X2,Y2,Z2); 
    }

   
    static void Distan(double X1,double Y1, double Z1,
                      double X2, double Y2, double Z2) {
        int n =2;
        double  result =Math.Round (Math.Sqrt(Math.Pow(X1-X2,n)+Math.Pow(Y1-Y2,n)+Math.Pow(Z1-Z2,n)),2);
        Console.WriteLine("Расстояние между двумя точками - {0}", result);

   }
   
}