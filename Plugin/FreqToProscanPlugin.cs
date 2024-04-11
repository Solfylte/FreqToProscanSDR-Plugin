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

        private IPluginDataService _pluginDataService;
        private IFreqXmlDataService _freqXmlDataService;
        private IScanerDataFabric _scanerDataFabric;
        private IProscanDatabaseLinesDataService _proscanDatabaseLinesDataServece;

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
            CreateServices();
        }

        private void CreateServices()
        {
            _freqXmlDataService = new FreqXmlDataService();
            _scanerDataFabric = new ScanerDataFabric();
            _proscanDatabaseLinesDataServece = new ProscanDatabaseLinesDataService(_scanerDataFabric);
            _pluginDataService = new PluginDataService(_freqXmlDataService,
                                                       _proscanDatabaseLinesDataServece);
        }

        private bool IsGUINotExist() => _gui == null;

        public void Initialize(ISharpControl control) { }

        public void Close() { }

        public void LoadGui()
        {
            _gui = new ControlPanel();
            SubscribeGUIEvents();
            UpdateData(ScanerType.BCD996P2);
        }

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

        private void UpdateData(ScanerType scanerType)
        {
            IPluginData pluginData = _pluginDataService.GetData(scanerType);
            _gui.Update(pluginData);
        }
    }
}
