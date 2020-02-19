using MilitaryElite.Contracts;
using MilitaryElite.Models;
using System.Collections.Generic;

namespace MilitaryElite.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<ISolider> soldiers;

        public CommandInterpreter()
        {
            this.soldiers = new List<ISolider>();
        }

        public string Read(string[] args)
        {
            string soldierType = args[0];
            int id = int.Parse(args[1]);
            string firstName = args[2];
            string lastName = args[3];

            if (soldierType == "Private")
            {
                decimal salary = decimal.Parse(args[4]);
                Private soldier = new Private(id, firstName, lastName, salary);
                this.soldiers.Add(soldier);

                return soldier.ToString();
            }

            return null;
        }
    }
}
