﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string teamName;
            string name;
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] data = input.Split('-').ToArray();
                name = data[0];
                teamName = data[1];
                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
               
                }
                else
                {
                    if (teams.Any(x => x.Creator == name))
                    {
                        Console.WriteLine($"{name} cannot create another team!");
                      
                    }
                    else
                    {
                        Team team = new Team();
                        team.Creator = name;
                        team.Name = teamName;
                        List<string> members = new List<string>();
                        team.Members = members;
                        teams.Add(team);
                        Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                    }
                   
                }
                input = Console.ReadLine();
            }

            string nameJoiner;
            string teamToJoin;


            while (input != "end of assignment")
            {
                string[] joyners = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                nameJoiner = joyners[0];
                teamToJoin = joyners[1]; ;
                if (!teams.Any(x => x.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    
                }
                else if (teams.Any(x => x.Members.Contains(nameJoiner)) 
                    || (teams.Any(x => x.Creator == (nameJoiner))))
                {
                    Console.WriteLine($"Member {nameJoiner} cannot join team {teamToJoin}!");
                }
                else
                {
                    foreach (var squad in teams.Where(x=>x.Name == teamToJoin))
                    {
                        squad.Members.Add(nameJoiner);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var squad in teams.Where(x => x.Members.Count !=0)
                .OrderByDescending(x => x.Members.Count). ThenBy(x=> x.Name))
            {
                Console.WriteLine($"{squad.Name}");
                Console.WriteLine($"- {squad.Creator}");
                foreach (var member in squad.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var squad in teams.Where(x=>x.Members.Count == 0).OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{squad.Name}");
            }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator{ get; set; }
        public List<string> Members { get; set; }
    }
}
