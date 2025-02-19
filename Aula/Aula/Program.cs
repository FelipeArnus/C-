using System;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {

        DateTime hoje = DateTime.Now; //data de hj


        Console.Write("Diga sua data de nascimento():");
        string nascimento = Console.ReadLine();
        DateTime nsc = DateTime.Parse(nascimento);
        Console.Write($"Sua idade é {hoje.Year - nsc.Year}");


    } 


}
