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

        //foreach (int numero in ListaNumeros)
        //{
        //    Console.WriteLine(numero);
        //}

        //ListaNumeros.ForEach(numero => Console.WriteLine(numero));

        ListaNumeros.ForEach(numero => {
            numero += 1;
            //numero = numero + 1;
            //numero++;
        });

        var novaListaNumeros = ListaNumeros.Select(numero => numero.ToString());

    }

    public void RemoverPrimeiroElemento()
    {
        ListaNumeros.RemoveAt(0);
        Console.WriteLine("O primeiro elemento da lista foi removido.");
    }

    public void VerificarElemento(int elemento)
    {
        var medidores = new List<Medidor>() 
        { 
            new Medidor() { Numero = "M001", Setor = 1 }, 
            new Medidor() { Numero = "M002", Setor = 1 } 
        };

        var medidorBusca = new Medidor() { Numero = "M001", Setor = 1 };

        var medidorRef = medidores[0];
        var ehIgual = medidores[0].Equals(medidorBusca);

        bool contemElemento = medidores.Contains(medidorBusca);

        bool contemElementoAny = medidores.Any(p => p.Numero == medidorBusca.Numero);

        Console.WriteLine("A lista contém o elemento " + elemento + "? " + contemElementoAny);
    }

    public void OrdenarLista()
    {
        ListaNumeros.Sort();
        IList<int> lista = ListaNumeros.OrderBy(p => p).ToList();
        IList<int> lista1 = ListaNumeros.OrderByDescending(p => p).ToList();

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

    static IntPtr GetMemoryAddress(object obj)
    {
        // Usa o método GCHandle.Alloc para obter o endereço de memória
        System.Runtime.InteropServices.GCHandle handle = System.Runtime.InteropServices.GCHandle.Alloc(obj, System.Runtime.InteropServices.GCHandleType.Weak);
        IntPtr address = System.Runtime.InteropServices.GCHandle.ToIntPtr(handle);
        handle.Free();

        return address;
    }
}


class Medidor
{
    public string Numero { get; set; }
    public int Setor { get; set; }

    public override bool Equals(object? obj)
    {
        return Numero == ((Medidor)obj).Numero;
    }

    public override string ToString()
    {
        return Numero.ToString();
    }
}

