using System;

namespace data.Models
{
    public class History
    {
        public int Id { get; set; }
        public Lead Lead { get; set; }
        public string HistoryText { get; set; }
    }
}
