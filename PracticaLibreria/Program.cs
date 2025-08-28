var libro = new Libros();
Libros libro1 = new Libros();
Libros Libro2 = new Estudiosos();

libro.Id = new Libros();
libro.Titulo = "Cien años de soledad";




public class Generos
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