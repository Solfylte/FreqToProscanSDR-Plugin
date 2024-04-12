namespace SDRSharp.FreqToProscan
{
    public interface IPluginDataService
    {
        IPluginData GetData(ScanerType scanerType, string groupFilter);
    }
}
