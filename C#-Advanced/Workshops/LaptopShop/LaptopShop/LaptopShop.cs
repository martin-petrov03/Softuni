using System;
using System.Collections.Generic;

namespace LaptopShop
{
    public class LaptopShop
    {
        private Dictionary<string, List<Laptop>> laptops = new Dictionary<string, List<Laptop>>();

        public LaptopShop()
        {
            this.laptops = new Dictionary<string, List<Laptop>>();
        }

        public int Count
            => this.laptops.Count;

        public void AddLaptop(Laptop laptop)
        {
            IfNullThrowException(laptop);

            if (!this.laptops.ContainsKey(laptop.Make))
            {
                this.laptops.Add(laptop.Make, new List<Laptop>());
            }
            this.laptops[laptop.Make].Add(laptop);
        }

        public bool RemoveLaptop(Laptop laptop)
        {
            IfNullThrowException(laptop);

            if (!this.laptops.ContainsKey(laptop.Make) || !this.laptops[laptop.Make].Contains(laptop))
            {
                return false;
            }

            bool isRemoved = this.laptops[laptop.Make].Remove(laptop);

            if (this.laptops[laptop.Make].Count == 0)
            {
                isRemoved = this.laptops.Remove(laptop.Make);
            }

            return isRemoved;
        }

        public bool ContainsLaptop(Laptop laptop)
        {
            if (!this.laptops.ContainsKey(laptop.Make) || !this.laptops[laptop.Make].Contains(laptop))
            {
                return false;
            }

            return true;
        }

        public void printAllLaptops(Action<Laptop> action)
        {
            foreach (var (make, laptops) in this.laptops)
            {
                foreach (var laptop in laptops)
                {
                    action(laptop);
                }
            }
        }

        public void IfNullThrowException(Laptop laptop)
        {
            if (laptop == null)
            {
                throw new ArgumentNullException(nameof(laptop), "Object cannot be null");
            }
        }
    }
}