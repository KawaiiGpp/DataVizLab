namespace DataVizLab.Core
{
    public sealed class FileSelector : IDisposable
    {
        private readonly OpenFileDialog control;
        private bool disposed = false;

        public FileSelector()
        {
            control = new()
            {
                Filter = "数据源 (*.txt;*.csv)|*.txt;*.csv",
                FilterIndex = 1,

                CheckPathExists = true,
                CheckFileExists = true,

                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
        }

        public bool TrySelect(out string path)
        {
            ObjectDisposedException.ThrowIf(disposed, this);

            if (control.ShowDialog() == DialogResult.OK)
            {
                path = control.FileName;
                return true;
            }
            else
            {
                path = "";
                return false;
            }
        }

        public void Dispose()
        {
            if (disposed) return;

            disposed = true;
            control.Dispose();
        }
    }
}
