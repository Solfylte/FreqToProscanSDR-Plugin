using System.Collections.Generic;
using System.Text;

namespace SDRSharp.FreqToProscan
{
    public class ProScanChannelDataService : IProScanChannelDataService
    {
        private IScanerDataFabric _scanerDataFabric;

        private List<IScanerData> _scanerDatas;
        private List<IFrequencyData> _freqenciesData;
        private List<string> _proScanChannelsData;

        private ScanerType _selectedScanerType;

        public ProScanChannelDataService(IScanerDataFabric scanerDataFabric)
        {
            _scanerDataFabric = scanerDataFabric;
            _proScanChannelsData = new List<string>();
            _scanerDatas = _scanerDataFabric.CreateScanerDatas();
        }

        public List<string> GetData(ScanerType scanerType, List<IFrequencyData> freqenciesData)
        {
            _freqenciesData = freqenciesData;
            _selectedScanerType = scanerType;

            UpdateProScanChannelData();

            return _proScanChannelsData;
        }

        private void UpdateProScanChannelData()
        {
            _proScanChannelsData.Clear();

            string sufix = "";
            foreach (var scanerData in _scanerDatas) 
                if(_selectedScanerType == scanerData.ScanerType)
                {
                    sufix = scanerData.Sufix;
                    break;
                }

            for (int i = 0; i < _freqenciesData.Count; i++)
            {
                IFrequencyData frequencyData = _freqenciesData[i];
                _proScanChannelsData.Add(GetProScanLine(i,frequencyData, sufix));
            }
        }

        private string GetProScanLine(int index, IFrequencyData frequencyData, string sufix)
        {
            StringBuilder proScanLine = new StringBuilder();

            string prefix = "CIN";
            string separator = ",";
            string name = frequencyData.Name.Replace(',', '.');
            string frequency = frequencyData.Frequency < 1000000000 ? "0" : "";
            frequency += (frequencyData.Frequency / 100).ToString();
            string detectorType = frequencyData.DetectorType;

            proScanLine.Append(prefix);
            proScanLine.Append(separator);
            proScanLine.Append(index);
            proScanLine.Append(separator);
            proScanLine.Append(name);
            proScanLine.Append(separator);
            proScanLine.Append(frequency);
            proScanLine.Append(separator);
            proScanLine.Append(detectorType);
            proScanLine.Append(separator);
            proScanLine.Append(sufix);

            return proScanLine.ToString();
        }
    }
}