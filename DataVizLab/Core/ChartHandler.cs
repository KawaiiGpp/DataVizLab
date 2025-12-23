using ScottPlot;

namespace DataVizLab.Core
{
    public class ChartHandler(FormsPlot formsPlot)
    {
        private readonly FormsPlot control = formsPlot;

        public void Apply(Session session)
        {
            Reset();

            var plot = control.Plot;
            var data = session.Data;

            var positions = data.Select(data => data.Position).ToArray();
            var values = data.Select(data => data.Value).ToArray();
            var labels = data.Select(data => data.Label).ToArray();

            plot.AddScatter(positions, values);

            plot.XAxis.TickLabelFormat(i =>
            {
                var x = (int)Math.Round(i);

                if ((uint) x >= labels.Length) return "";
                else return labels[(int)i];
            });
        }

        public void Update() => control.Refresh();

        public void Adapt() => control.Plot.AxisAuto();

        public void Reset() => control.Plot.Clear();
    }
}
