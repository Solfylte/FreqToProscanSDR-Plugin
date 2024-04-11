namespace SDRSharp.FreqToProscan
{
    public struct ProscanDatabaseLineData : IProscanDatabaseLineData
    {
        public string Group => _group;
        public string Text => _text;

        private string _group;
        private string _text;

        public ProscanDatabaseLineData(string group, string text)
        {
            _group = group;
            _text = text;
        }
    }
}
