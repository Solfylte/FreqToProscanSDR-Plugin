namespace SDRSharp.FreqToProscan.Data
{
    // Data from default SDR# Frequency Manager XML file
    public struct FrequencyData : IFrequencyData
    {
        private bool _isFavourite;
        private string _name;
        private string _groupName;
        private int _frequency;
        private string _detectorType;
        private int _shift;
        private int _filterBandwidth;

        public bool IsFavourite => _isFavourite;
        public string Name => _name;
        public string GroupName => _groupName;
        public int Frequency => _frequency;
        public string DetectorType => _detectorType;
        public int Shift => _shift;
        public int FilterBandwidth => _filterBandwidth;

        public FrequencyData(bool isFavourite, string name,
                                    string groupName, int frequency,
                                    string detectorType, int shift,
                                    int filterBandwidth)
        {
            _isFavourite = isFavourite;
            _name = name;
            _groupName = groupName;
            _frequency = frequency;
            _detectorType = detectorType;
            _shift = shift;
            _filterBandwidth = filterBandwidth;
        }
    }
}
