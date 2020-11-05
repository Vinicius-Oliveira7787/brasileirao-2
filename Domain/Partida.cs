namespace Domain
{
    public class Partida
    {
        public Time TimeCasa { get; private set; }
        public Time TimeVisitante { get; private set; }

        public int TimeCasaGols { get; private set; } = 0;
        public int TimeVisitanteGols { get; private set; } = 0;

        public Partida(Time timeCasa, Time timeVisitante)
        {
            this.TimeCasa = timeCasa;
            this.TimeVisitante = timeVisitante;
        }

        public void FazerGolCasa()
        {
            this.TimeCasaGols++;
        }

        public void FazerGolVisitante()
        {
            this.TimeVisitanteGols++;
        }
    }
}