namespace Varios;

public class Validacion
{
    public static void ValidacionCadena(string valor, string error)
    {
        if (valor.Length <= 0)
            throw new Exception("error en caracter");

    }
    public static void ValidacionValor(int Valor, string error)
    {
        if (Valor < 0)
            throw new Exception("error en caracter");
    }
    public static void ValidacionValor(double Valor, string error)
    {
        if (Valor < 0)
            throw new Exception("error en caracter");
    }
    public static void ValidarEmail(string Email, string error)
    {
        if (!Email.Contains("@gmail.com") || !Email.Contains("@hotmail.com"))
        {
        }
        else
            throw new Exception("Tiene que contener @gmail.com o @hotmail.com");
    }

}

