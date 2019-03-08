using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Episode
    {

        public Episode (string story, int season, int year, string title)
        {
            this.story = story;
            this.season = season;
            this.year = year;
            this.title = title;
        }

        public string story { get; }  // PK of Episode, FK debut

        public int season { get; }

        public int year { get; }

        public string title { get; }
    }
}
