﻿using System;
using System.Collections.Generic;

namespace bankHeist {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Plan Your Heist");

            List<Dictionary<string, string>> teamMembersList = new List<Dictionary<string, string>> ();

            Console.WriteLine ("How many trial runs do you wish to attempt?");
            int trialRuns = int.Parse (Console.ReadLine ());

            for (int i = 0; i < trialRuns; i++) {
                Random rand = new Random ();
                int luckValue = rand.Next (-10, 11);
                int bankDifficulty = 100 + luckValue;
                int teamSkill = 0;

                while (true) {
                    Dictionary<string, string> teamMember = new Dictionary<string, string> ();

                    Console.WriteLine ("Please Enter a Member Name");
                    string memberName = Console.ReadLine ();
                    teamMember.Add ("Name", memberName);

                    if (memberName != "") {

                        Console.WriteLine ("Please Enter a Skill Level between 1 - 10");
                        teamMember.Add ("Skill Level", Console.ReadLine ());

                        Console.WriteLine ("Please Enter a Courage Level between .0 - 2.0");
                        teamMember.Add ("Courage", Console.ReadLine ());

                        teamMembersList.Add (teamMember);
                    } else {
                        break;
                    }

                }

                // Show each team members information

                foreach (Dictionary<string, string> member in teamMembersList) {
                    // Iterate the KeyValuePairs of the teamMembers
                    // Console.WriteLine ("Team Member:");
                    foreach (KeyValuePair<string, string> individual in member) {
                        if (individual.Key == "Skill Level") {
                            teamSkill += int.Parse (individual.Value);
                        };

                        // Console.WriteLine ($"{individual.Key}: {individual.Value}");
                        // Console.WriteLine (teamSkill);
                    }
                }

                // Console.WriteLine (teamSkill);
                Console.WriteLine (teamSkill);
                Console.WriteLine (bankDifficulty);

                Console.WriteLine ("Your Teams Heist");

                if (teamSkill >= bankDifficulty) {
                    Console.WriteLine ("Your Heist Was Successful");
                } else {
                    Console.WriteLine ("Your Heist Failed");
                }
            }

        }
    }
}