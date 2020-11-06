namespace Domain
{
    public class TimeCasa
    {
        public Time TimeDaCasa { get; private set; }
        public int TimeCasaGols { get; private set; } = 0;

        public TimeCasa(Time timeCasa)
        {
            this.TimeDaCasa = timeCasa;
        }

        public void FazerGol()
        {
            this.TimeCasaGols++;
        }
    }
}