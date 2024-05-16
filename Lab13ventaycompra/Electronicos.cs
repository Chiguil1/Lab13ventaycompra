using System.ComponentModel.DataAnnotations;

namespace Lab13ventaycompra
{
    public class Electronicos : Productos
    {
        public int Tiempogaran {  get; set; }
        public string Voltaje { get; set; }

        public Electronicos() 
        {
            Tiempogaran = 0;
            Voltaje = string.Empty;
        }
    }
}
