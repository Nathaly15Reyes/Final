namespace Final
{
    public class Tablet : Dispositivos
    {
        public string TamanoPantalla {  get; set; }
        public string Soporte { get; set; }

        public Tablet() 
        {
            TamanoPantalla = string.Empty;
            Soporte = string.Empty;
        }
    }
}
