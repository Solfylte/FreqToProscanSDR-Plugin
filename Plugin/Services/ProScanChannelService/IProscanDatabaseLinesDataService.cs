using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{

    public interface IProscanDbLinesDataService
    {
        List<IProscanDbLineData> GetData(List<IFrequencyData> freqenciesData,
                                                ScanerType scanerType,
                                                string groupFilter);
    }
}