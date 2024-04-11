using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{

    public interface IProscanDatabaseLinesDataService
    {
        List<IProscanDatabaseLineData> GetData(List<IFrequencyData> freqenciesData,
                                                ScanerType scanerType,
                                                string groupFilter);
    }
}