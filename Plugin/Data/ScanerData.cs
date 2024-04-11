namespace SDRSharp.FreqToProscan
{
    public struct ScanerData : IScanerData
    {
        public ScanerType ScanerType => _scanerType;
        public string Sufix => _suffix;

        private ScanerType _scanerType;
        private string _suffix;

        public ScanerData (ScanerType scanerType, string sufix)
        {
            _scanerType = scanerType;
            _suffix = sufix;
        }
    }
}
