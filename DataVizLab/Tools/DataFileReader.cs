using System.Text;
using DataVizLab.Core;
using DataVizLab.Utils;

namespace DataVizLab.Tools
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

        public Result<Session> Read()
        {
            ObjectDisposedException.ThrowIf(disposed, this);

            string? line;
            Session? session = null;
            var index = 0;

            while ((line = reader.ReadLine()) != null)
            {
                var counter = index + 1;
                var splited = line.Split(',');

                if (splited.Length < 2)
                {
                    return Result<Session>.Failure($"无法解析第{counter}行：{line}");
                }

                if (session != null)
                {
                    var label = splited[0];

                    if (double.TryParse(splited[1], out double value))
                    {
                        session.Data.Add(new DataPoint(label, index++, value));
                        continue;
                    }

                    return Result<Session>.Failure($"无法解析第{counter}行的数值：{splited[1]}");
                }
                else
                {
                    session = new Session(splited[0], splited[1]);
                }
            }

            return session != null ?
                Result<Session>.Success(session) :
                Result<Session>.Failure($"文件没有任何内容，无法解析。");
        }

        public void Dispose()
        {
            if (disposed) return;

            reader.Dispose();
            disposed = true;
        }
    }
}
