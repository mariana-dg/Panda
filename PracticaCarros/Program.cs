// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("SISTEMA DE GESTION");

var carro = new Carros();
Carros carro1 = new Carros();
Carros carro2 = new Deportivos();
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
