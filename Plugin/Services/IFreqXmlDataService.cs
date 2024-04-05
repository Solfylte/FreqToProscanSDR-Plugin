using System.Collections.Generic;

namespace SDRSharp.FreqToProscan.Services
{
    public interface IFreqXmlDataService
    {
        public List<IFrequencyData> GetData();
    }
}
