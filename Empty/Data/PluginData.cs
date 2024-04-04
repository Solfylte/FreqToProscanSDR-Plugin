using System.Collections.Generic;

namespace SDRSharp.FreqToProscan.Data
{
    public struct PluginData : IPluginData
    {
        private List<float> _frequencies;
        private List<string> _proscanFreqLines;

        public PluginData(List<string> proscanFreqLines, List<float> frequencies)
        {
            _proscanFreqLines = proscanFreqLines;
            _frequencies = frequencies;
        }

        public List<string> ProscanLines => _proscanFreqLines;
        public List<float> Frequencies => _frequencies;
    }
}
