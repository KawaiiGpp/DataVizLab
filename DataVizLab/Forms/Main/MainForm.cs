using DataVizLab.Core;

namespace DataVizLab.Forms.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupChart();
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
            // TODO read the file.
        }
    }
}
