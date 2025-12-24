using DataVizLab.Forms.Main;
using DataVizLab.Tools;

namespace DataVizLab
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
            catch (Exception exception)
            {
                ExceptionHandler.Launch(exception);
            }
        }
    }
}