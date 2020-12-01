using System;
using System.Collections.Generic;
using System.Linq;
using Domain.People;

namespace Domain.Players
{
    public class Player : Person
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public int Goals { get; private set; }
        public string TeamName { get; private set; }

        public Player(string name, string teamName) : base(name) 
        {
            TeamName = teamName;
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
    }
}
