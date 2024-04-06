using System;

namespace SDRSharp.FreqToProscan.Data
{
    // Data for grid table windows
    public struct GridWindowData : IGridWindowData
    { 
        public string Name { get; private set; }
        public string GroupName { get; private set; }
        public string DetectorType { get; private set; }
        public int FilterBandwidth { get; private set; }
        public Unit Unit { get; set; }

        public string Frequency 
            => (_frequency / (int)(Unit)).ToString(GetFormat());

        private string GetFormat()
        {
            string format = $"";
            if (Unit > Unit.kHz)
                format += "0.000";
            else if (_frequency / (int)(Unit) >= 1)
                format = $"0";

            return format;
        }

        private float _frequency;

        public GridWindowData(IFrequencyData frequencyData) 
        {
            Name = frequencyData.Name;
            GroupName = frequencyData.GroupName;
            DetectorType = frequencyData.DetectorType;
            FilterBandwidth = frequencyData.FilterBandwidth;
            _frequency = frequencyData.Frequency;
            Unit = Unit.MHz;
        }
    }
}
