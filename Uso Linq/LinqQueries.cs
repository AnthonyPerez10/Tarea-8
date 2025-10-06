//Clase del video Numero 7
public class LinqQueries
{
    //Video 8: 
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

    }

    public IEnumerable<Book> Todalacoleccion()
    {
        return librosCollection;
    }

    //Video 9: uso de where libros depues del 2000
    public IEnumerable<Book> Librosdespues2000()
    {
        //Extension method
        //return librosCollection.Where(p => p.PublishedDate.Year > 2000); 

        //Query expresion
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
    }

    //Libros qye tenga mas de 250 paginas y el titulo que contega la palabra action
    public IEnumerable<Book> librosConMas250pagConPalabraInAction()
    {
        //Extension Method
        //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));

        //Query expresion
        return from k in librosCollection where k.PageCount > 250 && k.Title.Contains("in Action") select k;
    }

    //Video 11: All and Any
    public bool TodosLoLibroTieneStatus()
    {
        //Extension Method
        return librosCollection.All(p => p.Status != string.Empty);
    }

    //Libros publicados el 2005
    public bool TodosLibrospublicados2005()
    {
        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
    }

    //Video N12: Operador contains
    public IEnumerable<Book> LibrosDePhyton()
    {
        return librosCollection.Where(p => p.Categories.Contains("Python"));
    }

    //Video N13: OrderBy
    public IEnumerable<Book> LibrosJavaPorNombreAscendete()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
    }

    //Video: OrderByDescending
    public IEnumerable<Book> Libros450pagians()
    {
        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
    }

    //Video 14: Take y Skip
    //Selecionar los primeros 3 libros con fecha de publicacion mas reciente. 
    public IEnumerable<Book> TresPrimerosLibrosOrdenadosPorFecha()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java"))
        .OrderByDescending(p => p.PublishedDate)
        .Take(3);
    }
    public IEnumerable<Book> TakeLastTresPrimerosLibrosOrdenadosPorFecha()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java"))
        .OrderByDescending(p => p.PublishedDate)
        .TakeLast(3);
    }

    //Uso de Skip
     public IEnumerable<Book> PrimerosCuatrosLibrosConSkip()
    {
        return librosCollection.Where(p => p.PageCount > 400)
        .Take(4)
        .Skip(2);//Omite los primeros libros
    }
}