using System.Collections.Generic;

namespace Domain
{
    public class Campeonato
    {
        private List<Time> _times { get; set; }
        public bool InicioDoCampeonato = false;
        public List<Partida> Partidas { get; private set; }

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

        public void GerarRodada()
        {
            var times = new int[4,2];

            for (int i = 0; i < length; i++)
            {
                
            }
            
        }
    }
}