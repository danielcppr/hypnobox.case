using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopArticles.Models
{
    public class TopArticlesResponse
    {
        public int? num_comments { get; set; }
        public string title { get; set; }
    }
}
