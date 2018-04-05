using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlReview.HierarchyClasses
{
    class League
    {
        public string Name { get; set; }
        public List<Division> Divisions {get; set;}

        public League(string name)
        {
            Name = name;
            Divisions = new List<Division>();
        }
    }
}
