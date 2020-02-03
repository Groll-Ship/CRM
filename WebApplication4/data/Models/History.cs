﻿using System;

namespace data.Models
{
    public class History: IEntity
    {
        public int LeadId { get; set; }
        public Lead Lead { get; set; }
        public string HistoryText { get; set; }
    }
}
