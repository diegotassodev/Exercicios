namespace Formas.Modelos;
internal class Triangulo : FormaGeometrica {
    private double baseTriangulo;
    private double alturaTriangulo;
    private double ladoTriangulo;
    private int tipoTriangulo;
    private int tipoCalculo;
    private double area;
    private double perimetro;
    public Triangulo(int tipoCalculo) {
        this.tipoCalculo = tipoCalculo;
    }
    public override void Executar() {
        base.Executar();
        Console.WriteLine("==============================");
        Console.WriteLine("        Tipo Triângulo        ");
        Console.WriteLine("==============================");
        Console.WriteLine("1. Equilátero");
        Console.WriteLine("2. Isóceles");
        Console.WriteLine("3. Escaleno");
        Console.Write("Escolha o tipo do triângulo: ");
        int.TryParse(Console.ReadLine()!, out tipoTriangulo); Thread.Sleep(500);
        if (tipoCalculo == 1) CalcularArea();
        else if (tipoCalculo == 2) CalcularPerimetro();
    }
    public override void CalcularArea() {
        base.CalcularArea();
        switch (tipoTriangulo) {
            case 1: CalcularAreaEquilatero(); break;
            case 2: CalcularAreaIsoceles(); break;
            case 3: CalcularAreaEscaleno(); break;
        }
    }
    public override void CalcularPerimetro() {
        base.CalcularPerimetro();
        switch (tipoTriangulo) {
            case 1: CalcularPerimetroEquilatero(); break;
            case 2: CalcularPerimetroIsoceles(); break;
            case 3: CalcularPerimetroEscaleno(); break;
        }
    }
    private void CalcularAreaEquilatero() {
        Console.Write("Qual valor do Lado: ");
        double.TryParse(Console.ReadLine()!, out ladoTriangulo);
        area = Math.Pow(ladoTriangulo,2) * (Math.Sqrt(3) / 4);
        Console.Write($"O valor da área do triângulo é de {area}");
        Console.ReadKey();
    }
    private void CalcularPerimetroEquilatero() {
        Console.Write("Qual valor do Lado: ");
        double.TryParse(Console.ReadLine()!, out ladoTriangulo);
        perimetro = ladoTriangulo * 3;
        Console.Write($"O valor do perímetro do triângulo é de {perimetro}");
        Console.ReadKey();
    }
    private void CalcularAreaIsoceles() {
        Console.Write("Qual valor da base do triângulo: ");
        double.TryParse(Console.ReadLine()!, out baseTriangulo);
        Console.Write("Qual valor da altura do triângulo: ");
        double.TryParse(Console.ReadLine()!, out alturaTriangulo);
        area = (baseTriangulo * alturaTriangulo) / 2;
        Console.Write($"O valor da área do triângulo é de {area}");
        Console.ReadKey();
    }
    private void CalcularPerimetroIsoceles() {
        Console.Write("Qual valor do Lado: ");
        double.TryParse(Console.ReadLine()!, out ladoTriangulo);
        Console.Write("Qual valor da base do triângulo: ");
        double.TryParse(Console.ReadLine()!, out baseTriangulo);
        perimetro = 2*ladoTriangulo + baseTriangulo;
        Console.Write($"O valor do perímetro do triângulo é de {perimetro}");
        Console.ReadKey();
    }
    private void CalcularAreaEscaleno() {
        Console.Write("Qual valor da base do triângulo: ");
        double.TryParse(Console.ReadLine()!, out baseTriangulo);
        Console.Write("Qual valor da altura do triângulo: ");
        double.TryParse(Console.ReadLine()!, out alturaTriangulo);
        area = (baseTriangulo * alturaTriangulo) / 2;
        Console.Write($"O valor da área do triângulo é de {area}");
        Console.ReadKey();
    }
    private void CalcularPerimetroEscaleno() {
        Console.Write("Qual valor do Lado 1: ");
        double.TryParse(Console.ReadLine()!, out ladoTriangulo);
        perimetro = ladoTriangulo;
        Console.Write("Qual valor do Lado 2: ");
        double.TryParse(Console.ReadLine()!, out ladoTriangulo);
        perimetro += ladoTriangulo;
        Console.Write("Qual valor do Lado 3: ");
        double.TryParse(Console.ReadLine()!, out ladoTriangulo);
        perimetro += ladoTriangulo;
        Console.Write($"O valor do perímetro do triângulo é de {perimetro}");
        Console.ReadKey();
    }
}