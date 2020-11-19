namespace Domain
{
    public class Partida
    {
        public TimeVisitante TimeVisitante{ get; private set; }

        public TimeCasa TimeDaCasa{ get; private set; }

        public Partida(TimeCasa casa, TimeVisitante visitante)
        {
            this.TimeDaCasa = casa;
            this.TimeVisitante = visitante;
        }
    }
}