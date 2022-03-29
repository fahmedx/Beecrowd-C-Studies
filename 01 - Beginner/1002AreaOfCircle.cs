using System; 
class URI {

    static void Main(string[] args) { 
        double R, n, A;
        R = double.Parse(Console.ReadLine());
        n = 3.14159;
        A = (n * Math.Pow(R,2.00));
        Console.WriteLine("A="+ A.ToString("0.0000"));
    }

}