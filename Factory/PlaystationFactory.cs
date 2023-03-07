public class PlaystationFactory : VideogameFactory
{
    public override IVideogame CreateFactory()
    {
        return new Playstation();
    }
}