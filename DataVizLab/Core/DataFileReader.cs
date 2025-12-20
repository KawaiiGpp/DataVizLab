using System.Text;

namespace DataVizLab.Core
{
    public sealed class DataFileReader : IDisposable
    {
        private readonly Encoding encoding;
        private readonly StreamReader reader;
        private bool disposed;

        public DataFileReader(string path, Encoding? encoding = null)
        {
            this.encoding = encoding ?? Encoding.UTF8;

            reader = new StreamReader(path, this.encoding);
            disposed = false;
        }

        public Session? Read() // change Session? to Result<Session?>
        {
            string? line;
            Session? session = null;
            var index = 0;

            while ((line = reader.ReadLine()) != null)
            {
                var splited = line.Split(',');
                if (splited.Length < 2) return null;

                if (session != null)
                {
                    var label = splited[0];
                    if (!double.TryParse(splited[1], out double value)) 
                        return null;

                    session.Data.Add(new DataPoint(label, index, value));
                }
                else session = new Session(splited[0], splited[1]);
            }

            return session;
        }

        public void Dispose()
        {
            if (disposed) return;

            reader.Dispose();
            disposed = true;
        }
    }
}
