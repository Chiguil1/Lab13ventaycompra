namespace Lab13ventaycompra
{
    public class Productos
    {
        public string Codigo {  get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Preciocompra {  get; set; }

        public int Precioventa {  get; set; }

        public Productos() 
        {
            Codigo = string.Empty;
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }
    }
}
