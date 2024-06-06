namespace Final
{
    public class Dispositivos
    {
        public string NumeroSerie {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Dispositivos() 
        { 
            NumeroSerie = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty;
        }
    }
}
