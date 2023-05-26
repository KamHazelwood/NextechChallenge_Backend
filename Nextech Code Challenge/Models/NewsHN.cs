using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nextech_Code_Challenge.Models
{
    public class NewsHN
    {
        public NewsHN()
        {
            this.by = String.Empty;
            this.title = String.Empty;
            this.type = String.Empty;
            this.url = String.Empty;
        }
        //create each getter and setter for each value within the news articles. 
        public string by { get; set; }
        public int descendants { get; set; }
        public int id { get; set; }
        public int[] kids { get; set; }
        public int score { get; set; }
        public int time { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }
}
