using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{
    public struct PluginData : IPluginData
    {
        public List<IProscanDbLineData> ProscanDbLines => _proscanDbLines;
        public List<IFrequencyData> Frequencies => _frequencies;

        private List<IFrequencyData> _frequencies;
        private List<IProscanDbLineData> _proscanDbLines;
        
        public PluginData(List<IProscanDbLineData> proscanDbLines, 
                          List<IFrequencyData> frequencies)
        {
            _proscanDbLines = proscanDbLines;
            _frequencies = frequencies;
        }
    }
}
