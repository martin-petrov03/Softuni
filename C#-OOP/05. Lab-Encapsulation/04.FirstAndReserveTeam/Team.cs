using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstSquad;
        private List<Person> reserveSquad;

        public Team(string name)
        {
            this.name = name;
            this.firstSquad = new List<Person>();
            this.reserveSquad = new List<Person>();
        }        

        public IReadOnlyCollection<Person> FirstTeam =>
            this.firstSquad.AsReadOnly();

        public IReadOnlyCollection<Person> ReserveTeam =>
            this.reserveSquad.AsReadOnly();        

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                this.firstSquad.Add(player);
            }
            else
            {
                this.reserveSquad.Add(player);
            }
        }
    }
}
