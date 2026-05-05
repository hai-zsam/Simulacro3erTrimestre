class libro
{
    private string titulo;
    private string autor;
    private int anyo;
    private bool disponible;

    public libro(string titulo, string autor, int anyo, bool disponible)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anyo = anyo;
        this.disponible = disponible;
    }
    public String getTitulo()
    {
        return this.titulo;
    }

    public String getAutor()
    {
        return this.autor;
    }

    public int getAnyo()
    {
        return this.anyo;
    }

    public bool getDisponible()
    {
        return this.disponible;
    }

    public String toString()
    {
        return "Titulo: " + this.titulo + ", Autor: " + this.autor + ", Año: " + this.anyo + ", Disponible: " + this.disponible;
    }

    // 1.1 a) Determina si son atributos publicos(+) o privados(-)
    // 1.1 b) El atributo disponible es booleano. Toma los valores true o false.
    // 1.1 c) El método toString() devuelve los valores de los atributos en formato String.


}