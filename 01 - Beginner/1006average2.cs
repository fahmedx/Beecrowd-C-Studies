using System;

class URI{
    /*
        Read three values (variables A, B and C), 
        which are the three student's grades. 
        Then, calculate the average, 
        considering that grade A has weight 2, 
        grade B has weight 3 and the grade C has weight 5. 
        Consider that each grade can go from 0 to 10.0, 
        always with one decimal place.

    Input
        The input file contains 3 values of floating points (double) 
        with one digit after the decimal point.

    Output
        Print the message "MEDIA"(average in Portuguese) and the student's 
        average according to the following example, 
        with a blank space before and after the equal signal.
    */
    static void Main(string[] args){
        double A = 0,B = 0,C = 0, media = 0;
        A = Convert.ToDouble(Console.ReadLine());
        B = Convert.ToDouble(Console.ReadLine());
        C = Convert.ToDouble(Console.ReadLine());
        media = (((A*2)+(B*3)+(C*5))/10);
        Console.WriteLine("MEDIA = {0}",media.ToString("0.0"));
    }
}