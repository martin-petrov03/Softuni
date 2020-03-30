namespace ViceCity.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ViceCity.Core.Contracts;
    using ViceCity.Models.Guns;
    using ViceCity.Models.Guns.Contracts;
    using ViceCity.Models.Neghbourhoods;
    using ViceCity.Models.Neghbourhoods.Contracts;
    using ViceCity.Models.Players;
    using ViceCity.Models.Players.Contracts;

    public class Controller : IController
    {
        private readonly IPlayer mainPlayer;
        private readonly ICollection<IPlayer> civilPlayers;
        private readonly ICollection<IGun> guns;
        private readonly INeighbourhood gangneighbourhood;

        public Controller()
        {
            this.mainPlayer = new MainPlayer();
            this.civilPlayers = new List<IPlayer>();
            this.guns = new List<IGun>();
            this.gangneighbourhood = new Neighbourhood();
        }

        public string AddGun(string type, string name)
        {
            IGun gun;

            if (nameof(Pistol) == type)
            {
                gun = new Pistol(name);
            }
            else if (nameof(Rifle) == type)
            {
                gun = new Rifle(name);
            }
            else
            {
                return "Invalid gun type!";
            }

            this.guns.Add(gun);
            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name)
        {
            if (this.guns.Count == 0)
            {
                return "There are no guns in the queue";
            }

            IGun gun = this.guns.FirstOrDefault();
            IPlayer civilPlayer = this.civilPlayers.FirstOrDefault(p => p.Name == name);
            string message = string.Empty;

            if (name == "Vercetti")
            {
                this.mainPlayer.GunRepository.Add(gun);
                message = $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }
            else if (civilPlayer != null)
            {
                civilPlayer.GunRepository.Add(gun);
                message = $"Successfully added {gun.Name} to the Civil Player: {name}";
            }
            else
            {
                message = "Civil player with that name doesn't exists!";
            }

            this.guns.Remove(gun);
            return message;
        }

        public string AddPlayer(string name)
        {
            IPlayer civilPlayer = new CivilPlayer(name);
            this.civilPlayers.Add(civilPlayer);
            return $"Successfully added civil player: {civilPlayer.Name}!";
        }

        public string Fight()
        {
            int mainPlayerLifePoints = this.mainPlayer.LifePoints;
            int totalSumLifePoints = this.civilPlayers.Sum(p => p.LifePoints);

            this.gangneighbourhood.Action(this.mainPlayer, this.civilPlayers);

            int mainPlayerLifePointsAfterFight = this.mainPlayer.LifePoints;
            int totalSumLifePointsAfterFight = this.civilPlayers.Sum(p => p.LifePoints);

            int aliveCivilPlayersCount = this.civilPlayers.Count(p => p.IsAlive);

            string message = string.Empty;
            if (mainPlayerLifePoints == mainPlayerLifePointsAfterFight && totalSumLifePoints == totalSumLifePointsAfterFight)
            {
                message = "Everything is okay!";
            }
            else
            {
                int deadCivilPlayers = this.civilPlayers.Count - aliveCivilPlayersCount;
                message += "A fight happened:" + Environment.NewLine;
                message += $"Tommy live points: {this.mainPlayer.LifePoints}!" + Environment.NewLine;
                message += $"Tommy has killed: {deadCivilPlayers} players!" + Environment.NewLine;
                message += $"Left Civil Players: {aliveCivilPlayersCount}!";     
            }

            return message;
        }
    }
}
