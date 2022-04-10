using System;
class URI{
    /*
        Make a program that reads three floating point values: A, B and C. 
        Then, calculate and show:
        a) the area of the rectangled triangle that has base A and height C.
        b) the area of the radius's circle C. (pi = 3.14159)
        c) the area of the trapezium which has A and B by base, and C by height.
        d) the area of ​​the square that has side B.
        e) the area of the rectangle that has sides A and B.

    Input
        The input file contains three double values with one digit after the decimal point.

    Output
        The output file must contain 5 lines of data. 
        Each line corresponds to one of the areas described above, 
        always with a corresponding message (in Portuguese) 
        and one space between the two points and the value. 
        The value calculated must be presented with 3 digits after the decimal point.
    */
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