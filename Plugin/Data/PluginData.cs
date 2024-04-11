using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{
    public struct PluginData : IPluginData
    {
        public List<IProscanDatabaseLineData> ProscanDatabaseLines => _proscanDatabaseLines;
        public List<IFrequencyData> Frequencies => _frequencies;

        private List<IFrequencyData> _frequencies;
        private List<IProscanDatabaseLineData> _proscanDatabaseLines;
        
        public PluginData(List<IProscanDatabaseLineData> proscanDatabaseLines, 
                          List<IFrequencyData> frequencies)
        {
            _proscanDatabaseLines = proscanDatabaseLines;
            _frequencies = frequencies;
        }
    }
}
