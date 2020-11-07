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

        public void GerarPartida(Time casa, Time visitante)
        {
            
        }

        public void AdicionarResultadoDaPartida()
        {
            new Partida().TimeDaCasa.FazerGol();
            new Partida().TimeVisitante.FazerGol();
        }
    }
}