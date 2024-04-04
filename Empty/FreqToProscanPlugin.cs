using System.Windows.Forms;
using SDRSharp.Common;

namespace SDRSharp.Empty
{
    public class FreqToProscanPlugin : ISharpPlugin, ICanLazyLoadGui, IExtendedNameProvider
    {
        private ControlPanel _gui;

        public string DisplayName => "Freq Manager To ProScan";        
        public string Category => "Proscan";        
        public string MenuItemName => DisplayName;

        public UserControl Gui
        {
            get
            {
                LoadGui();
                return _gui;
            }
        }

        public void LoadGui()
        {
            if (_gui == null)
            {
                _gui = new ControlPanel();
            }
        }

        public void Initialize(ISharpControl control) { }

        public void Close() { }
    }
}
