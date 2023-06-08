namespace EspacioCalculadora;
public class Calculadora{
    private float dato;
    public float Resultado { get => dato; }

    public void Sumar(float termino){
        dato += termino;
    }
    public void Restar(float termino){
        dato -= termino;
    }
    public void Multiplicar(float termino){
        dato *= termino;
    }
    public void Dividir(float termino){
        dato /= termino;
    }
    public void Limpiar(){
        dato = 0;
    }
}