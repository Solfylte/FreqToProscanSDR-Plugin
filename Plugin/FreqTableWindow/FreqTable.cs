using SDRSharp.FreqToProscan.Data;
using System;
using System.Collections.Generic;
using System.Data;

namespace SDRSharp.FreqToProscan
{
    public class FreqTable
    {
        private const string ALL_GROUP = "All";
        public DataTable Table { get; private set; }

        private string _groupFilter;
        private Unit _unit;

        private List<IFrequencyData> _frequencyDatas;
        private IFrequencyData _frequencyData;

        public FreqTable() 
        {
            CreateTable();
        }

        private void CreateTable()
        {
            Table = new DataTable();
            Table.Columns.Add("Frequency");
            Table.Columns.Add("Mod");
            Table.Columns.Add("Name");
            Table.Columns.Add("Unit");
            Table.Columns.Add("Group");
            Table.Columns.Add("Bandwidth");
        }

        public void UpdateTable(IPluginData pluginData, string groupFilter, Unit unit)
        {
            _groupFilter = groupFilter;
            _frequencyDatas = pluginData.Frequencies;
            _unit = unit;

            ClearTable();
            FillTableFromFrequencyDatas();
        }

        private void ClearTable() => Table.Rows.Clear();

        private void FillTableFromFrequencyDatas()
        {
            foreach (IFrequencyData data in _frequencyDatas)
            {
                _frequencyData = data;

                if (SelectedAll() || ThisIsSelectedGroup())
                    AddTableRow();
            }
        }

        private bool SelectedAll() => _groupFilter == ALL_GROUP;

        private bool ThisIsSelectedGroup() => _frequencyData.GroupName == _groupFilter;

        private void AddTableRow()
        {
            Table.Rows.Add(GetFrequencyText(_frequencyData.Frequency, _unit),
                            _frequencyData.DetectorType,
                            _frequencyData.Name,
                            _unit,
                            _frequencyData.GroupName,
                            _frequencyData.FilterBandwidth);
        }

        private string GetFrequencyText(float frequency, Unit unit)
        {
            string format = GetFrequencyFormat(unit);
            return (frequency / (int)(unit)).ToString(format).Replace(',','.');
        }

        public string GetFrequencyFormat(Unit unit)
        {
            if(unit == Unit.MHz)
                return "0.000";

            return string.Empty;
        }
    }
}
