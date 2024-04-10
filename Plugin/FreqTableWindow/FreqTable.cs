using SDRSharp.FreqToProscan.Data;
using System.Collections.Generic;
using System.Data;

namespace SDRSharp.FreqToProscan
{
    public class FreqTable
    {
        private const string ALL_GROUP = "All";
        public DataTable Table { get; private set; }

        public FreqTable() 
        {
            CreateTable();
        }

        private void CreateTable()
        {
            Table = new DataTable();
            Table.Columns.Add("Frequency");
            Table.Columns.Add("Unit");
            Table.Columns.Add("Name");
            Table.Columns.Add("Group");
            Table.Columns.Add("Mod");
            Table.Columns.Add("Bandwidth");
        }

        public void UpdateTable(IPluginData pluginData, string groupFilter, Unit unit)
        {
            List<IFrequencyData> frequencyData = pluginData.Frequencies;
            Table.Rows.Clear();

            bool isShowAll = groupFilter == ALL_GROUP;

            foreach (IFrequencyData data in frequencyData)
            {
                if (isShowAll || data.GroupName == groupFilter)
                {
                    Table.Rows.Add(GetFrequencyText(data.Frequency, unit),
                                    unit,
                                    data.Name,
                                    data.GroupName,
                                    data.DetectorType,
                                    data.FilterBandwidth);
                }
            }
        }

        private string GetFrequencyText(float frequency, Unit unit)
        {
            string format = GetFrequencyFormat(frequency, unit);
            return (frequency / (int)(unit)).ToString(format);
        }

        public string GetFrequencyFormat(float frequencyHz, Unit unit)
        {
            string format = $"";
            if (unit > Unit.kHz)
                format += "0.000";
            else if (frequencyHz / (int)(unit) >= 1)
                format = $"0";

            return format;
        }
    }
}
