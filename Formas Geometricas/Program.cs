/*
Para esse programa utilizamos conceitos de herança e orientação
a objetos para criar um modelo de cálculo de área de várias 
figuras geométricas diferentes com padrões de execução e um
modelo de dicionários para facilitar o procedimento de escolha.

1. Abre o menu com pedido de escolha da forma geométrica
2. Usuário entra com o número referente a forma que ele deseja calcular
3. Abre o menu com o pedido do tipo de calculo a ser realizado
4. Usuário entra com o número referente ao tipo de calculo que ele deseja realizar.
5. Um dicionário chamado formas geométricas é criado, gravando um objeto do tipo inteiro como chave e outro do tipo Forma como referente.
6. Em cada posição de inteiro é armazenado a criação de um tipo de objeto relativo a opção, além disso, o construtor desses objetos, recebe como valor o tipo de cálculo a ser realizado.
7. Os objetos salvam o tipo de cálculo em uma variável privada e depois reenviam esse tipo em um switch na função de execução
8. Com base na função de execução que acontecem todos os cálculos referentes ao sistema.

=========================================================
Forma Geometrica
+ CalcularArea();
+ CalcularPerimetro();

=========================================================
Triangulo : FormaGeometrica
- baseTriangulo: double
- alturaTriangulo: double
- ladoTriangulo: double
- tipoCalculo: int
- tipoTriangulo: int
- area: double
- perimetro: int

+ Construtor()
+ Executar()
+ CalcularArea(): 
    CalcularAreaEquilatero()
    CalcularAreaIsoceles()
    CalcularAreaEscaleno()
+ CalcularPerimetro(): 
    CalcularPerimetroEquilatero()
    CalcularPerimetroIsoceles()
    CalcularPerimetroEscaleno()
=========================================================
Quadrado : FormaGeometrica
- ladoQuadrado: double
- area: double
- perimetro: int

+ Construtor()
+ Executar()
+ CalcularArea(): 
+ CalcularPerimetro(): 
=========================================================
Retângulo : Forma Geometrica
- comprimentoRetangulo: double
- larguraRetangulo: double
- area: double
- perimetro: double

+ Construtor()
+ Executar()
+ CalcularArea(): 
+ CalcularPerimetro(): 
=========================================================
Circulo : FormaGeometrica
- raioCirculo: double
- area: double
- perimetro: double

+ Construtor()
+ Executar()
+ CalcularArea(): 
+ CalcularPerimetro(): 
=========================================================
Losango : Forma Geometrica
- diagonalMaiorLosango: double
- diagonalMenorLosango: double
- ladoLosango: double
- area: double
- perimetro: double

+ Construtor()
+ Executar()
+ CalcularArea(): 
+ CalcularPerimetro(): 

*/

using Formas.Modelos;
Console.Clear();
Console.WriteLine("======================================");
Console.WriteLine("          FORMAS GEOMÉTRICAS          ");
Console.WriteLine("======================================");
Console.WriteLine("1. Triângulo");
Console.WriteLine("2. Quadrado");
Console.WriteLine("3. Retangulo");
Console.WriteLine("4. Losango");
Console.WriteLine("5. Circulo");
Console.Write("Escolha: ");
int opcaoForma; int.TryParse(Console.ReadLine()!, out opcaoForma);
while (opcaoForma > 6 || opcaoForma < 1 ) {
    Console.Write("Repita o tipo de forma: ");
    int.TryParse(Console.ReadLine()!, out opcaoForma);
}

Console.Clear();
Console.WriteLine("============================");
Console.WriteLine("        Tipo Calculo        ");
Console.WriteLine("============================");
Console.WriteLine("1. Área");
Console.WriteLine("2. Perímetro");
Console.Write("Escolha o tipo de cálculo: ");
int tipoCalculo; int.TryParse(Console.ReadLine()!, out tipoCalculo);
while (tipoCalculo > 2 || tipoCalculo < 1 ) {
    Console.Write("Repita o tipo de cálculo: ");
    int.TryParse(Console.ReadLine()!, out tipoCalculo);
}

Dictionary<int, FormaGeometrica> formasGeometricas = new();
formasGeometricas.Add(1, new Triangulo(tipoCalculo));
formasGeometricas.Add(2, new Quadrado(tipoCalculo));
formasGeometricas.Add(3, new Retangulo(tipoCalculo));
formasGeometricas.Add(4, new Losango(tipoCalculo));
formasGeometricas.Add(5, new Circulo(tipoCalculo));

if (formasGeometricas.ContainsKey(opcaoForma)) {
    FormaGeometrica forma = formasGeometricas[opcaoForma];
    forma.Executar();
}