using DataVizLab.Forms.Main;

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
                var dateTime = $"{DateTime.Now:yyyy-MM-dd-HH-mm-ss}";
                File.AppendAllText($"ErrorLog-{dateTime}.txt", $"{exception}");

                MessageBox.Show("程序遭遇无法处理的致命错误。\n" +
                    "错误信息已记录，请联系开发者。\n" +
                    $"{exception.Message}", "程序崩溃");
            }
        }
    }
}