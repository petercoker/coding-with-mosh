using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_intermediate.Property
{
    class Person
    {
        public DateTime Birthdate { get; set; }

        public int Age
        {
            get
            {
                TimeSpan timespan = DateTime.Today - Birthdate;
                int years = timespan.Days / 365;

                return years;
            }
        }
    }
}
