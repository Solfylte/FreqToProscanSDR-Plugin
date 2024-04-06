using System.Collections.Generic;

namespace SDRSharp.FreqToProscan.Data
{
    public struct PluginData : IPluginData
    {
        private List<IFrequencyData> _frequencies;
        private List<string> _proscanFreqLines;
        private List<IGridWindowData> _gridWindowData;

        public PluginData(List<string> proscanFreqLines, 
                          List<IGridWindowData> gridWindowDatas, 
                          List<IFrequencyData> frequencies)
        {
            _proscanFreqLines = proscanFreqLines;
            _frequencies = frequencies;
            _gridWindowData = gridWindowDatas;
        }

        public List<string> ProscanLines => _proscanFreqLines;
        public List<IFrequencyData> Frequencies => _frequencies;
        public List<IGridWindowData> GridWindowDatas => _gridWindowData;
    }
}
