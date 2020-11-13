using System.Collections.Generic;

namespace Domain
{
    public class SetarEstatistica
    {
        public SetarEstatistica(Partida partida)
        {
            if (partida.Casa.TimeCasaGols > partida.Visitante.TimeVisitanteGols)
            {
                partida.Casa.TimeDaCasa.AdicionarVitoria();
                partida.Casa.TimeDaCasa.AtualizarPorcentagemDeAproveitamento();
                partida.Visitante.TeamVisitante.AdicionarDerrota();
            }

            else if (partida.Casa.TimeCasaGols < partida.Visitante.TimeVisitanteGols)
            {
                partida.Visitante.TeamVisitante.AdicionarVitoria();
                partida.Visitante.TeamVisitante.AtualizarPorcentagemDeAproveitamento();
                partida.Casa.TimeDaCasa.AdicionarDerrota();
            }

            else if (partida.Casa.TimeCasaGols == partida.Visitante.TimeVisitanteGols)
            {
                partida.Casa.TimeDaCasa.AdicionarEmpate();
                partida.Visitante.TeamVisitante.AdicionarEmpate();
            }
        }
    }
}