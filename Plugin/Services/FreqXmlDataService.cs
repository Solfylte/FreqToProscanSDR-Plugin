﻿using SDRSharp.FreqToProscan.Data;
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

        private List<IFrequencyData> _frequenciesManagerData;
        private XmlNodeList _frequenciesNodeList;

        public FreqXmlDataService()
        {
            _frequenciesManagerData = new List<IFrequencyData>();
        }

        public List<IFrequencyData> GetData()
        {
            _frequenciesManagerData.Clear();

            if(File.Exists(PATH))
            {
                _frequenciesNodeList = GetFrequenciesNodeList();

                foreach (XmlNode node in _frequenciesNodeList)
                {
                    IFrequencyData data = new FrequencyData
                        (isFavourite: Convert.ToBoolean(node.SelectSingleNode("IsFavourite").InnerText),
                        name: node.SelectSingleNode("Name").InnerText,
                        groupName: node.SelectSingleNode("GroupName").InnerText,
                        frequency: Convert.ToInt32(node.SelectSingleNode("Frequency").InnerText),
                        detectorType: node.SelectSingleNode("DetectorType").InnerText,
                        shift: Convert.ToInt32(node.SelectSingleNode("Shift").InnerText),
                        filterBandwidth: Convert.ToInt32(node.SelectSingleNode("FilterBandwidth").InnerText));

                    _frequenciesManagerData.Add(data);
                }
            }

            return _frequenciesManagerData;
        }

        private XmlNodeList GetFrequenciesNodeList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(PATH);
            XmlNode root = doc.DocumentElement;
            return root.SelectNodes($"descendant::{MEMORY_NODE_NAME}");
        }
    }
}
