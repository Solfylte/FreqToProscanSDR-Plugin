using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{
    public interface IPluginData
    {
        List<IProscanDatabaseLineData> ProscanDatabaseLines { get; }
        List<IFrequencyData> Frequencies { get; }
    }
}
