using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{

    public interface IProscanDatabaseLinesDataService
    {
        List<IProscanDatabaseLineData> GetData(ScanerType _scanerType,
                                               List<IFrequencyData> _freqenciesData);
    }
}