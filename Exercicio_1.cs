using System;
using System.Collections.Generic;

class Exercicio_1
{
    private List<int> ListaNumeros;

    public Exercicio_1()
    {
        ListaNumeros = new List<int>();
        Console.WriteLine("lista Vazia foi criada.");
    }

    public void AdicionarElementos()
    {
        ListaNumeros.Add(10);
        ListaNumeros.Add(20);
        ListaNumeros.Add(30);
        Console.WriteLine("3 elementos adicionados à lista.");
    }

    public void AcessarSegundoElemento()
    {
        int segundoElemento = ListaNumeros[1];
        Console.WriteLine("O segundo elemento da lista é: " + segundoElemento);
    }

    public void PercorrerLista()
    {
        Console.WriteLine("Elementos da lista:");
        foreach (int numero in ListaNumeros)
        {
            Console.WriteLine(numero);
        }
    }

    public void RemoverPrimeiroElemento()
    {
        ListaNumeros.RemoveAt(0);
        Console.WriteLine("O primeiro elemento da lista foi removido.");
    }

    public void VerificarElemento(int elemento)
    {
        bool contemElemento = ListaNumeros.Contains(elemento);
        Console.WriteLine("A lista contém o elemento " + elemento + "? " + contemElemento);
    }

    public void OrdenarLista()
    {
        ListaNumeros.Sort();
        Console.WriteLine("Lista ordenada em ordem crescente." );
        PercorrerLista();   
    }

    public void InserirElemento(int elemento, int posicao)
    {
        ListaNumeros.Insert(posicao, elemento);
        Console.WriteLine("Novo elemento " + elemento + " inserido na posição " + posicao + " da lista.");
        PercorrerLista();
    }

    public void LimparLista()
    {
        ListaNumeros.Clear();
        Console.WriteLine("A lista foi limpa.");
    }

    public void ExecutarFuncionalidades()
    {
        AdicionarElementos();
        AcessarSegundoElemento();
        PercorrerLista();
        RemoverPrimeiroElemento();
        VerificarElemento(20);
        OrdenarLista();
        InserirElemento(15, 1);
        LimparLista();
    }
}
