using System.Collections.Generic;
using System.Text;
using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps Corps, ICollection<IRepair> repairs) 
            : base(id, firstName, lastName, salary, Corps)
        {
            this.Repairs = repairs;
        }

        public ICollection<IRepair> Repairs { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Repairs:");

            foreach (IRepair currentRepair in this.Repairs)
            {
                sb.AppendLine("  " + currentRepair.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
