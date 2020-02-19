using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        Dictionary<int, IPrivate> Privates { get; }
    }
}
