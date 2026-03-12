namespace PetShop.Modelos;
internal class Medico {
    private List<Consulta> listaConsultas = new();
    public int Id {get;}
    public string? Nome {get;}
    public decimal Salario {get;}

    public override string ToString() {
        return $"{Nome}";
    }

    public Medico(int id, string? nome, decimal salario) {
        Id = id;
        Nome = nome;
        Salario = salario;
    }

    public void AdicionarConsulta(Consulta consulta) {
        listaConsultas.Add(consulta);
    }

    public void ExibeDetalhes() {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário: R${Salario}");
        Console.WriteLine("Lista de Consultas: ");
        listaConsultas.ForEach(consulta => Console.WriteLine($"- {consulta}"));
    }
}