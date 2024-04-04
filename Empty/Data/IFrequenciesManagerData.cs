﻿namespace SDRSharp.FreqToProscan
{
    public interface IFrequenciesManagerData
    {
        bool IsFavourite { get; }
        string Name { get; }
        string GroupName { get; }
        int Frequency { get; }
        string DetectorType { get; }
        int Shift { get; }
        int FilterBandwidth { get; }
    }
}
