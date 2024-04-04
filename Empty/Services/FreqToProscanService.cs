using System.Collections.Generic;
using SDRSharp.FreqToProscan.Data;

namespace SDRSharp.FreqToProscan
{
    public class FreqToProscanService: IFreqToProscanService
    {
        public IPluginData GetData => _pluginFreqData;

        private IPluginData _pluginFreqData;

        public FreqToProscanService()
        {
            UpdateData();
        }

        public void UpdateData()
        {
            _pluginFreqData = new PluginData(GetProscanLines(), GetFrequencies());
        }

        private List<string> GetProscanLines()
        {
            return new List<string>();
        }

        private List<float> GetFrequencies()
        {
            return new List<float>();
        }
    }

    public interface IFreqToProscanService
    {
        IPluginData GetData { get; }
        void UpdateData();
    }
}
