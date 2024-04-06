using SDRSharp.FreqToProscan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SDRSharp.FreqToProscan
{
    public partial class FreqGridWindow : Form
    {
        private const string ALL_GROUP = "All";

        private IPluginData _pluginData;

        private Unit _selectedUnit = Unit.MHz;

        private DataTable _table = new DataTable();

        public FreqGridWindow(IPluginData pluginData)
        {
            InitializeComponent();
            InitializeComboBox();

            _table.Columns.Add("Frequency");
            _table.Columns.Add("Unit");
            _table.Columns.Add("Name");
            _table.Columns.Add("Group");
            _table.Columns.Add("Mod");
            _table.Columns.Add("Bandwidth");

            Update(pluginData);
        }

        private void InitializeComboBox()
        {
            List<Unit> units = new List<Unit> { Unit.Hz, Unit.kHz, Unit.MHz, Unit.GHz };
            comboBoxUnits.DataSource = units;
            comboBoxUnits.SelectedItem = Unit.MHz;

            comboBoxGroup.Items.Add(ALL_GROUP);
            comboBoxGroup.SelectedItem = ALL_GROUP;
        }

        public void Update(IPluginData pluginData)
        {
            _pluginData = pluginData;
            UpdateTable();
            UpdateGroupControl();
        }

        private void UpdateTable()
        {
            List<IFrequencyData> frequencyData = _pluginData.Frequencies;

            _table.Rows.Clear();

            bool isShowAll = comboBoxGroup.Text == ALL_GROUP;

            for (int i = 0; i < frequencyData.Count; i++)
            {
                IFrequencyData data = frequencyData[i];
                if (isShowAll || data.GroupName == comboBoxGroup.Text)
                {
                    _table.Rows.Add(GetFrequencyText(data.Frequency),
                                    comboBoxUnits.SelectedItem,
                                    data.Name,
                                    data.GroupName,
                                    data.DetectorType,
                                    data.FilterBandwidth);
                }
            }

            dataGridViewFreq.DataSource = null;
            dataGridViewFreq.DataSource = _table;
            dataGridViewFreq.Refresh();
        }

        private string GetFrequencyText(float frequency)
        {
            return (frequency / (int)(_selectedUnit)).ToString(GetFrequencyFormat(frequency));
        }

        private string GetFrequencyFormat(float frequency)
        {
            string format = $"";
            if (_selectedUnit > Unit.kHz)
                format += "0.000";
            else if (frequency / (int)(_selectedUnit) >= 1)
                format = $"0";

            return format;
        }

        private void UpdateGroupControl()
        {
            comboBoxGroup.Items.Clear();
            comboBoxGroup.Items.Add(ALL_GROUP);

            foreach (var data in _pluginData.Frequencies)
                if (!comboBoxGroup.Items.Contains(data.GroupName))
                    comboBoxGroup.Items.Add(data.GroupName);
        }

        private void comboBoxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedUnit = (Unit)comboBoxUnits.SelectedItem;

            if (_pluginData != null)
                UpdateTable();
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_pluginData != null)
                UpdateTable();
        }
    }
}
