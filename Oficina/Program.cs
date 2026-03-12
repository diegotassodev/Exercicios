/*


-----------------------------------------------------
Carro
- ID: int
- Marca: string
- Modelo: string
- Ano: int

+ Construtor
+ ExibirDetalhes

-----------------------------------------------------
Cliente
- ID: int
- Nome: string
- ListaCarros: List<Carro>
- Lista de Serviços: List<Servico>

+ Construtor
+ ToString
+ AdicionarServico()
+ AdicionarCarros()
+ ExibirDetalhes

-----------------------------------------------------
Funcionario
- ID: int
- Nome: string
- Salario: decimal
- Cargo: string
- List de Serviços: List<Servico>

+ Construtor
+ ToString
+ AdicionarServico()
+ ExibirDetalhes

-----------------------------------------------------
Servico
- ID: int
- Tipo: string
- Cliente: Cliente
- Carro: Carro
- Funcionario: Funcionario
- DataServico: DateTime

+ Construtor
+ ExibirDetalhes

-----------------------------------------------------
*/

using Oficina.Modelos;

void LimpaTela() {
    Console.ReadKey();
    Console.Clear();
}

Console.Clear();
var cliente01 = new Cliente(1, "José");
var carro01 = new Carro(1, "Honda", "Civic", 2020, cliente01);
var funcionario01 = new Funcionario(1, "Rafael", 5000, "Mecânico");
var servico01 = new Servico(
    1,
    "Manutenção",
    cliente01,
    carro01,
    funcionario01,
    new DateTime(2025,12,20)
);
servico01.ExibirDetalhes();
LimpaTela();

carro01.ExibirDetalhes();
LimpaTela();

cliente01.ExibirDetalhes();
LimpaTela();

funcionario01.ExibirDetalhes();
LimpaTela();
