using System;
class URI{
    static void Main(string[] args){
       double A,B,C;
       double[] result = new double[5];
       string line = Console.ReadLine();
       String[] values = line.Split(' ');
       A = Convert.ToDouble(values[0]);
       B = Convert.ToDouble(values[1]);
       C = Convert.ToDouble(values[2]);
       result[0] = (A*C)/2;
       result[1] = 3.14159 * (C*C);
       result[2] = ((A+B)*C)/2;
       result[3] = Math.Pow(B,2);
       result[4] = (A*B);
       Console.WriteLine("TRIANGULO: {0}", result[0].ToString("0.000"));
       Console.WriteLine("CIRCULO: {0}", result[1].ToString("0.000"));
       Console.WriteLine("TRAPEZIO: {0}", result[2].ToString("0.000"));
       Console.WriteLine("QUADRADO: {0}", result[3].ToString("0.000"));
       Console.WriteLine("RETANGULO: {0}", result[4].ToString("0.000"));
    }
}