using System;
using System.Windows.Forms;
using SDRSharp.Common;
using SDRSharp.FreqToProscan.Services;

namespace SDRSharp.FreqToProscan
{
    public class FreqToProscanPlugin : ISharpPlugin, ICanLazyLoadGui, IExtendedNameProvider
    {
        private const string ALL_GROUP = "All";

        private ControlPanel _gui;

        public string DisplayName => "Freq Manager To ProScan";        
        public string Category => "Proscan";        
        public string MenuItemName => DisplayName;

        private IPluginDataService _pluginDataService;
        private IFreqXmlDataService _freqXmlDataService;
        private IScanerDataFabric _scanerDataFabric;
        private IProscanDbLinesDataService _proscanDbLinesDataServece;

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
            _proscanDbLinesDataServece = new ProscanDbLinesDataService(_scanerDataFabric);
            _pluginDataService = new PluginDataService(_freqXmlDataService,
                                                       _proscanDbLinesDataServece);
        }

        private bool IsGUINotExist() => _gui == null;

        public void Initialize(ISharpControl control) { }

        public void Close() { }

        public void LoadGui()
        {
            _gui = new ControlPanel();
            SubscribeGUIEvents();
            UpdateData();
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

        private void UpdateData() => UpdateData(ScanerType.BCD996P2, ALL_GROUP);

        private void UpdateData(ScanerType scanerType, string groupFilter)
        {
            IPluginData pluginData = _pluginDataService.GetData(scanerType, groupFilter);
            _gui.Update(pluginData);
        }
    }
}
