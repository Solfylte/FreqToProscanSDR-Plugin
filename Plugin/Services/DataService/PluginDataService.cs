using System;
using System.Collections.Generic;
using SDRSharp.FreqToProscan.Data;

namespace SDRSharp.FreqToProscan
{
    public class PluginDataService : IPluginDataService
    {
        private IFreqXmlDataService _freqXmlFileService;
        private IProscanDatabaseLinesDataService _proscanDatabaseLinesDataService;

        private IPluginData _pluginData;
        private List<IFrequencyData> _freqenciesData;
        private List<IProscanDatabaseLineData> _proscanDatabaseLineDatas;
        private ScanerType _scanerType;

        public PluginDataService(IFreqXmlDataService freqXmlFileService,
                                    IProscanDatabaseLinesDataService proScanChannelDataService)
        {
            _freqXmlFileService = freqXmlFileService;
           _proscanDatabaseLinesDataService = proScanChannelDataService;

            _proscanDatabaseLineDatas = new List<IProscanDatabaseLineData>();
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

            _pluginData = new PluginData(_proscanDatabaseLineDatas,
                                            _freqenciesData);
        }

        private void UpdateFrequenciesData()
        {
            _freqenciesData = new List<IFrequencyData>(_freqXmlFileService.GetData());
        }

        private void UpdateProScanChannelsData()
        {
            _proscanDatabaseLineDatas = new List<IProscanDatabaseLineData>(_proscanDatabaseLinesDataService.GetData(_scanerType, _freqenciesData));
        }
    }
}
