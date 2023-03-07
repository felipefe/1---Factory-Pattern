public abstract class VideogameFactory
{
    //Pegamos o product factory e iniciamos
    public void Start()
    {
        IVideogame videogame = CreateFactory();
        videogame.LigarVideogame();
        videogame.Jogar();
    }

    //Devemos implementar a criação em cada filho
    public abstract IVideogame CreateFactory();
}