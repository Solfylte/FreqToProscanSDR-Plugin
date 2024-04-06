using System.Collections.Generic;

namespace SDRSharp.FreqToProscan.Data
{
    public struct PluginData : IPluginData
    {
        private List<IFrequencyData> _frequencies;
        private List<string> _proscanFreqLines;

        public PluginData(List<string> proscanFreqLines, 
                          List<IFrequencyData> frequencies)
        {
            _proscanFreqLines = proscanFreqLines;
            _frequencies = frequencies;
        }

        public List<string> ProscanLines => _proscanFreqLines;
        public List<IFrequencyData> Frequencies => _frequencies;
    }
}
