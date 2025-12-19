using ScottPlot;

namespace DataVizLab.Core
{
    public class ChartHandler(FormsPlot formsPlot)
    {
        private readonly FormsPlot control = formsPlot;

        public void Apply(Session session)
        {
            var plot = control.Plot;
            var data = session.Data;

            var positions = data.Select(data => data.Position).ToArray();
            var values = data.Select(data => data.Value).ToArray();
            var labels = data.Select(data => data.Label).ToArray();

            plot.AddScatter(positions, values);
        }

        public void Adapt()
        {
            control.Plot.AxisAuto();
            control.Refresh();
        }

        public void Reset()
        {
            control.Plot.Clear();
            Adapt();
        }
    }
}
