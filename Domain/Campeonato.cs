using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Campeonato
    {
        private List<Time> _times { get; set; }
        public bool InicioDoCampeonato = false;
        private List<Partida> _partidas { get; set; }
        public IReadOnlyCollection<Partida> Partidas => _partidas;

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

        public Partida MostradorDePartida(TimeCasa casa, TimeVisitante visitante)
        {
            return _partidas.FirstOrDefault(time => time.Casa == casa && time.Visitante == visitante);
        }

        public void AdicionarResultadoDaPartida(string timeHouse, int timeHouseGols, string timeAway, int timeAwayGols)
        {
            var timeCasa = _times.FirstOrDefault(time => time.Name == timeHouse);
            var timeVisitante = _times.FirstOrDefault(time => time.Name == timeAway);

            var teamCasa = new TimeCasa(timeCasa);
            var teamVisitante = new TimeVisitante(timeVisitante);
            
            var verification = _partidas.FirstOrDefault(time => time.Casa == teamCasa && time.Visitante == teamVisitante);
            if (verification != null)
            {
                var currentMatch = new Partida(teamCasa, teamVisitante);
                _partidas.Add(currentMatch);

                for (int i = 0; i < timeHouseGols; i++)
                {
                    teamCasa.FazerGol();
                }

                for (int i = 0; i < timeAwayGols; i++)
                {
                    teamVisitante.FazerGol();
                }

                new SetarEstatistica(currentMatch);
            }
        }
    }
}