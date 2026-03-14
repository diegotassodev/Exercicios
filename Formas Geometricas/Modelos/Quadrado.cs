namespace Formas.Modelos;

internal class Quadrado: FormaGeometrica {
    private double ladoQuadrado;
    private double area;
    private double perimetro;
    private int tipoCalculo;
    public Quadrado(int tipoCalculo) {
        this.tipoCalculo = tipoCalculo;
    }
    public override void Executar() {
        base.Executar();
        Console.Write("Qual valor do Lado: ");
        double.TryParse(Console.ReadLine()!, out ladoQuadrado);
        if (tipoCalculo == 1) CalcularArea();
        else if (tipoCalculo == 2) CalcularPerimetro();
        Console.Clear();
    }
    public override void CalcularArea() {
        base.CalcularArea();
        area = ladoQuadrado * ladoQuadrado;
        Console.WriteLine($"O valor da área do quadrado é de {area}");
        Console.ReadKey();
    }
    public override void CalcularPerimetro() {
        base.CalcularPerimetro();
        perimetro = ladoQuadrado * 4;
        Console.WriteLine($"O valor do perímetro do quadrado é de {perimetro}");
        Console.ReadKey();
    }
}