using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, Corps Corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = Corps;
        }

        public Corps Corps { get; }
    }
}
