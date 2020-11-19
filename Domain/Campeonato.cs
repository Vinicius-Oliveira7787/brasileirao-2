using System.Collections.Generic;
using System.Linq;

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

        private void GerarPartida(Time casa, Time visitante)
        {
            var teamCasa = new TimeCasa(casa);
            var teamVisitante = new TimeVisitante(visitante);
            
            Partidas.Add(new Partida(teamCasa, teamVisitante));
        }

        public void AdicionarResultadoDaPartida(string timeHouse, int timeHouseGols, string timeAway, int timeAwayGols)
        {
            var timeCasa = _times.FirstOrDefault(time => time.Name == timeHouse);
            var timeVisitante = _times.FirstOrDefault(time => time.Name == timeAway);

            GerarPartida(timeCasa, timeVisitante);

            for (int i = 0; i < timeHouseGols; i++)
            {
                timeCasa.FazerGol();
            }

            for (int i = 0; i < timeAwayGols; i++)
            {
                visitante.FazerGol();
            }
        }
    }
}