using System;

class URI {
    /*
    
        In this problem, 
        the task is to read a code of a product 1, 
        the number of units of product 1, 
        the price for one unit of product 1, 
        the code of a product 2, 
        the number of units of product 2 and the price for one unit of product 2. 
        After this, calculate and show the amount to be paid.

    Input
        The input file contains two lines of data. 
        In each line there will be 3 values: 
        two integers and a floating value with 2 digits after the decimal point.

    Output
        The output file must be a message like the following example where "Valor a pagar" means Value to Pay. 
        Remember the space after ":" and after "R$" symbol. 
        The value must be presented with 2 digits after the point.

    */
    static void Main(string[] args){
        int prod1, prod2, qtd1, qtd2;
        double price1, price2, total;
        string line1 = Console.ReadLine();
        string line2 = Console.ReadLine();
        String[] values1 = line1.Split(' ');

        prod1 = Int32.Parse(values1[0]);
        qtd1 = Int32.Parse(values1[1]);
        price1 = Convert.ToDouble(values1[2]);

        String[] values2 = line2.Split(' ');
        prod2 = Int32.Parse(values2[0]);
        qtd2 = Int32.Parse(values2[1]);
        price2 = Convert.ToDouble(values2[2]);
        total = ((qtd1 * price1)+(qtd2 * price2));
        Console.WriteLine("VALOR A PAGAR: R$ {0}", total.ToString("0.00"));
    }
}