using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Campeonato
    {
        private List<Time> _times { get; set; }
        public bool InicioDoCampeonato = false;

        public bool CriarTimes(List<Time> times)
        {
            if (times.Count < 8 || times.Count % 2 != 0)
            {
                return false;
            }
            
            if (!InicioDoCampeonato)
            {
                return false;
            }

            _times = times;
            return true;
        }
    }
}