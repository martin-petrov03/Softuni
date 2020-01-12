using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data { get; set; }

        public int Count { get { return this.data.Count; } }        

        public string Name { get; set; }

        public int Capacity { get; set; }

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;            
            this.Capacity = capacity;
            this.data = new List<Astronaut>();
        }

        public void Add(Astronaut astronaut)
        {
            if (!this.data.Contains(astronaut))
            {
                if (this.Capacity >= 0)
                {
                    this.data.Add(astronaut);
                    this.Capacity--;
                }
            }
        }

        public bool Remove(string name)
        {
            Astronaut targetAstronaut = this.data.FirstOrDefault(x => x.Name == name);
            if (targetAstronaut != null)
            {
                this.data.Remove(targetAstronaut);
                this.Capacity++;
                return true;
            }
            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut targetAstronaut = this.data.OrderByDescending(x => x.Age).First();
            return targetAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut targetAstronaut = this.data.FirstOrDefault(x => x.Name == name);            
            return targetAstronaut;            
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (Astronaut item in this.data)
            {
                sb.AppendLine(item.ToString());        
            }

            return sb.ToString().TrimEnd();
        }
    }
}