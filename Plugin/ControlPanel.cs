using System;
using System.Text;
using System.Windows.Forms;

namespace SDRSharp.FreqToProscan
{
    public partial class ControlPanel : UserControl
    {
        public Action OnDataUpdateNeed;

        private FreqTableWindow _freqGridWindow;

        private IPluginData _pluginData;

        public ControlPanel()
        {
            InitializeComponent();
            OnDataUpdateNeed?.Invoke();
        }

        public void UpdateGUI(IPluginData pluginData)
        {
            _pluginData = pluginData;

            ClearTextGUI();
            FillTextGUI();

            if (IsFreqTableWindowExist())
                UpdateFreqTableWindow();                
        }

        private void UpdateFreqTableWindow() => _freqGridWindow.Update(_pluginData);

        private void ClearTextGUI() => textBoxFreq.Clear();

        private void FillTextGUI()
        {
            StringBuilder proscanLines = new StringBuilder();
            if (_pluginData.ProscanLines.Count > 0)
            {
                foreach (string line in _pluginData.ProscanLines)
                    proscanLines.AppendLine(line);

                textBoxFreq.Text = proscanLines.ToString();
            }
        }

        private bool IsFreqTableWindowExist() => _freqGridWindow != null && !_freqGridWindow.IsDisposed;

        private void buttonUpdate_Click(object sender, EventArgs e) => OnDataUpdateNeed?.Invoke();

        private void buttonShowFreqTable_Click(object sender, EventArgs e)
        {
            if (IsFreqTableWindowExist())
                FocusOnExistTableWindow();
            else
                CreateNewTableWindow();

            ShowTableWindow();            
        }

        private void CreateNewTableWindow() => _freqGridWindow = new FreqTableWindow(_pluginData);

        private void FocusOnExistTableWindow() => _freqGridWindow.Focus();

        private void ShowTableWindow() => _freqGridWindow.Show();
    }
}
