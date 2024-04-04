using System;
using System.Text;
using System.Windows.Forms;

namespace SDRSharp.FreqToProscan
{
    public partial class ControlPanel : UserControl
    {
        public Action OnDataUpdateNeed;

        public ControlPanel()
        {
            InitializeComponent();
            OnDataUpdateNeed?.Invoke();
        }

        public void UpdateGUIData(IPluginData pluginData)
        {
            StringBuilder proscanLines = new StringBuilder();
            if (pluginData.ProscanLines.Count > 0)
            {
                foreach (string line in pluginData.ProscanLines)
                    proscanLines.AppendLine(line);

                textBoxFreq.Text = proscanLines.ToString();
            }
            else
            {
                textBoxFreq.Clear();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            OnDataUpdateNeed?.Invoke();
        }
    }
}
