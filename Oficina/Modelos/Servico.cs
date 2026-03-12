namespace Oficina.Modelos;
internal class Servico {
    public int ID {get;}
    public string? Tipo {get;}
    public Cliente? ClienteRequisitante {get;}
    public Carro? CarroCliente {get;}
    public Funcionario? FuncionarioAtendente {get;}
    public DateTime DataServico = new();

    public Servico(int iD, string? tipo, Cliente? clienteRequisitante, Carro? carroCliente, Funcionario? funcionarioAtendente, DateTime dataServico) {
        if (clienteRequisitante!.listaCarros.Contains(carroCliente!)) {
            ID = iD;
            Tipo = tipo;
            ClienteRequisitante = clienteRequisitante;
            CarroCliente = carroCliente;
            FuncionarioAtendente = funcionarioAtendente;
            DataServico = dataServico;
        
            ClienteRequisitante!.AdicionarServico(this);
            FuncionarioAtendente!.AdicionarServico(this);
        }
        else {
            Console.WriteLine($"O carro {carroCliente!.ID} não pertence ao cliente {clienteRequisitante}.");
            Console.WriteLine("Por isso, esse serviço não pode ser iniciado.");
        }
    }
    public void ExibirDetalhes() {
        Console.WriteLine($"ID do Serviço: {ID}");
        Console.WriteLine($"Tipo de Serviço: {Tipo}");
        Console.WriteLine($"Cliente: {ClienteRequisitante}");
        Console.WriteLine($"Carro: {CarroCliente!.Marca}");
        Console.WriteLine($"Funcionário: {FuncionarioAtendente}");
        Console.WriteLine($"Data do Serviço: {DataServico.ToString("dd/MM/yyyy")}");
    }
}