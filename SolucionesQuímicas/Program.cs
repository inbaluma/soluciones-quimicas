using SolucionesQuimicas.Forms;

namespace SolucionesQuimicas;
public class Program
{
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Bienvenido());
    }
}