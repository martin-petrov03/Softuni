using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators { get; set; }
        
        public int Count => this.gladiators.Count();

        public string Name { get; private set; }

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }        

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator targetGladiator = gladiators.FirstOrDefault(g => g.Name == name);
            gladiators.Remove(targetGladiator);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator targetGladiator = gladiators.OrderByDescending(g => g.GetStatPower()).First();
            return targetGladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator targetGladiator = gladiators.OrderByDescending(g => g.GetWeaponPower()).First();
            return targetGladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator targetGladiator = gladiators.OrderByDescending(g => g.GetTotalPower()).First();
            return targetGladiator;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[{this.Name}] - [{this.Count}] gladiators are participating.");
            return sb.ToString().TrimEnd();
        }
    }
}