using System.Collections.Generic;

namespace XamlReview.HierarchyClasses
{
    public class Division
    {

        public string Name { get; set; }
        public List<Team> Teams { get; set; }

        public Division(string name)
        {
            Name = name;
            Teams = new List<Team>();
        }
    }
}