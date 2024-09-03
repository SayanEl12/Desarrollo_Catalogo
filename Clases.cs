using System;

public class Tipos_producto
{
    //Atributos
    protected int id = 0;
    protected string nombre = "";

    //Constructor
    Tipos_producto() { }
    Tipos_producto(int id, string nombre) 
    {
        this.id = id;
        this.nombre = nombre;
    }

    // Propiedades
    public int Id { get => this.id; set => this.id = value; }
    public string Nombre { get => this.nombre; set => this.nombre = value; }

    // Metodos
}

public class Fabricantes
{
    //Atributos
    protected int id = 0;
    protected string nombre = "";
    protected string contacto = "";

    //Constructor
    Fabricantes() { }
    Fabricantes(int id, string nombre, string contacto)
    {
        this.id = id;
        this.nombre = nombre;
        this.contacto = contacto;
    }

    // Propiedades
    public int Id { get => this.id; set => this.id = value; }
    public string Nombre { get => this.nombre; set => this.nombre = value; }
    public string Contacto { get => this.contacto; set => this.contacto = value; }

    // Metodos
}

public class Productos
{
    //Atributos
    protected int id = 0;
    protected string codigo_producto = "";
    protected string nombre_producto = "";
    protected string descripcion = ""
    protected float precio = 0.0f;
    protected int stock = 0;
    protected List<Tipos_producto> tipos_producto = null;
    protected List<Fabricantes> fabricantes = null;

    //Constructor
    Productos() { }
    Productos(int id, List<Tipos_producto> tipos_producto, string codigo_producto, string nombre_producto, string descripcion,
        List<Fabricantes> fabricantes, float precio, int stock)
    {
        this.id = id;
        this.tipos_producto = tipos_producto;
        this.codigo_producto = codigo_producto;
        this.nombre_producto = nombre_producto;
        this.descripcion = descripcion;
        this.fabricantes = fabricantes;
        this.precio = precio;
        this.stock = stock;
    }

    // Propiedades
    public int Id { get => this.id; set => this.id = value; 
    public string Codigo_producto { get => this.nombre_producto; set => this.nombre_producto = value; }
    public string Descripcion { get => this.descripcion; set => this.descripcion = value; 
    public float Precio{ get => this.precio; set => this.precio = value; }
    public int stock{ get => this.stock; set => this.stock = value; }
    public List<Tipos_producto> Tipos_producto { get => this.tipos_producto; set => this.tipos_producto = value; }
    public List<Fabricantes> Fabricantes { get => this.fabricantes; set => this.fabricantes = value; }

    // Metodos
}
public class Paginas
{
    //Atributos
    protected int id = 0;
    protected string titulo = "";
    protected DateTime fecha = null;
    protected float Costo = 0.0 f;
    protected string ciudad = "";
    protected List <Productos> productos = null;
    protected List <Imagenes> imagenes = null;
    protected List <Promociones> promociones = null;

    //Constructor
    Paginas() { }
    Paginas(int id, List<Productos> productos, List<Imagenes> imagenes, string titulo, DateTime fecha, float costo,
        string ciudad, List<Promociones> promociones)
    {
        this.id = id;
        this.productos = productos;
        this.imagenes = imagenes;
        this.titulo = titulo;
        this.fecha = fecha;
        this.costo = costo;
        this.ciudad = ciudad;
        this.promociones = promociones;
    }
    //Propiedades
    public int Id { get => this.id; set => this.id = value; }
    public string titulo {get => this.titulo; set => this.titulo = value; }
    public DateTime fecha {get => this.fecha; set => this.fecha = value;
    public float costo { get => this.costo; set => this.costo = value; }
    public string ciudad { get => this.ciudad; set => this.ciudad = value; }
    public List<Productos> productos { get => this.productos; set => this.productos = value; }
    public List<Imagenes> imagenes { get => this.imagenes; set => this.imagenes = value; }
    public List<Promociones> promociones { get => this.promociones; set => this.promociones = value; }
    //Metodos
}


public class Imagenes
{
    //Atributos
    protected int id = 0;
    protected string nombre = "";
    protected string url = "";

    //Constructor
    Fabricantes() { }
    Fabricantes(int id, string nombre, string url)
    {
        this.id = id;
        this.nombre = nombre;
        this.url = url;
    }

    // Propiedades
    public int Id { get => this.id; set => this.id = value; }
    public string Nombre { get => this.nombre; set => this.nombre = value; }
    public string Url { get => this.url; set => this.url = value; }

    // Metodos
}

public class Promociones
{
    //Atributos
    protected int id = 0;
    protected string nombre = "";
    protected float descuento = 0.0f;
    protected DateTime inicio = null;
    protected DateTime final = null;

    //Constructor
    Fabricantes() { }
    Fabricantes(int id, string nombre, float descuento, DateTime inicio, DateTime final)
    {
        this.id = id;
        this.nombre = nombre;
        this.descuento = descuento;
        this.inicio = inicio;
        this.final = final;
    }

    // Propiedades
    public int Id { get => this.id; set => this.id = value; }
    public string Nombre { get => this.nombre; set => this.nombre = value; }
    public float Descuento { get => this.descuento; set => this.descuento = value; }
    public Datetime Inicio { get => this.inicio; set => this.inicio = value; }
    public Datetime Final { get => this.final; set => this.final= value; }
    // Metodos
}

