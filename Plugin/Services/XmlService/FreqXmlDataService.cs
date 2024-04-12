using SDRSharp.FreqToProscan.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace SDRSharp.FreqToProscan.Services
{
    public class FreqXmlDataService : IFreqXmlDataService
    {
        private const string PATH = "Frequencies.xml";
        private const string MEMORY_NODE_NAME = "MemoryEntry";

        private List<IFrequencyData> _frequenciesData;
        private XmlNodeList _frequenciesNodeList;

        public FreqXmlDataService()
        {
            _frequenciesData = new List<IFrequencyData>();
        }

        public List<IFrequencyData> GetData()
        {
            _frequenciesData.Clear();

            if (File.Exists(PATH))
            {
                _frequenciesNodeList = GetFrequenciesNodeListFromFile();
                FillFrequenciesDataFromNodeList();
            }

            return _frequenciesData;
        }

        private XmlNodeList GetFrequenciesNodeListFromFile()
        {
            XmlNode root = LoadXmlDocumentByPath().DocumentElement;
            return root.SelectNodes($"descendant::{MEMORY_NODE_NAME}");
        }

        private XmlDocument LoadXmlDocumentByPath()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(PATH);
            return doc;
        }

        private void FillFrequenciesDataFromNodeList()
        {
            foreach (XmlNode node in _frequenciesNodeList)
            {
                IFrequencyData data = GetFrequencyDataFromXmlNode(node);
                _frequenciesData.Add(data);
            }
        }

        private IFrequencyData GetFrequencyDataFromXmlNode(XmlNode node)
        {
            IFrequencyData data = new FrequencyData(
                isFavourite: Convert.ToBoolean(node.SelectSingleNode("IsFavourite").InnerText),
                name: node.SelectSingleNode("Name").InnerText,
                groupName: node.SelectSingleNode("GroupName").InnerText,
                frequency: Convert.ToInt32(node.SelectSingleNode("Frequency").InnerText),
                detectorType: node.SelectSingleNode("DetectorType").InnerText,
                shift: Convert.ToInt32(node.SelectSingleNode("Shift").InnerText),
                filterBandwidth: Convert.ToInt32(node.SelectSingleNode("FilterBandwidth").InnerText));

            return data;
        }
    }
}
