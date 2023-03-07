public class Program
{

    public enum MeuConsole : int
    {
        xbox = 0,
        play = 1,
    }

    public static void Main(string[] args)
    {
        //Instancia o Factory
        VideogameFactory vgf = null;
        
        var console = MeuConsole.xbox;
        //Chama o Factory desejado
        switch(console)
        {
            case MeuConsole.play:
                vgf = new PlaystationFactory();
                break;
            case MeuConsole.xbox:
                vgf = new XboxFactory();
                break;
        }

        //Initialize
        if(vgf != null) vgf.Start();

        Console.ReadKey();
    }
}