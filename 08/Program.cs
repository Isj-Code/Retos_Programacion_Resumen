var Uno = new ClaseEjemplo();
Uno.Saludo("Pepito");
Uno.Saludo();


public class ClaseEjemplo
{
    private string saludo = "Hola, ";
    public string MiNombre { get; set; }
    public string Edad { get; private set; }

    public void Saludo(string? name = "Anónimo")
    {
        Console.WriteLine($"{saludo}{name}");
    }
}