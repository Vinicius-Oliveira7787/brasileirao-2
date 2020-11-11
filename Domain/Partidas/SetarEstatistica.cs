using System.Collections.Generic;

namespace Domain
{
    public class SetarEstatistica
    {
        public SetarEstatistica(Partida partida)
        {
            if (partida.TimeDaCasa.TimeCasaGols > partida.TimeVisitante.TimeVisitanteGols)
            {
                partida.TimeDaCasa.TimeDaCasa.AdicionarVitoria();
                partida.TimeDaCasa.TimeDaCasa.AtualizarPorcentagemDeAproveitamento();
                partida.TimeVisitante.TeamVisitante.AdicionarDerrota();
            }

            else if (partida.TimeDaCasa.TimeCasaGols < partida.TimeVisitante.TimeVisitanteGols)
            {
                partida.TimeVisitante.TeamVisitante.AdicionarVitoria();
                partida.TimeVisitante.TeamVisitante.AtualizarPorcentagemDeAproveitamento();
                partida.TimeDaCasa.TimeDaCasa.AdicionarDerrota();
            }

            else if (partida.TimeDaCasa.TimeCasaGols == partida.TimeVisitante.TimeVisitanteGols)
            {
                partida.TimeDaCasa.TimeDaCasa.AdicionarEmpate();
                partida.TimeVisitante.TeamVisitante.AdicionarEmpate();
            }
        }
    }
}