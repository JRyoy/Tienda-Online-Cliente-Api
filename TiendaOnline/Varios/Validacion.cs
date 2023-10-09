namespace Varios;

public  class Validacion
{
    public  static void ValidacionCadena(string valor,string error)
    {
        if(valor.Length <=0)
            throw new Exception("error en caracter");

    }
    public static void ValidacionValor(int Valor,string error)
    {
        if (Valor<0)
            throw new Exception("error en caracter"); 
    }
    public static void ValidacionValor(double Valor,string error)
    {
        if (Valor<0)
            throw new Exception("error en caracter"); 
    }    
    
}
