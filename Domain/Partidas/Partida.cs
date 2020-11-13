namespace Domain
{
    public class Partida
    {
        public TimeVisitante Visitante{ get; private set; }

        public TimeCasa Casa{ get; private set; }

        public Partida(TimeCasa casa, TimeVisitante visitante)
        {
            this.Casa = casa;
            this.Visitante = visitante;
        }
    }
}