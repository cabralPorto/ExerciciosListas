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



        //    List<int> minhaLista = new List<int> { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
        //    List<int> novaLista = DivisiveisPorTres(minhaLista);
        //    Console.WriteLine("Nova lista contendo apenas elementos divisíveis por 3:");
        //    foreach (int num in novaLista)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();

        //    double media = minhaLista.Average();
        //    Console.WriteLine("Elementos maiores que a média da lista:");
        //    MaioresQueMedia(minhaLista, media);

        //    minhaLista = RemoveRepetidos(minhaLista);
        //    Console.WriteLine("Lista sem elementos repetidos:");
        //    foreach (int num in minhaLista)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();

        //    novaLista = ImparesDeFrequencia(minhaLista);
        //    Console.WriteLine("Nova lista contendo elementos de frequência ímpar:");
        //    foreach (int num in novaLista)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();

        //    OrdenaDecrescente(minhaLista);
        //    Console.WriteLine("Lista ordenada em ordem decrescente:");
        //    foreach (int num in minhaLista)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();

        //    int novoElemento = 11;
        //    //InsereOrdenado(novoElemento, minhaLista);
        //    Console.WriteLine($"Lista com novo elemento ({novoElemento}) inserido na posição correta:");
        //    foreach (int num in minhaLista)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();

        //    minhaLista.Clear();
        //    Console.WriteLine("Lista limpa:");
        //    foreach (int num in minhaLista)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();
        //}

        //static List<int> DivisiveisPorTres(List<int> lista)
        //{
        //    List<int> novaLista = new List<int>();
        //    foreach (int num in lista)
        //    {
        //        if (num % 3 == 0)
        //        {
        //            novaLista.Add(num);
        //        }
        //    }
        //    return novaLista;
        //}

        //static void MaioresQueMedia(List<int> lista, double media)
        //{
        //    foreach (int num in lista)
        //    {
        //        if (num > media)
        //        {
        //            Console.Write(num + " ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //static List<int> RemoveRepetidos(List<int> lista)
        //{
        //    List<int> novaLista = new List<int>();
        //    foreach (int num in lista)
        //    {
        //        if (!novaLista.Contains(num))
        //        {
        //            novaLista.Add(num);
        //        }
        //    }
        //    return novaLista;
        //}

        //static List<int> ImparesDeFrequencia(List<int> lista)
        //{
        //    List<int> novaLista = new List<int>();
        //    foreach (int num in lista)
        //    {
        //        int frequencia = 0;
        //        foreach (int num2 in lista)
        //        {
        //            if (num == num2)
        //            {
        //                frequencia++;
        //            }
        //        }
        //        if (frequencia % 2 != 0 && !novaLista.Contains(num))
        //        {
        //            novaLista.Add(num);
        //        }
        //    }
        //    return novaLista;
        //}

        //static void OrdenaDecrescente(List<int> lista)
        //{
        //    for (int i = 0; i < lista.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < lista.Count; j++)
        //        {
        //            if (lista[i] < lista[j])
        //            {
        //                int temp = lista[i];
        //                lista[i] = lista[j];
        //                lista[j] = temp;
        //            }
        //        }
        //    }
    }

}

