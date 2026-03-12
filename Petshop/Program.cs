using PetShop.Modelos;
void LimpaTela() {
    Console.ReadKey();
    Console.Clear();
}

// Instanciando Objetos:
var cachorro01 = new Pet (1, "Thomas", "Maltês");
var medico01 = new Medico (1, "Romário", 15000m);
var consulta01 = new Consulta(1, medico01, cachorro01, new DateTime(2023,12,15));

Console.Clear();
Console.WriteLine("Apresentando Dono: ");
Console.WriteLine($"{Dono.Descricao}");
LimpaTela();


Console.WriteLine("Apresentando Cachorro: ");
cachorro01.ExibeDetalhes();
LimpaTela();

Console.WriteLine("Apresentando Médico: ");
medico01.ExibeDetalhes();
LimpaTela();

Console.WriteLine("Apresentando Consulta: ");
consulta01.ExibeDetalhes();
LimpaTela();