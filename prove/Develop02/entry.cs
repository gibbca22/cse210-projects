namespace JournalApp
{
    class Entry
    {
        public string _Date { get; }
        public string _Prompt { get; }
        public string _Response { get; }

        public Entry(string _date, string _prompt, string _response)
        {
            _Date = _date;
            _Prompt = _prompt;
            _Response = _response;
        }

        public override string ToString()
        {
            return $"Date: {_Date}\nPrompt: {_Prompt}\nResponse: {_Response}\n";
        }

        // saving entry to a csv file
        public string ToCsv()
        {
            return $"{_Date}~|~{_Prompt}~|~{_Response}";
        }

        public static Entry FromCsv(string csvLine)
        {
            string[] parts = csvLine.Split(new[] { "~|~" }, StringSplitOptions.None);
            return new Entry(parts[0], parts[1], parts[2]);
        }
    }
}
