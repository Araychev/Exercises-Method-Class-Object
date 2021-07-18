using System.Collections.Generic;

namespace _5._Teamwork_Projects
{
    public class Team
    {
        public Team(string name, string user)
        {
            Name = name;
            User = user;
            Members = new List<string>();
        }
        public string Name { get; set; }

        public string User { get; set; }

        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"Team {Name} has been created by {User}!";
        }
    }
}
