namespace Lab13ventaycompra
{
    public class Alimentos : Productos
    {
        public DateTime Fechaven {  get; set; } 
        public string Unidadmed { get; set; }

        public Alimentos()
        {
            Unidadmed = string.Empty;
        }
    }
}
