using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopArticles.Models
{
    public class ResponseModel
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public IEnumerable<Data> data { get; set; }
    }

    public class Data
    {
        public string? title { get; set; }
        public string url { get; set; }
        public string author { get; set; }
        public int? num_comments { get; set; }
        public int? story_id { get; set; }
        public string? story_title { get; set; }
        public string? story_url { get; set; }
        public int? parent_id { get; set; }
        public DateTime created_at { get; set; }
    }
}
