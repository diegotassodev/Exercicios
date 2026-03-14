namespace Formas.Modelos;

internal class Retangulo: FormaGeometrica {
    private double comprimentoRetangulo;
    private double larguraRetangulo;
    private double area;
    private double perimetro;
    private int tipoCalculo;
    public Retangulo(int tipoCalculo) {
        this.tipoCalculo = tipoCalculo;
    }
    public override void Executar() {
        base.Executar();
        Console.Write("Qual valor do comprimento: ");
        double.TryParse(Console.ReadLine()!, out comprimentoRetangulo);
        Console.Write("Qual valor da largura: ");
        double.TryParse(Console.ReadLine()!, out larguraRetangulo);
        if (tipoCalculo == 1) CalcularArea();
        else if (tipoCalculo == 2) CalcularPerimetro();
        Console.Clear();
    }
    public override void CalcularArea() {
        base.CalcularArea();
        area = larguraRetangulo * comprimentoRetangulo;
        Console.Write($"O valor da área do retângulo é de {area}");
        Console.ReadKey();
    }
    public override void CalcularPerimetro() {
        base.CalcularPerimetro();
        perimetro = (larguraRetangulo*2) + (comprimentoRetangulo*2);
        Console.Write($"O valor da área do retângulo é de {perimetro}");
        Console.ReadKey();
    }
}