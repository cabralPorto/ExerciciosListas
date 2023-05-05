using System;
using System.Collections;
using System.Collections.Generic;

class Program : Exercicio_1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primeira Atividade ");
        Console.WriteLine();
        
        Exercicio_1 lista = new Exercicio_1();
        lista.ExecutarFuncionalidades();
        
        Console.WriteLine();
        Console.WriteLine("Segunda Atividade ");
        Console.WriteLine();
       
        Exercicio_2 manipuladorLista = new Exercicio_2();
        manipuladorLista.Executar();
        
        Console.WriteLine();
        Console.WriteLine("Terceira Atividade ");
        Console.WriteLine();
        
        Exercicio_3 exercicio = new Exercicio_3();
        exercicio.Executar();

    }

}

