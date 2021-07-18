using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{

  // It's time for the teamwork projects and you are responsible for gathering the teams. 
  // First you will receive an integer - the count of the teams you will have to register. 
  // You will be given a user and a team, separated with “-”.  The user is the creator of the team. 
  // For every newly created team you should print a message: 
  // "Team {teamName} has been created by {user}!".
  // Next, you will receive а user with a team, separated with "->", which means that the user wants to join that team.
  // Upon receiving the command: “end of assignment”, you should print every team, ordered by the count of its members (descending) and then by name (ascending).
  // For each team, you have to print its members sorted by name (ascending). However, there are several rules:
  // If а user tries to create a team more than once, a message should be displayed: 
  // "Team {teamName} was already created!"
  // A creator of a team cannot create another team – the following message should be thrown: 
  // "{user} cannot create another team!"
  // If а user tries to join a non-existent team, a message should be displayed: 
  // "Team {teamName} does not exist!"
  // A member of a team cannot join another team – the following message should be thrown:
  // "Member {user} cannot join team {team Name}!"
  // In the end, teams with zero members (with only a creator) should disband and you have to print them ordered by name in ascending order. 
  // Every valid team should be printed ordered by name (ascending) in the following format:

    class Program
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine() ?? string.Empty);

            var teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] userTeam = Console.ReadLine()?.Split("-");

                if (userTeam != null)
                {
                    if (teams.Select(x => x.Name).Contains(userTeam[1]))
                    {
                        Console.WriteLine($"Team {userTeam[1]} was already created!");
                    }
                    else if (teams.Select(x => x.User).Contains(userTeam[0]))
                    {
                        Console.WriteLine($"{userTeam[0]} cannot create another team!");
                    }
                    else
                    {
                        Team team = new Team(userTeam[1], userTeam[0]);
                        teams.Add(team);
                        Console.WriteLine(team);
                    }
                }
            }

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "end of assignment")
                {
                    break;
                }

                if (cmd != null)
                {
                    string[] line = cmd.Split("->");

                    string member = line[0];
                    string teamName = line[1];
                    if (!teams.Select(x => x.Name).Contains(teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist!");
                    }
                    else if (teams.Select(x => x.User).Contains(member))
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    }
                    else
                    {
                        int indexOfTeam = teams.FindIndex(x => x.Name == teamName);
                        teams[indexOfTeam].Members.Add(member);

                    }
                }
            }

            List<Team> teamWithMember = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();


            List<Team> notValidTeam = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var team in teamWithMember)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.User);
                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");
 
            foreach (var team in notValidTeam)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
    
}
