namespace DataVizLab.Tools
{
    public class ExceptionHandler(string? operation, Exception exception)
    {
        private readonly string? operation = operation;
        private readonly Exception exception = exception;

        public void ShowMessageBox()
        {
            var message = exception.Message;
            var append = operation == null ? string.Empty : $"在{operation}时";

            MessageBox.Show($"{append}捕获到异常：\n{message}", "程序异常");
        }

        public void LogException()
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            var fileName = $"ErrorLog-{operation}-{date}.txt";

            File.WriteAllText(fileName, exception.ToString());
        }

        public static void Launch(Exception exception, string? operation = null)
        {
            var handler = new ExceptionHandler(operation, exception);

            handler.ShowMessageBox();
            handler.LogException();
        }
    }
}
