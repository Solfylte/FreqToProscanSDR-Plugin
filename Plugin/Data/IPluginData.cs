using SDRSharp.FreqToProscan.Data;
using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{
    public interface IPluginData
    {
        List<string> ProscanLines { get; }
        List<IFrequencyData> Frequencies { get; }
    }
}
