using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroes;
        public int Count => this.heroes.Count;

        public HeroRepository()
        {
            this.heroes = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            this.heroes.Add(hero);
        }

        public void Remove(string name)
        {
            Hero targetHero = this.heroes.FirstOrDefault(x => x.Name == name);
            this.heroes.Remove(targetHero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero targetHero = this.heroes.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
            return targetHero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero targetHero = this.heroes.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
            return targetHero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero targetHero = this.heroes.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
            return targetHero;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (Hero hero in this.heroes)
            {
                result.AppendLine(hero.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}