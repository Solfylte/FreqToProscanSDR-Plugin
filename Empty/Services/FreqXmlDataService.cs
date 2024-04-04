using SDRSharp.FreqToProscan.Data;
using System;
using System.Collections.Generic;
using System.Xml;

namespace SDRSharp.FreqToProscan.Services
{
    public class FreqXmlDataService : IFreqXmlFileService
    {
        private List<IFrequenciesManagerData> _frequenciesManagerData;
        private XmlNodeList _frequenciesNodeList;

        public FreqXmlDataService()
        {
            _frequenciesManagerData = new List<IFrequenciesManagerData>();
        }

        public List<IFrequenciesManagerData> GetData()
        {
            _frequenciesManagerData.Clear();
            _frequenciesNodeList = GetFrequenciesNodeList();

            foreach (XmlNode node in _frequenciesNodeList)
            {
                IFrequenciesManagerData data = new FrequenciesManagerData
                    (isFavourite: Convert.ToBoolean(node.SelectSingleNode("IsFavourite").InnerText),
                    name: node.SelectSingleNode("Name").InnerText,
                    groupName: node.SelectSingleNode("GroupName").InnerText,
                    frequency: Convert.ToInt32(node.SelectSingleNode("Frequency").InnerText),
                    detectorType: node.SelectSingleNode("DetectorType").InnerText,
                    shift: Convert.ToInt32(node.SelectSingleNode("Shift").InnerText),
                    filterBandwidth: Convert.ToInt32(node.SelectSingleNode("FilterBandwidth").InnerText));

                _frequenciesManagerData.Add(data);
            }

            return _frequenciesManagerData;
        }

        private XmlNodeList GetFrequenciesNodeList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\Debug\\net7.0-windows\\Frequencies.xml");
            XmlNode root = doc.DocumentElement;
            return root.SelectNodes("descendant::MemoryEntry");
        }
    }

    public interface IFreqXmlFileService
    {
        public List<IFrequenciesManagerData> GetData();
    }
}
