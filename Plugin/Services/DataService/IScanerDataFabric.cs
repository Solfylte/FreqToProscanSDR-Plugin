using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{
    public interface IScanerDataFabric
    {
        List<IScanerData> CreateScanerDatas();
    }
}
