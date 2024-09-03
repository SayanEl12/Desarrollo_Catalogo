using System;

namespace ConsoleApp1
{
    public class Tipos_producto
    {
        //Atributos
        private int id = 0;
        private string nombre = "";

        // Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }

        // Metodos
    }

    public class Fabricantes
    {
        //Atributos
        private int id = 0;
        private string nombre = "";
        private string contacto = "";

        // Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Contacto { get => this.contacto; set => this.contacto = value; }

        // Metodos
    }

    public class Productos
    {
        //Atributos
        private int id = 0;
        private string codigo_producto = "";
        private string nombre_producto = "";
        private string descripcion = "";
        private float precio = 0.0f;
        private int stock = 0;
        private Tipos_producto? tipo_producto = null;
        private Fabricantes? fabricante = null;

        // Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Codigo_producto { get => this.codigo_producto; set => this.codigo_producto = value; }
        public string Nombre_producto { get => this.nombre_producto; set => this.nombre_producto = value; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }
        public float Precio { get => this.precio; set => this.precio = value; }
        public int Stock { get => this.stock; set => this.stock = value; }
        public Tipos_producto? Tipo_producto { get => this.tipo_producto; set => this.tipo_producto = value; }
        public Fabricantes? Fabricante { get => this.fabricante; set => this.fabricante = value; }

        // Metodos
    }

    public class Imagenes
    {
        //Atributos
        private int id = 0;
        private string nombre = "";
        private string url = "";

        // Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Url { get => this.url; set => this.url = value; }

        // Metodos
    }

    public class Promociones
    {
        //Atributos
        private int id = 0;
        private string nombre = "";
        private float descuento = 0.0f;
        private DateTime? inicio = null;
        private DateTime? final = null;

        // Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public float Descuento { get => this.descuento; set => this.descuento = value; }
        public DateTime? Inicio { get => this.inicio; set => this.inicio = value; }
        public DateTime? Final { get => this.final; set => this.final = value; }

        // Metodos
    }

    public class Paginas
    {
        //Atributos
        protected int id = 0;
        protected string titulo = "";
        protected DateTime? fecha = null;
        protected float costo = 0.0f;
        protected string ciudad = "";
        protected Productos? producto = null;
        protected Imagenes? imagen = null;
        protected Promociones? promocion = null;

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Titulo { get => this.titulo; set => this.titulo = value; }
        public DateTime? Fecha { get => this.fecha; set => this.fecha = value; }
        public float Costo { get => this.costo; set => this.costo = value; }
        public string Ciudad { get => this.ciudad; set => this.ciudad = value; }
        public Productos? Producto { get => this.producto; set => this.producto = value; }
        public Imagenes? Imagen { get => this.imagen; set => this.imagen = value; }
        public Promociones? Promocion { get => this.promocion; set => this.promocion = value; }

        //Metodos
    }

}
