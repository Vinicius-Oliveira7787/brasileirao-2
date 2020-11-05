using System;
using System.Collections.Generic;

namespace Domain
{
    public class Time
    {
        public string Name { get; private set; }
        public int Gols { get; private set; } = 0;
        public Guid Id { get; private set; } = Guid.NewGuid();
        private List<Jogador> _jogadores { get; set; } = new List<Jogador>();
        public IReadOnlyCollection<Jogador> Jogadores => _jogadores;

        public Time(string name)
        {
            this.Name = name;
        }

        public bool CriarJogadores(List<Jogador> jogadores)
        {
            if (jogadores.Count < 16 || jogadores.Count < 16)
            {
                return false;
            }
            
            this._jogadores = jogadores;
            return true;
        }
    }
}