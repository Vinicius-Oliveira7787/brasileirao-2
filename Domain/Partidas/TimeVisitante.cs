namespace Domain
{
    public class TimeVisitante
    {
        public Time TeamVisitante { get; private set; }
        public int TimeVisitanteGols { get; private set; } = 0;

        public TimeVisitante(Time timeCasa)
        {
            this.TeamVisitante = timeCasa;
        }

        public void FazerGol()
        {
            this.TimeVisitanteGols++;
        }
    }
}