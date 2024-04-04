using System;
using System.Windows.Forms;
using SDRSharp.Common;

namespace SDRSharp.FreqToProscan
{
    public class FreqToProscanPlugin : ISharpPlugin, ICanLazyLoadGui, IExtendedNameProvider
    {
        private ControlPanel _gui;

        public string DisplayName => "Freq Manager To ProScan";        
        public string Category => "Proscan";        
        public string MenuItemName => DisplayName;

        public IFreqToProscanService _freqToProscanService;

        public UserControl Gui
        {
            get
            {
                if (IsGUINotExist())
                    LoadGui();

                return _gui;
            }
        }

        public FreqToProscanPlugin()
        {
            _freqToProscanService = new FreqToProscanService();
        }

        private bool IsGUINotExist() => _gui == null;

        public void LoadGui()
        {
            _gui = new ControlPanel();
            SubscribeGUIEvents();
        }

        public void Initialize(ISharpControl control) { }

        public void Close() { }

        private void SubscribeGUIEvents()
        {
            _gui.HandleDestroyed += _gui_HandleDestroyed;
            _gui.OnDataUpdateNeed += UpdateData;
        }

        private void UnsubscribeGUIEvents()
        {
            _gui.HandleDestroyed -= _gui_HandleDestroyed;
            _gui.OnDataUpdateNeed -= UpdateData;
        }

        private void _gui_HandleDestroyed(object sender, EventArgs e)
        {
            UnsubscribeGUIEvents();
        }

        private void UpdateData()
        {
            _freqToProscanService.UpdateData();
            _gui.UpdateGUIData(_freqToProscanService.GetData);
        }
    }
}
