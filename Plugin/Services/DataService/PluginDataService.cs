using System;
using System.Collections.Generic;
using SDRSharp.FreqToProscan.Data;

namespace SDRSharp.FreqToProscan
{
    public class PluginDataService : IPluginDataService
    {
        private IFreqXmlDataService _freqXmlFileService;
        private IProScanChannelDataService _proScanChannelsDataService;

        private IPluginData _pluginData;
        private List<IFrequencyData> _freqenciesData;
        private List<string> _proScanChannelsData;
        private ScanerType _scanerType;

        public PluginDataService(IFreqXmlDataService freqXmlFileService,
                                    IProScanChannelDataService proScanChannelDataService)
        {
            _freqXmlFileService = freqXmlFileService;
           _proScanChannelsDataService = proScanChannelDataService;

            _proScanChannelsData = new List<string>();
            _freqenciesData = new List<IFrequencyData>();
        }

        public IPluginData GetData(ScanerType scanerType)
        {
            _scanerType = scanerType;

            UpdateData();

            return _pluginData;
        }

        private void UpdateData()
        {
            UpdateFrequenciesData();
            UpdateProScanChannelsData();

            _pluginData = new PluginData(_proScanChannelsData,
                                            _freqenciesData);
        }

        private void UpdateFrequenciesData()
        {
            _freqenciesData = new List<IFrequencyData>(_freqXmlFileService.GetData());
        }

        private void UpdateProScanChannelsData()
        {
            _proScanChannelsData = new List<string>(_proScanChannelsDataService.GetData(_scanerType, _freqenciesData));
        }
    }
}
