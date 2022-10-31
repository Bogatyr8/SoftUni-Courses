using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            //It's time for the teamwork projects and you are responsible for gathering the teams. First, you will receive an integer – the count of the teams you will have to register. You will be given a user and a team, separated with "-".  The user is the creator of the team. For every newly created team you should print a message: 
            //"Team {teamName} has been created by {user}!".
            //Next, you will receive а user with a team, separated with "->", which means that the user wants to join that team. Upon receiving the command: "end of assignment", you should print every team, ordered by the count of its members(descending) and then by name(ascending). For each team, you have to print its members sorted by name(ascending).However, there are several rules:
            //•	If а user tries to create a team more than once, a message should be displayed:
            //-"Team {teamName} was already created!"
            //•	A creator of a team cannot create another team – the following message should be thrown: 
            //-"{user} cannot create another team!"
            //•	If а user tries to join a non-existent team, a message should be displayed:
            //-"Team {teamName} does not exist!"
            //•	A member of a team cannot join another team – the following message should be thrown:
            //-"Member {user} cannot join team {team Name}!"
            //•	In the end, teams with zero members(with only a creator) should disband and you have to print them ordered by name in ascending order. 
            //•	 Every valid team should be printed ordered by name(ascending) in the following format:
            //            "{teamName}
            //            - { creator}
            //            -- { member}…"
            List<Team> teams = new List<Team>();

            bool creator = false;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string user = input[0];
                string teamName = input[1];

                if (IsThisTeamExisting(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (DoesCreatorHaveATeam(teams, user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else
                {
                    creator = true;
                    Team newTeam = new Team(teamName, user, creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {user}!");
                }
            }
            creator = false;
            string inputString;

            while ((inputString = Console.ReadLine()) != "end of assignment")
            {
                string[] input = inputString
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = input[0];
                string teamName = input[1];

                if (!IsThisTeamExisting(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (IsHeAMemberOfAnotherTeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team joinTeam = teams
                        .First(x => x.TeamName == teamName);
                    joinTeam.AddMember(user);
                }
            }

            List<Team> teamsWithMembers = teams
                .Where(t => t.Member.Count > 0)
                .OrderByDescending(t => t.Member.Count)
                .ThenBy(t => t.TeamName)
                .ToList();
            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine(team.Creator);
                foreach (var user in team.Member.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {user}");
                }
            }

            List<Team> teamsToDisband = teams
                .Where(x => x.Member.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();
            Console.WriteLine($"Teams to disband:");
            foreach (Team disbandteam in teamsToDisband)
            {
                Console.WriteLine($"{disbandteam.TeamName}");
            }
        }

        static bool IsThisTeamExisting(List<Team> teams, string teamName)
        {
            return teams.Any(x => x.TeamName == teamName);
        }

        static bool DoesCreatorHaveATeam(List<Team> teams, string user)
        {
            return teams.Any(x => x.Creator == user);
        }

        static bool IsHeAMemberOfAnotherTeam(List<Team> teams, string user)
        {
            if (user != null)
            {
                return (teams.Any(x => x.Member.Any(m => m == user)) ||
                    teams.Any(x => x.Creator == user));
            }
            else
            {
                return false;
            }
        }
    }

    public class Team
    {
        public Team(string teamName, string user, bool creator)
        {
            TeamName = teamName;
            if (creator)
            {
                Creator = user;
            }
            else
            {
                Member.Add(user);
            }

        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Member { get; set; }
        public void AddMember(string user)
        {
            Member.Add(user);
        }
    }
}
