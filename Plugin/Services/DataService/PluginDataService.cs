using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{
    public class PluginDataService : IPluginDataService
    {
        private IFreqXmlDataService _freqXmlFileService;
        private IProscanDbLinesDataService _proscanDbLinesDataService;

        private IPluginData _pluginData;
        private List<IFrequencyData> _freqenciesData;
        private List<IProscanDbLineData> _proscanDbLineDatas;
        private ScanerType _scanerType;
        private string _groupFilter;

        public PluginDataService(IFreqXmlDataService freqXmlFileService,
                                    IProscanDbLinesDataService proScanChannelDataService)
        {
            _freqXmlFileService = freqXmlFileService;
           _proscanDbLinesDataService = proScanChannelDataService;

            _proscanDbLineDatas = new List<IProscanDbLineData>();
            _freqenciesData = new List<IFrequencyData>();
        }

        public IPluginData GetData(ScanerType scanerType, string groupFilter)
        {
            _scanerType = scanerType;
            _groupFilter = groupFilter;

            UpdateData();

            return _pluginData;
        }

        private void UpdateData()
        {
            UpdateFrequenciesData();
            UpdateProScanChannelsData();

            _pluginData = new PluginData(_proscanDbLineDatas,
                                            _freqenciesData);
        }

        private void UpdateFrequenciesData() => 
            _freqenciesData = new List<IFrequencyData>(_freqXmlFileService.GetData());

        private void UpdateProScanChannelsData()
        {
            _proscanDbLineDatas = new List<IProscanDbLineData>(_proscanDbLinesDataService.GetData(_freqenciesData, _scanerType, _groupFilter));
        }
    }
}
