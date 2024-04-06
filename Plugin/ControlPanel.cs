using SDRSharp.FreqToProscan.Data;
using System;
using System.Text;
using System.Windows.Forms;

namespace SDRSharp.FreqToProscan
{
    public partial class ControlPanel : UserControl
    {
        public Action OnDataUpdateNeed;

        private FreqGridWindow _freqGridWindow;

        private IPluginData _pluginData;

        public ControlPanel()
        {
            InitializeComponent();
            OnDataUpdateNeed?.Invoke();
        }

        public void UpdateGUIData(IPluginData pluginData)
        {
            _pluginData = pluginData;
            ClearUI();

            StringBuilder proscanLines = new StringBuilder();
            if (_pluginData.ProscanLines.Count > 0)
            {
                foreach (string line in _pluginData.ProscanLines)
                    proscanLines.AppendLine(line);

                textBoxFreq.Text = proscanLines.ToString();
            }

            if (_freqGridWindow != null)
                _freqGridWindow.Update(_pluginData);
        }

        private void ClearUI()
        {
            textBoxFreq.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            OnDataUpdateNeed?.Invoke();
        }

        private void buttonShowFreqTable_Click(object sender, EventArgs e)
        {
            if (_freqGridWindow == null)
                _freqGridWindow = new FreqGridWindow(_pluginData);
            else
                _freqGridWindow.Focus();

            _freqGridWindow.Show();
        }
    }
}
