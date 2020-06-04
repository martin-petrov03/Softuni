namespace TemplatePattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            TwelveGrain tg = new TwelveGrain();
            Sourdough sd = new Sourdough();
            WholeWheat ww = new WholeWheat();

            tg.Make();
            sd.Make();
            ww.Make();
        }
    }
}
