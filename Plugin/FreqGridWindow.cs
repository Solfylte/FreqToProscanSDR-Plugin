using SDRSharp.FreqToProscan.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDRSharp.FreqToProscan
{
    public partial class FreqGridWindow : Form
    {
        private const string ALL_GROUP = "All";

        private IPluginData _pluginData;
        private List<IGridWindowData> _gridWindowDatas = new List<IGridWindowData>();
        private List<IGridWindowData> _filteredGridWindowDatas = new List<IGridWindowData>();

        private List<Unit> _units = new List<Unit> { Unit.Hz, Unit.kHz, Unit.MHz, Unit.GHz };

        public FreqGridWindow(IPluginData pluginData)
        {
            InitializeComponent();
            InitializeComboBox();
            Update(pluginData);
        }

        private void InitializeComboBox()
        {
            comboBoxUnits.DataSource = _units;
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
            _gridWindowDatas = _pluginData.GridWindowDatas;
            _filteredGridWindowDatas.Clear();

            bool isShowAll = comboBoxGroup.Text == ALL_GROUP;

            foreach (var data in _gridWindowDatas)
            {
                data.Unit = (Unit)comboBoxUnits.SelectedValue;
                if (isShowAll || data.GroupName == comboBoxGroup.Text)
                    _filteredGridWindowDatas.Add(data);
            }

            dataGridViewFreq.DataSource = null;
            dataGridViewFreq.DataSource = _filteredGridWindowDatas;
            dataGridViewFreq.Refresh();
        }

        private void UpdateGroupControl()
        {
            comboBoxGroup.Items.Clear();
            comboBoxGroup.Items.Add(ALL_GROUP);

            foreach (var data in _gridWindowDatas)
                if(!comboBoxGroup.Items.Contains(data.GroupName))
                    comboBoxGroup.Items.Add(data.GroupName);
        }

        private void comboBoxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
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
