using Dominio;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

public class Articulo
{
    private Categoria _categoria;
    private Marca _marca;

    public List<Imagen> Imagenes = new List<Imagen>();
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public Marca marca
    {
        get
        {
            return _marca ?? new Marca();
        }
        set
        {
            _marca = value;
        }
    }
    public Categoria categoria
    {
        get
        {
            return _categoria ?? new Categoria();
        }
        set
        {
            _categoria = value;
        }
    }

    public decimal Precio { get; set; }

    public void AgregarImagen(Imagen img)
    {
        Imagenes.Add(img);
    }

    public string VerPrimeraImagen()
    {
        if (Imagenes.Count > 0)
        {
            return Imagenes[0].Url;
        }
        return null;
    }
}