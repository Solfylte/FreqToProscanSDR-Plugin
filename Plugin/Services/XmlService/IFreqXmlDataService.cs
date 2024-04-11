using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{
    public interface IFreqXmlDataService
    {
        public List<IFrequencyData> GetData();
    }
}
