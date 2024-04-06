using System;
using System.Collections.Generic;
using SDRSharp.FreqToProscan.Data;
using SDRSharp.FreqToProscan.Services;

namespace SDRSharp.FreqToProscan
{
    public class PluginDataService : IPluginDataService
    {
        private IPluginData _pluginData;

        private IFreqXmlDataService _freqXmlFileService;
        private List<IFrequencyData> _freqenciesData;
        private List<IGridWindowData> _gridWindowData;
        private List<string> _proScanChannelsData;

        public PluginDataService(IFreqXmlDataService freqXmlFileService)
        {
            _freqXmlFileService = freqXmlFileService;

            _proScanChannelsData = new List<string>();
            _freqenciesData = new List<IFrequencyData>();
            _gridWindowData = new List<IGridWindowData>();
        }

        public IPluginData GetData()
        {
            UpdateData();
            return _pluginData;
        }

        private void UpdateData()
        {
            UpdateFrequenciesData();
            UpdateProScanChannelsData();
            UpdateGridWindowData();

            _pluginData = new PluginData(_proScanChannelsData,
                                            _gridWindowData,
                                            _freqenciesData);
        }

        private void UpdateFrequenciesData()
        {
            _freqenciesData = new List<IFrequencyData>(_freqXmlFileService.GetData());
        }

        private void UpdateProScanChannelsData()
        {
            _proScanChannelsData.Clear();

            foreach (IFrequencyData frequencyData in _freqenciesData)
                _proScanChannelsData.Add(frequencyData.Name);
        }

        private void UpdateGridWindowData()
        {
            _gridWindowData.Clear();

            foreach (IFrequencyData frequencyData in _freqenciesData)
                _gridWindowData.Add(new GridWindowData(frequencyData));
        }
    }
}
