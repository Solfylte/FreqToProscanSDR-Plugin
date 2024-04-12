namespace SDRSharp.FreqToProscan
{
    public struct ProscanDbLineData : IProscanDbLineData
    {
        public string Group => _group;
        public string Text => _text;

        private string _group;
        private string _text;

        public ProscanDbLineData(string group, string text)
        {
            _group = group;
            _text = text;
        }
    }
}
