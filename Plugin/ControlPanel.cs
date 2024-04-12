using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDRSharp.FreqToProscan
{
    public partial class ControlPanel : UserControl
    {
        private const string ALL_GROUP = "All";

        public Action<ScanerType, string> OnDataUpdateNeed;

        private FreqTableWindow _freqGridWindow;

        private IPluginData _pluginData;

        private ScanerType _selectedScanerType;

        public ControlPanel()
        {
            InitializeComponent();
            InitializeComboBox();
            OnDataUpdateNeed?.Invoke(_selectedScanerType, ALL_GROUP);
        }

        private void InitializeComboBox()
        {
            comboBoxScanerType.DataSource = Enum.GetValues<ScanerType>().ToList();
            comboBoxScanerType.SelectedItem = ScanerType.BCD996P2;

            comboBoxGroup.Items.Add(ALL_GROUP);
            comboBoxGroup.SelectedItem = ALL_GROUP;
        }

        public void Update(IPluginData pluginData)
        {
            _pluginData = pluginData;

            UpdateGroupControl();

            ClearProScanChannelsTextGUI();
            FillProScanChannelsTextGUI();

            if (IsFreqTableWindowExist())
                UpdateFreqTableWindow();
        }

        private void UpdateGroupControl()
        {
            foreach (var data in _pluginData.Frequencies)
                if (!comboBoxGroup.Items.Contains(data.GroupName))
                    comboBoxGroup.Items.Add(data.GroupName);
        }

        private void UpdateFreqTableWindow() => _freqGridWindow.Update(_pluginData);

        private void ClearProScanChannelsTextGUI() => textBoxFreq.Clear();

        private void FillProScanChannelsTextGUI() => textBoxFreq.Text = GetProScanChannelsAsText();

        private string GetProScanChannelsAsText()
        {
            StringBuilder proscanCnannelsText = new StringBuilder();
            foreach (var proscanDbLine in _pluginData.ProscanDbLines)
                    proscanCnannelsText.AppendLine(proscanDbLine.Text);

            return proscanCnannelsText.ToString();
        }

        private void buttonShowFreqTable_Click(object sender, EventArgs e)
        {
            if (IsFreqTableWindowExist())
                FocusOnExistTableWindow();
            else
                CreateNewTableWindow();

            ShowTableWindow();
        }

        private bool IsFreqTableWindowExist() 
                                        => _freqGridWindow != null && !_freqGridWindow.IsDisposed;

        private void CreateNewTableWindow() => _freqGridWindow = new FreqTableWindow(_pluginData);

        private void FocusOnExistTableWindow() => _freqGridWindow.Focus();

        private void ShowTableWindow() => _freqGridWindow.Show(this);

        private void buttonCopy_Click(object sender, EventArgs e) 
                                        => Clipboard.SetText(textBoxFreq.Text);

        private void buttonUpdate_Click(object sender, EventArgs e)
                                        => OnDataUpdateNeed?.Invoke(_selectedScanerType,
                                                                    comboBoxGroup.Text);

        private void ControlPanel_Enter(object sender, EventArgs e)
                                        => OnDataUpdateNeed?.Invoke(_selectedScanerType,
                                                                    comboBoxGroup.Text);

        private void comboBoxScanerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedScanerType = (ScanerType)comboBoxScanerType.SelectedItem;
            OnDataUpdateNeed?.Invoke(_selectedScanerType, comboBoxGroup.Text);
        }

        private void comboBoxGroup_SelectedIndexChanged_1(object sender, EventArgs e) 
                        => OnDataUpdateNeed?.Invoke(_selectedScanerType, comboBoxGroup.Text);
    }
}
