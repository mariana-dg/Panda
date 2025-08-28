// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("SISTEMA DE GESTION");

var carro = new Carros();
Carros carro1 = new Carros();
Carros carro2 = new Deportivos();

carro.id = 1;
carro.Marca = "Toyota Corola";
carro.Electrico = false;
carro.precio = 250000.0m;
carro.Tipo = new TiposCarro() { Id = 1, Nombre = "Sedán" };
carro.Accesorios = new List<Accesorios>();
carro.Accesorios.Add(new Accesorios() { Id = 1, Nombre = "Sistema de Navegacion" });
carro.Accesorios.Add(new Accesorios() { Id = 2, Nombre = "Aire Acondicionado" });

Console.WriteLine(carro.Marca);
Console.WriteLine(carro.Tipo.Nombre);
Console.WriteLine(carro.precio);
foreach (var elemento in carro.Accesorios)
{
    Console.WriteLine(elemento.Nombre);
}

public class TiposCarro
{
    public int Id = 0;
    public string Nombre = "";
}

public class Accesorios
{
    public int Id = 0;
    public string Nombre = "";
}

public class Carros
{
    public int id = 0;
    public string Marca = "";
    public DateTime FechaCompra = DateTime.Now;
    public bool Electrico = false;
    public decimal precio = 0.0m;
    public TiposCarro Tipo = new TiposCarro();
    public List<Accesorios> Accesorios = new List<Accesorios>();
}
public class Deportivos : Carros
{
    public string NumeroChasis = "";
}
