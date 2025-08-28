var libro = new Libros();
Libros libro1 = new Libros();
Libros Libro2 = new Estudiosos();

libro.Id = 1;
libro.Titulo = "Cien años de soledad";
libro.Disponible = true;
libro.precio = 45.0m;
libro.Genero = new Generos() { Id = 1, Nombre = "Realismo mágico" };
libro.Autores = new List<Autores>();
libro.Autores.Add(new Autores() { Id = 1, Nombre = "Gabriel García Márquez" });
libro.Autores.Add(new Autores() { Id = 2, Nombre = "Editorial Sudamericana" });

Console.WriteLine(libro.Titulo);
Console.WriteLine(libro.Genero.Nombre);

foreach (var elemento in libro.Autores)
{
    Console.WriteLine(elemento.Nombre);
}

public class Generos
{
    public int Id = 0;
    public string Nombre = "";
}

public class Autores
{
    public int Id = 0;
    public string Nombre = "";
}
public class Libros
{
    public int Id = 0;
    public string Titulo = "";
    public DateTime FechaPublicacion = DateTime.Now;
    public bool Disponible = false;
    public decimal precio = 0.0m;
    public Generos Genero = new Generos();
    public List<Autores> Autores = new List<Autores>();
}
public class Estudiosos : Libros
{
    public string CodigoISBN = "";

}