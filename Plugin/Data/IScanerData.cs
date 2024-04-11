namespace SDRSharp.FreqToProscan
{
    public interface IScanerData
    {
        ScanerType ScanerType { get; }
        string Sufix { get; }
    }
}
