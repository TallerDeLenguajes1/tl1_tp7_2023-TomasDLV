namespace EspacioCalculadora
{
    public class Calculadora
    {
        private float dato;
        public float Resultado { get => Dato; }
        public float Dato { get => dato; set => dato = value; }

        public void Sumar(float termino)
        {
            Dato += termino;
        }
        public void Restar(float termino)
        {
            Dato -= termino;
        }
        public void Multiplicar(float termino)
        {
            Dato *= termino;
        }
        public void Dividir(float termino)
        {
            Dato /= termino;
        }
        public void Limpiar()
        {
            Dato = 0;
        }
    }
}
