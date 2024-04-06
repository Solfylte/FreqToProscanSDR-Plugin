namespace SDRSharp.FreqToProscan.Data
{
    public interface IGridWindowData
    {
        string Frequency { get; }
        Unit Unit { get; set; }
        string Name { get; }
        string GroupName { get; }
        string DetectorType { get; }
        int FilterBandwidth { get; }
    }
}
