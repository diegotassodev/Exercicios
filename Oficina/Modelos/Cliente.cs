namespace Oficina.Modelos;
internal class Cliente {
    internal List<Carro> listaCarros = new ();
    private List<Servico> listaServicos = new();
    public int ID {get;}
    public string? Nome {get;}

    public override string ToString() {
        return $"{Nome}";
    }
    public Cliente(int iD, string? nome) {
        ID = iD;
        Nome = nome;
    }
    public void AdicionarServico(Servico servico) {
        listaServicos.Add(servico);
    }
    public void AdicionarCarros(Carro carro) {
        listaCarros.Add(carro);
    }
    public void ExibirDetalhes() {
        Console.WriteLine($"ID do Cliente: {ID}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine("Lista de Carro: ");
        listaCarros.ForEach(carro => Console.WriteLine($"- {carro.Modelo}"));
        Console.WriteLine("Lista de Serviços: ");
        listaServicos.ForEach(servico => Console.WriteLine($"- {servico.DataServico.ToString("dd/MM/yyyy")}"));
    }
}