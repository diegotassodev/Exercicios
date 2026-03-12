namespace Oficina.Modelos;
internal class Carro {
    public int ID {get;}
    public string? Marca {get;}
    public string? Modelo {get;}
    public int Ano {get;}
    public Cliente DonoCarro {get;}

    public Carro(int iD, string? marca, string? modelo, int ano, Cliente cliente) {
        ID = iD;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        DonoCarro = cliente;
        cliente.AdicionarCarros(this);
    }
    public void ExibirDetalhes() {
        Console.WriteLine($"ID do Carro: {ID}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Dono do Carro: {DonoCarro}");    
    }
}