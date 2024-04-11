using System.Collections.Generic;
using System.Text;

namespace SDRSharp.FreqToProscan
{
    public class ProscanDatabaseLinesDataService : IProscanDatabaseLinesDataService
    {
        private const string ALL_GROUP = "All";

        private IScanerDataFabric _scanerDataFabric;

        private List<IScanerData> _scanerDatas;
        private List<IFrequencyData> _freqenciesData;
        private List<IProscanDatabaseLineData> _proscanDatabaseLineData;

        private ScanerType _selectedScanerType;
        private string _groupFilter;

        public ProscanDatabaseLinesDataService(IScanerDataFabric scanerDataFabric)
        {
            _scanerDataFabric = scanerDataFabric;
            _proscanDatabaseLineData = new List<IProscanDatabaseLineData>();
            _scanerDatas = _scanerDataFabric.CreateScanerDatas();
        }

        public List<IProscanDatabaseLineData> GetData(List<IFrequencyData> freqenciesData,
                                                      ScanerType scanerType,
                                                      string groupFilter)
        {
            _freqenciesData = freqenciesData;
            _selectedScanerType = scanerType;
            _groupFilter = groupFilter;

            UpdateProScanChannelData();

            return _proscanDatabaseLineData;
        }

        private void UpdateProScanChannelData()
        {
            _proscanDatabaseLineData.Clear();

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

                bool isShowAll = _groupFilter == ALL_GROUP;

                if (isShowAll || frequencyData.GroupName == _groupFilter)
                {
                    IProscanDatabaseLineData proscanDatabaseLineData = new ProscanDatabaseLineData(frequencyData.GroupName,
                                                                            GetProScanLine(i, frequencyData, sufix));
                    _proscanDatabaseLineData.Add(proscanDatabaseLineData);
                }
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
            string detectorType = GetProscanDetectorType(frequencyData.DetectorType);

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

        private string GetProscanDetectorType(string detectorType)
        {
            string proscanDetectorType = ProscanDetectorType.AUTO.ToString();

            if (detectorType == ProscanDetectorType.AM.ToString() ||
                detectorType == ProscanDetectorType.NFM.ToString() ||
                detectorType == ProscanDetectorType.WFM.ToString())
                proscanDetectorType = detectorType;

            return proscanDetectorType;          
        }
    }
}