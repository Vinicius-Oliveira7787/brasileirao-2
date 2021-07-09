using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Api.Models.Entities
{
    public class Championship
    {
        public virtual List<Match> _matches { get; set; }
        public virtual List<Team> _teams { get; set; }
        public virtual Player TopScorer { get; set; }
        public List<string> Table { get; set; }
    }
}
