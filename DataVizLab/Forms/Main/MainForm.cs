using DataVizLab.Core;

namespace DataVizLab.Forms.Main
{
    public partial class MainForm : Form
    {
        private readonly ChartHandler chartHandler;

        public MainForm()
        {
            InitializeComponent();
            SetupChart();

            chartHandler = new(chart);
        }

        private void SetupChart()
        {
            var config = chart.Configuration;

            config.LockVerticalAxis = true;
            config.LockHorizontalAxis = true;
            config.ScrollWheelZoom = false;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            using var fileSelector = new FileSelector();
            if (!fileSelector.TrySelect(out string path)) return;

            using var reader = new DataFileReader(path);
            var result = reader.Read();

            if (result.IsFailed)
            {
                MessageBox.Show($"{result.Error}", "∂¡»° ß∞‹");
                return;
            }

            chartHandler.Reset();

            var session = result.Value;
            chartHandler.Setup(session);
            chartHandler.Apply(session);

            chartHandler.Adapt();
            chartHandler.Update();
        }
    }
}
