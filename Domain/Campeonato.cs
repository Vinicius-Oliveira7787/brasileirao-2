using System.Collections.Generic;

namespace Domain
{
    public class Campeonato
    {
        public List<Time> Times { get; private set; }
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

            return true;
        }
    }
}