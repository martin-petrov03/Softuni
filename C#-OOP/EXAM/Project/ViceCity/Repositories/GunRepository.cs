namespace ViceCity.Repositories
{
    using System.Collections.Generic;
    using ViceCity.Models.Guns.Contracts;    

    public class GunRepository : IRepository
    {
        private readonly List<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => this.models.AsReadOnly();

        public void Add(IGun model)
        {
            if (!this.models.Contains(model))
            {
                this.models.Add(model);
            }
        }

        public bool Remove(IGun model)
        {
            return this.models.Remove(model);
        }

        public IGun Find(string name)
        {
            IGun gun = this.models.Find(m => m.Name.Equals(name));
            
            return gun;
        }
    }
}
