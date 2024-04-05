using System.Collections.Generic;

namespace SDRSharp.FreqToProscan.Data
{
    public struct PluginData : IPluginData
    {
        private List<int> _frequencies;
        private List<string> _proscanFreqLines;

        public PluginData(List<string> proscanFreqLines, List<int> frequencies)
        {
            _proscanFreqLines = proscanFreqLines;
            _frequencies = frequencies;
        }

        public List<string> ProscanLines => _proscanFreqLines;
        public List<int> Frequencies => _frequencies;
    }
}
