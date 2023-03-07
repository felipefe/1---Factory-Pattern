public class Xbox : IVideogame
{
    public void ConfigurarVideogame()
    {
        Console.WriteLine("Xbox configurado! Pronto para jogar!");
    }

    public void Jogar()
    {
        Console.WriteLine("Jogando Xbox!");
    }

    public void LigarVideogame()
    {
        Console.WriteLine("Xbox ligado!");
        ConfigurarVideogame();
    }
}