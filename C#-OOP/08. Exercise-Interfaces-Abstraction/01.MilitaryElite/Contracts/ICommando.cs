using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ICommando
    {
        ICollection<IMission> Missions { get; }        
    }
}
