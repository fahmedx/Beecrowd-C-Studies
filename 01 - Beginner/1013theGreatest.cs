using System;

class URI {
    /*
        Make a program that reads 3 integer values and present 
        the greatest one followed by the message "eh o maior". 
        Use the following formula:

    Input
        The input file contains 3 integer values.

    Output
        Print the greatest of these three values followed by a space and the message 
        “eh o maior”.
    */
    static void Main(string[] args){
        int A,B,C, maior, maiorAB, MaiorBC;
        string[] vet = Console.ReadLine().Split(' ');

        A = int.Parse(vet[0]);
        B = int.Parse(vet[1]);
        C = int.Parse(vet[2]);
        maiorAB = (A+B+Math.Abs(A-B))/2;
        MaiorBC = (A+C+Math.Abs(A-C))/2;
        maior = Math.Max(maiorAB,MaiorBC);
        Console.WriteLine(maior + " eh o maior");
    }
}