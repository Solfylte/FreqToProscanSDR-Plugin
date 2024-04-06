using SDRSharp.FreqToProscan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SDRSharp.FreqToProscan
{
    public partial class FreqTableWindow : Form
    {
        private const string ALL_GROUP = "All";

        private IPluginData _pluginData;

        private Unit _selectedUnit = Unit.MHz;

        private FreqTable _freqTable;

        public FreqTableWindow(IPluginData pluginData)
        {
            InitializeComponent();
            InitializeComboBox();

            _freqTable = new FreqTable();

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
            _freqTable.UpdateTable(_pluginData, comboBoxGroup.Text, _selectedUnit);

            dataGridViewFreq.DataSource = null;
            dataGridViewFreq.DataSource = _freqTable.Table;
            dataGridViewFreq.Refresh();
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

            if (IsPluginDataExist())
                UpdateTable();
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPluginDataExist())
                UpdateTable();
        }

        private bool IsPluginDataExist() => _pluginData != null;
    }
}
