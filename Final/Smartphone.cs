namespace Final
{
    public class Smartphone : Dispositivos
    {
        public string SistemaOp { get; set; }
        public string NumCamaras { get; set; }

        public Smartphone() 
        {
            SistemaOp = string.Empty;
            NumCamaras = string.Empty;
        }

    }
}
