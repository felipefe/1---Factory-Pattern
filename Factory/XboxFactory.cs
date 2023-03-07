public class XboxFactory : VideogameFactory
{
    public override IVideogame CreateFactory()
    {
        return new Xbox();
    }
}