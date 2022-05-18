using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Kitchen
    {
       public List<KitchenAppliance> things;
        public double totalWeight;
        
        public Kitchen()
        {
            this.things = new List<KitchenAppliance>();
            this.totalWeight = 0;
        }
        public double getTotalWeight()
        {
            return this.totalWeight;
        }
        public void add(KitchenAppliance thing)
        {  
         this.totalWeight += thing.Weight;
        }
        public void add(Dishes thing)
        {
          this.totalWeight += thing.Weight;
        }



    }
}
