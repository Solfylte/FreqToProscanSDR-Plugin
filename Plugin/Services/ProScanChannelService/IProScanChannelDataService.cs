using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{

    public interface IProScanChannelDataService
    {
        List<string> GetData(ScanerType _scanerType, List<IFrequencyData> _freqenciesData);
    }
}