using System.Collections.Generic;
using SDRSharp.FreqToProscan.Data;
using SDRSharp.FreqToProscan.Services;

namespace SDRSharp.FreqToProscan
{
    public class FreqToProscanService: IFreqToProscanService
    {
        public IPluginData GetData => _pluginFreqData;

        private IPluginData _pluginFreqData;

        private IFreqXmlDataService _freqXmlFileService;
        private List<IFrequencyData> _freqenciesData;

        public FreqToProscanService(IFreqXmlDataService freqXmlFileService)
        {
            _freqXmlFileService = freqXmlFileService;
            UpdateData();
        }

        public void UpdateData()
        {
            _freqenciesData = _freqXmlFileService.GetData();
            _pluginFreqData = new PluginData(GetProscanLines(), GetFrequencies());
        }

        private List<string> GetProscanLines()
        {
            List<string> proscanLines = new List<string>();

            foreach (IFrequencyData frequencyData in _freqenciesData)
            {
                proscanLines.Add(frequencyData.Name);
            }

            return proscanLines;
        }

        private List<int> GetFrequencies()
        {
            List<int> freqValueLines = new List<int>();

            foreach (IFrequencyData frequencyData in _freqenciesData)
            {
                freqValueLines.Add(frequencyData.Frequency);
            }

            return freqValueLines;
        }
    }

    public interface IFreqToProscanService
    {
        IPluginData GetData { get; }
        void UpdateData();
    }
}
