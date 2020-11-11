using System;
using System.Collections.Generic;

namespace Domain
{
    public class Time
    {
        public string Name { get; private set; }
        private List<Jogador> _jogadores { get; set; } = new List<Jogador>();
        public IReadOnlyCollection<Jogador> Jogadores => _jogadores;
        public readonly int SaldoGols;
        public int Pontos { get; private set; }
        public int PartidasDisputadas { get; private set; }
        public int Vitorias { get; private set; }
        public int Derrotas { get; private set; }
        public int GolsPro { get; private set; }
        public int GolsContra { get; private set; }
        public double PorcentagemDeAproveitamento { get; private set; }

        public Time(string name)
        {
            this.Name = name;
            this.SaldoGols = 0;
        }

        public bool CriarJogadores(List<Jogador> jogadores)
        {
            if (jogadores.Count < 16 || jogadores.Count > 32)
            {
                return false;
            }
            
            this._jogadores = jogadores;
            return true;
        }

        public void AdicionarJogadoresAoTime(List<Jogador> novosJogadores)
        {

        }

        public void AdicionarVitoria()
        {
            this.Pontos += 3;
            this.Vitorias++;
            this.PartidasDisputadas++;
        }

        public void AdicionarDerrota()
        {
            this.PartidasDisputadas++;
            this.Derrotas++;
        }

        public void AdicionarEmpate()
        {
            this.PartidasDisputadas++;
            this.Pontos++;
        }

        public void AtualizarPorcentagemDeAproveitamento()
        {

        }
    }
}