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
    }
}
