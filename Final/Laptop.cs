namespace Final
{
    public class Laptop : Dispositivos
    {
        public string MemoriaRAM { get; set; }
        public string Almacenamiento { get; set; }

        public Laptop()
        {
            MemoriaRAM = string.Empty;
            Almacenamiento = string.Empty;
        }

    }
}
