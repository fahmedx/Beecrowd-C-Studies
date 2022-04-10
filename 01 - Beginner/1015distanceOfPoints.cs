using System;

class URI{
    /*
        Read the four values corresponding to the x and y axes of
        two points in the plane, p1 (x1, y1) and p2 (x2, y2) and 
        calculate the distance between them, showing four decimal 
        places after the comma, according to the formula.

    Input
        The input file contains two lines of data. 
        The first one contains two double values: x1 y1 and the second 
        one also contains two double values with 
        one digit after the decimal point: x2 y2.

    Output  
        Calculate and print the distance value using the provided formula, 
        with 4 digits after the decimal point.
    */
    static void Main(string[] args){
        double distance;
        double x1,x2,y1,y2;
        string[] vet1 = Console.ReadLine().Split(' ');
        x1 = double.Parse(vet1[0]);
        y1 = double.Parse(vet1[1]);
        string[] vet2 = Console.ReadLine().Split(' ');
        x2 = double.Parse(vet2[0]);
        y2 = double.Parse(vet2[1]);
        distance = Math.Sqrt((Math.Pow((x2-x1),2) + 
                   Math.Pow((y2-y1),2)));
        Console.WriteLine(distance.ToString("0.0000"));
    }
}