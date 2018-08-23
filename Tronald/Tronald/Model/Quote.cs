using System;
using System.Collections.Generic;

namespace Tronald.Model
{
    public class Quote
    {
        public DateTime appeared_at { get; set; }
        public List<string> tags { get; set; }
        public string value { get; set; } 

        public string tag { get { return tags[0]; }}
        public string date { get { return appeared_at.ToString("dd/MM/yyyy"); }}
    }

    public class Embedded
    {
        public List<Quote> quotes { get; set; }
    }

    public class Quotes
    {
        public Embedded _embedded { get; set; }
        public int count { get; set; }
    }
}
