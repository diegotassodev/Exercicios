namespace Oficina.Modelos;
internal class Funcionario {
    private List<Servico> listaServicos = new();
    public int ID {get;}
    public string? Nome {get;}
    public string Cargo {get;}
    public decimal Salario {get;}

    public override string ToString() {
        return $"{Nome}";
    }
    public Funcionario(int iD, string? nome, decimal salario, string cargo) {
        ID = iD;
        Nome = nome;
        Salario = salario;
        Cargo = cargo;
    }
    public void AdicionarServico(Servico servico) {
        listaServicos.Add(servico);
    }
    public void ExibirDetalhes() {
        Console.WriteLine($"ID do Funcionario: {ID}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário: R${Salario}");
        Console.WriteLine("Lista de Serviços: ");
        listaServicos.ForEach(servico => Console.WriteLine($"- {servico.DataServico.ToString("dd/MM/yyyy")}"));
    }
}