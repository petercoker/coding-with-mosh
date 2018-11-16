using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_intermediate.AccessModifierAdvance
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating();
            var rating = CalculateRating(excludeOrders: true);

            Console.WriteLine(rating == 0 ? "Promoted to Level 1" : "Promoted to level 2");
           
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    
    }
}
