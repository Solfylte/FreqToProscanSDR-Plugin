using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{
    public interface IPluginData
    {
        List<IProscanDbLineData> ProscanDbLines { get; }
        List<IFrequencyData> Frequencies { get; }
    }
}
