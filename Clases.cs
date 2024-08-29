using System;

public class Tipos_productos
{
    //Atributos
    protected int id = 0;
    protected string nombre = "";

    //Constructor
    Tipos_productos() { }
    Tipos_productos(int id, string nombre) 
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
    protected string titulo = "";
    protected DateTime fecha = DateTime.Now;


    //Constructor
    Productos() { }
    Productos(int id, string nombre, string contacto)
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