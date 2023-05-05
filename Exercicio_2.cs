class Exercicio_2
{
    private List<int> lista;

    public Exercicio_2()
    {
        lista = new List<int>();
    }

    public void CriarListaVazia()
    {
        lista.Clear();
        Console.WriteLine("Lista vazia criada.");
    }

    public void AdicionarElementos()
    {
        lista.Add(4);
        lista.Add(7);
        lista.Add(2);
        lista.Add(9);
        lista.Add(1);
        Console.WriteLine("5 elementos adicionados à lista." + string.Join(", ", lista));
    }

    public List<int> ListaInversa()
    {
        List<int> listaInversa = lista.OrderByDescending(x => x).ToList();
        Console.WriteLine("Lista original em ordem inversa: " + string.Join(", ", listaInversa));
        return listaInversa;
    }

    public void ImprimirElementosPares()
    {
        Console.WriteLine("Elementos pares:");
        foreach (int num in lista)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }

    public void RemoverElementosImpares()
    {
        lista.RemoveAll(x => x % 2 != 0);
        Console.WriteLine("Elementos ímpares removidos da lista.");
        Console.WriteLine("Lista atualizada: " + string.Join(", ", lista));
    }

    public List<int> ListaUnica()
    {
        List<int> listaUnica = lista.Distinct().ToList();
        Console.WriteLine("Lista com elementos únicos: " + string.Join(", ", listaUnica));
        return listaUnica;
    }

    public void OrdenarListaDecrescente()
    {
        lista = lista.OrderByDescending(x => x).ToList();
        Console.WriteLine("Lista ordenada em ordem decrescente: " + string.Join(", ", lista));
    }

    public void InserirElementoOrdenado(int num)
    {
        lista.Add(num);
        lista = lista.OrderBy(x => x).ToList();
        Console.WriteLine("Elemento " + num + " inserido na posição correta na lista.");
        Console.WriteLine("Lista atualizada: " + string.Join(", ", lista));
    }

    public void LimparLista()
    {
        lista.Clear();
        Console.WriteLine("Lista limpa.");
    }

    public void Executar()
    {
        CriarListaVazia();
        AdicionarElementos();
        ListaInversa();
        ImprimirElementosPares();
        RemoverElementosImpares();
        ListaUnica();
        OrdenarListaDecrescente();
        InserirElementoOrdenado(6);
        LimparLista();
    }
}
