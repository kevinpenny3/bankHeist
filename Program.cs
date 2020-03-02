using System;
using System.Collections.Generic;

namespace bankHeist {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Plan Your Heist");

            List<Dictionary<string, string>> teamMembersList = new List<Dictionary<string, string>> ();

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

            foreach (Dictionary<string, string> member in teamMembersList) {
                // Iterate the KeyValuePairs of the teamMembers
                Console.WriteLine ("Team Member:");
                foreach (KeyValuePair<string, string> pair in member) {
                    Console.WriteLine ($"{pair.Key}: {pair.Value}");
                    // Console.WriteLine (teamMembersList);
                }
            }

        }
    }
}