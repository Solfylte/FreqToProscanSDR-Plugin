using System.Collections.Generic;

namespace SDRSharp.FreqToProscan
{
    public class ScanerDataFabric : IScanerDataFabric
    {
        private List<IScanerData> _scanerDatas;

        public ScanerDataFabric()
        {
            _scanerDatas = new List<IScanerData>();
        }

        public List<IScanerData> CreateScanerDatas()
        {
            _scanerDatas.Clear();

            _scanerDatas.Add(new ScanerData(ScanerType.BC125AT,
                                            ",0,2,1,0,0,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BC346XT,
                                            ",0,0,0,0,0,0,0,0,0,0,0,0,,,NONE,,0,0\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BC346XTC,
                                            ",0,0,0,0,0,0,0,0,0,0,0,0,,,NONE,,0,0\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCD160DN,
                                            ",2,0,127,0,SRCH,0,0,0,0,0,0,WHITE,3,400,0,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCD260DN,
                                            ",2,0,127,0,SRCH,0,0,0,0,0,0,WHITE,3,400,0,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCD325P2,
                                            ",0,0,0,0,0,0,0,0,0,0,0,0,0,SRCH,NONE,OFF,0,0\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCD396T,
                                            ",0,0,0,0,0,0,0,0,0,0,0\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCD396XT,
                                            ",0,0,0,0,0,0,0,0,0,0,0,0,0,SRCH,NONE,OFF,0,0\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCD996P2,
                                            ",0,0,0,0,0,0,0,0,0,0,0,0,0,SRCH,NONE,OFF,0,0\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCD996T,
                                            ",0,0,0,0,0,0,0,0,0,0,0,0,0\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCD996XT,
                                            ",0,0,0,0,0,0,0,0,0,0,0,0,0,SRCH,NONE,OFF,0,0\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCT15,
                                            ",0,0,0,0,0,0,0,0,0,0,0,0,\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BCT15X,
                                            ",0,0,0,0,0,0,0,0,0,0,0,0,,,NONE,,0,0\r\nNTE,"));
            _scanerDatas.Add(new ScanerData(ScanerType.BR330T,
                                            ",0,0,0,0,0,0,0,0,0,0,0\r\nNTE,"));

            return _scanerDatas;
        }
    }
}
