using System;
using System.Collections.Generic;
using Domain.Players;

namespace Domain.Teams
{
    public class Team
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public int Gols { get; private set; } = 0;
        public List<Player> Players { get; set; } = new List<Player>();

        public Team(string name)
        {
            Name = name;
        }

        public (IList<string> errors, bool isValid) Validate()
        {
            var errors = new List<string>();
            if (!ValidateName())
            {
                errors.Add("Nome inválido.");
            }
            
            return (errors, errors.Count == 0);
        }

        protected bool ValidateName()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return false;
            }

            // foreach (var word in words)
            // {
            //     if (word.Trim().Length < 2)
            //     {
            //         return false;
            //     }
            //     if (word.Any(x => !char.IsLetter(x)))
            //     {
            //         return false;
            //     }
            // }

            return true;
        }
    }
}