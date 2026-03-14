namespace Formas.Modelos;

internal class Circulo: FormaGeometrica {
    private double raioCirculo;
    private double area;
    private double perimetro;
    private int tipoCalculo;
    public Circulo(int tipoCalculo) {
        this.tipoCalculo = tipoCalculo;
    }
    public override void Executar() {
        Console.Write("Qual valor do raio do círculo: ");
        double.TryParse(Console.ReadLine()!, out raioCirculo);
        if (tipoCalculo == 1) CalcularArea();
        else if (tipoCalculo == 2) CalcularPerimetro();
        Console.Clear();
    }
    public override void CalcularArea() {
        base.CalcularArea();
        area = Math.PI * raioCirculo * raioCirculo;
        Console.WriteLine($"O valor da área do círculo é de {area}");
        Console.ReadKey();
    }
    public override void CalcularPerimetro() {
        base.CalcularPerimetro();
        perimetro = Math.PI * raioCirculo * 2;
        Console.WriteLine($"O valor do perímetro do círculo é de {perimetro}");
        Console.ReadKey();
    }
}