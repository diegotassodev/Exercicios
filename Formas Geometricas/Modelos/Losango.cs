namespace Formas.Modelos;

internal class Losango: FormaGeometrica {
    private double diagonalMaior;
    private double diagonalMenor;
    private double ladoLosango;
    private double area;
    private double perimetro;
    private int tipoCalculo;
    public Losango(int tipoCalculo) {
        this.tipoCalculo = tipoCalculo;
    }
    public override void Executar() {
        base.Executar();
        if (tipoCalculo == 1) CalcularArea();
        else if (tipoCalculo == 2) CalcularPerimetro();
        Console.Clear();
    }
    public override void CalcularArea() {
        base.CalcularArea();
        Console.Write("Qual valor da diagonal maior: ");
        double.TryParse(Console.ReadLine()!, out diagonalMaior);
        Console.Write("Qual valor da diagonal menor: ");
        double.TryParse(Console.ReadLine()!, out diagonalMenor);
        area = (diagonalMaior * diagonalMenor) / 2;
        Console.Write($"O valor da área do losango é de {area}");
        Console.ReadKey();
    }
    public override void CalcularPerimetro() {
        base.CalcularPerimetro();
        Console.WriteLine("Qual o valor do lado do losango: ");
        double.TryParse(Console.ReadLine()!, out ladoLosango);
        perimetro = ladoLosango * 4;
        Console.Write($"O valor da área do losango é de {perimetro}");
        Console.ReadKey();
    }
}