using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace POSUNO1.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new POSUNO1.App(), args);
            host.Run();
        }
    }
}
