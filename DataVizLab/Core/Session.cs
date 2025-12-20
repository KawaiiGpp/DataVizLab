namespace DataVizLab.Core
{
    public class Session(string positionName, string valueName)
    {
        public string PositionName { get; } = positionName;
        public string ValueName { get; } = valueName;

        public List<DataPoint> Data { get; } = [];
    }
}
