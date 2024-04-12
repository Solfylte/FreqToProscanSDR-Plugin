using SDRSharp.FreqToProscan.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDRSharp.FreqToProscan.Services
{
    public class ProscanDbLinesDataService : IProscanDbLinesDataService
    {
        private const string ALL_GROUP = "All";

        private IScanerDataFabric _scanerDataFabric;

        private List<IScanerData> _scanerDatas;
        private List<IFrequencyData> _freqencyDatas;
        private List<IProscanDbLineData> _proscanDbLineDatas;

        private ScanerType _selectedScanerType;
        private string _groupFilter;

        private IFrequencyData _frequencyData;
        private const string _prefix = "CIN,";
        private const string _separator = ",";
        private string _name;
        private string _frequency;
        private string _detectorType;
        private string _sufix;
        private int _index;

        public ProscanDbLinesDataService(IScanerDataFabric scanerDataFabric)
        {
            _proscanDbLineDatas = new List<IProscanDbLineData>();

            _scanerDataFabric = scanerDataFabric;
            _scanerDatas = _scanerDataFabric.CreateScanerDatas();
        }

        public List<IProscanDbLineData> GetData(List<IFrequencyData> freqenciesData,
                                                      ScanerType scanerType,
                                                      string groupFilter)
        {
            _freqencyDatas = freqenciesData;
            _selectedScanerType = scanerType;
            _groupFilter = groupFilter;

            UpdateProscanDbChannelDatas();

            return _proscanDbLineDatas;
        }

        private void UpdateProscanDbChannelDatas()
        {
            ClearProscanDbChannelDatas();
            FillProscanDbChannelDatasFromFrequencyDatas();
        }

        private void ClearProscanDbChannelDatas() => _proscanDbLineDatas.Clear();

        private void FillProscanDbChannelDatasFromFrequencyDatas()
        {
            for (int i = 0; i < _freqencyDatas.Count; i++)
            {
                _index = i + 1;
                _frequencyData = _freqencyDatas[i];

                if (SelectedAll() || ThisIsSelectedGroup())
                    _proscanDbLineDatas.Add(CreateProscanDbLineData());
            }
        }

        private bool SelectedAll() => _groupFilter == ALL_GROUP;
        private bool ThisIsSelectedGroup() => _frequencyData.GroupName == _groupFilter;

        private IProscanDbLineData CreateProscanDbLineData()
            => new ProscanDbLineData(_frequencyData.GroupName, GetProscanLine());

        private string GetProscanLine()
        {
            UpdateProscanDbChannelLineMembers();
            return GetConcatenatedProscanDbChannelLine(); 
        }

        private void UpdateProscanDbChannelLineMembers()
        {
            _name = GetProscanFormatingName(_frequencyData.Name);
            _frequency = GetProscanFormatingFrequency(_frequencyData.Frequency);
            _detectorType = GetProscanDetectorType(_frequencyData.DetectorType);
            _sufix = GetProscanSufix();
        }

        private string GetConcatenatedProscanDbChannelLine()
        {
            StringBuilder proScanLine = new StringBuilder();
            proScanLine.Append(_prefix);
            proScanLine.Append(_index);
            proScanLine.Append(_separator);
            proScanLine.Append(_name);
            proScanLine.Append(_separator);
            proScanLine.Append(_frequency);
            proScanLine.Append(_separator);
            proScanLine.Append(_detectorType);
            proScanLine.Append(_separator);
            proScanLine.Append(_sufix);
            return proScanLine.ToString();
        }

        private string GetProscanSufix()
        {
            foreach (IScanerData scanerData in _scanerDatas)
                if (_selectedScanerType == scanerData.ScanerType)
                    return scanerData.Sufix;

            return string.Empty;
        }

        private string GetProscanFormatingName(string name) => name.Replace(',', '.');

        private string GetProscanFormatingFrequency(int frequency)
        {
            string proscanFequency = frequency < 1000000000 ? "0" : "";
            proscanFequency += (frequency / 100).ToString();
            return proscanFequency;
        }

        private string GetProscanDetectorType(string sdrDetectorType)
        {
            if(IsProscanAndSdrDetectorTypesCompatible(sdrDetectorType))
                return sdrDetectorType;
            else 
                return ProscanDetectorType.AUTO.ToString();       
        }

        private bool IsProscanAndSdrDetectorTypesCompatible(string sdrDetectorType)
        {
            return sdrDetectorType == ProscanDetectorType.NFM.ToString()
                || sdrDetectorType == ProscanDetectorType.WFM.ToString()
                || sdrDetectorType == ProscanDetectorType.AM.ToString();
        }
    }
}