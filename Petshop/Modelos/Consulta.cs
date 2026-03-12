namespace PetShop.Modelos;
internal class Consulta {
    public int Id {get;set;}
    public Medico? MedicoAtendente {get;}
    public Pet? PetAtendido {get;}
    public DateTime DataConsulta {get;}

    public override string ToString() {
        return $"{DataConsulta.ToString("dd/MM/yyyy")}";
    }

    public Consulta(int id, Medico? medicoAtendente, Pet? petAtendido, DateTime dataConsulta) {
        Id = id;
        MedicoAtendente = medicoAtendente;
        PetAtendido = petAtendido;
        DataConsulta = dataConsulta;

        medicoAtendente!.AdicionarConsulta(this);
        petAtendido!.AdicionarConsulta(this);
    }

    public void ExibeDetalhes() {
        Console.WriteLine($"Médico: {MedicoAtendente}");
        Console.WriteLine($"Pet: {PetAtendido}");
        Console.WriteLine($"Data da Consulta: {DataConsulta.ToString("dd/MM/yyyy")}");
    }
}