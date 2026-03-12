namespace PetShop.Modelos;
internal class Pet {
    private List<Consulta> listaConsultas = new();
    public int Id {get;}
    public string? Nome {get;}
    public string? Raca {get;}

    public override string ToString() {
        return $"{Nome}";
    }
    public Pet(int id, string? nome, string? raca) {
        Id = id;
        Nome = nome;
        Raca = raca;
    }

    public void ExibeDetalhes() {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Raça: {Raca}");
        Console.WriteLine("Lista de Consultas: ");
        listaConsultas.ForEach(consulta => Console.WriteLine($"- {consulta}"));
    }

    public void AdicionarConsulta(Consulta consulta) {
        listaConsultas.Add(consulta);
    }
}