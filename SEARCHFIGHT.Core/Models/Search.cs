using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEARCHFIGHT.Core.Models
{
    public class Search
    {
        public string SearchEngine { get; set; }
        public string Term { get; set; }
        public long Results { get; set; }
    }
}
