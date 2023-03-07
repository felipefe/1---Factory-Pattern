public class Playstation : IVideogame
{
    public void ConfigurarVideogame()
    {
        Console.WriteLine("Playstation configurado! Pronto para jogar!");
    }

    public void Jogar()
    {
        Console.WriteLine("Jogando Playstation!");
    }

    public void LigarVideogame()
    {
        Console.WriteLine("Playstation ligado!");
        ConfigurarVideogame();
    }
}