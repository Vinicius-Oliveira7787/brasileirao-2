using System;

namespace Domain
{
    public class Jogador
    {
        public int Camisa { get; private set; }
        public string Time { get; private set; }
        public string Name { get; private set; }
        public int Gols { get; private set; } = 0;
        public Guid Id { get; private set; } = Guid.NewGuid();

        public Jogador(string name, string time, int camisa)
        {
            this.Name = name;
            this.Time = time;
            this.Camisa = camisa;
        }

        public void FazerGols()
        {
            this.Gols++;
        }
    }
}