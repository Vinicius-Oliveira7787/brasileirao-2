namespace Domain
{
    public class TimeVisitante
    {
        public Time TimeForaDeCasa { get; private set; }
        public int TimeCasaGols { get; private set; } = 0;

        public TimeVisitante(Time timeCasa)
        {
            this.TimeForaDeCasa = timeCasa;
        }

        public void FazerGol()
        {
            this.TimeCasaGols++;
        }
    }
}