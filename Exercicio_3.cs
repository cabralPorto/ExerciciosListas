using System;
using System.Collections.Generic;
using System.Linq;

public class Exercicio_3
{
    private List<int> lista;

    public Exercicio_3()
    {
        lista = new List<int>();
        Console.WriteLine("Lista Vazia Criada");
    }

    public void AdicionarElementos()
    {
        for (int i = 1; i <= 10; i++)
        {
            lista.Add(i);
        }
        Console.WriteLine("10 elementos adicionados à lista.");
    }

    public List<int> ElementosDivisiveisPor3()
    {
        List<int> listaDivisiveisPor3 = lista.Where(x => x % 3 == 0).ToList();
        Console.WriteLine("Nova lista contendo apenas elementos divisíveis por 3: " + string.Join(", ", listaDivisiveisPor3));
        return listaDivisiveisPor3;
    }

    public void ImprimirElementosMaioresQueMedia()
    {
        double media = lista.Average();
        Console.WriteLine("Elementos maiores que a média da lista (" + media + "): ");
        foreach (int num in lista)
        {
            if (num > media)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }

    public void RemoverElementosRepetidos()
    {
        lista = lista.Distinct().ToList();
        Console.WriteLine("Elementos repetidos removidos da lista.");
    }
    public List<int> ElementosComOcorrenciaImpar()
    {
        Dictionary<int, int> ocorrencias = new Dictionary<int, int>();
        foreach (int num in lista)
        {
            if (ocorrencias.ContainsKey(num))
            {
                ocorrencias[num]++;
            }
            else
            {
                ocorrencias[num] = 1;
            }
        }

        List<int> listaImpares = lista.Where(x => ocorrencias[x] % 2 != 0).Distinct().ToList();
        Console.WriteLine("Nova lista contendo apenas elementos que aparecem um número ímpar de vezes: " + string.Join(", ", listaImpares));
        return listaImpares;
    }
    public void OrdenarListaDecrescente()
    {
        lista.Sort((x, y) => y.CompareTo(x));
        Console.WriteLine("Lista ordenada em ordem decrescente: " + string.Join(", ", lista));
    }
    public void InserirElementoComBuscaBinaria(int novoElemento)
    {
        int index = lista.BinarySearch(novoElemento);
        if (index < 0)
        {
            lista.Insert(~index, novoElemento);
        }
        Console.WriteLine("Elemento " + novoElemento + " inserido na posição " + (~index) + " da lista.");
    }
    public void LimparLista()
    {  
        lista.Clear();
        Console.WriteLine("Lista foi limpa ");
    }
    public void Executar()
    {
        AdicionarElementos();
        List<int> divisiveisPor3 = ElementosDivisiveisPor3();
        ImprimirElementosMaioresQueMedia();
        RemoverElementosRepetidos();
        ElementosComOcorrenciaImpar();
        OrdenarListaDecrescente();
        InserirElementoComBuscaBinaria(11);
        LimparLista();
    }
}
