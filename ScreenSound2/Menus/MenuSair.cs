using ScreenSound2.Modelos;
namespace ScreenSound2.Menus;
internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("\nTchau tchau :)");
    }
}