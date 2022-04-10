using System;

class URI {
    /*
        Read four integer values named A, B, C and D. 
        Calculate and print the difference of product A and B by the product of 
        C and D (A * B - C * D).

    Input
        The input file contains 4 integer values.

    Output
        Print DIFERENCA (DIFFERENCE in Portuguese) with all the capital letters,
        according to the following example, 
        with a blank space before and after the equal signal.
    */
    static void Main(string[] args){
        int A,B,C,D,DIF;
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        C = Convert.ToInt32(Console.ReadLine());
        D = Convert.ToInt32(Console.ReadLine());
        DIF = ((A*B)-(C*D));
        Console.WriteLine("DIFERENCA = {0}",DIF);
    }
}