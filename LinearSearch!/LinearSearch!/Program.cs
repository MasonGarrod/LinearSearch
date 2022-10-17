// Linear Search \\
// Mason Garrod \\
// 17/10/2022 \\

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Linear Search \\
            Console.WriteLine("Linear Search\n");

            // Declare Variables \\
            string search;
            bool found;
            int match;

            // Declare Assigned List \\
            List<string> bands = new List<string>()
            {
                "Misfits",
                "Pink Floyd",
                "Fontaines DC",
                "Oasis",
                "Kings of Leon", // Dupe
                "Alice in Chains", // Dupe
                "Liam Gallagher", // Dupe
                "The Smiths",
                "The Cure",
                "Blur",
                "John Lennon",
                "New Order",
                "Blossoms",
                "Radiohead", // Dupe 
                "Joy Division",
                "Foo Fighters",
                "Deftones",
                "U2",
                "Kings of Leon",
                "Alice in Chains",
                "Arctic Monkeys", // Dupe
                "Bob Dylan", // Dupe
                "Jimi Hendrix", // Dupe
                "Liam Gallagher",
                "Noel Gallaghers High Flying Birds",
                "Radiohead",
                "Sam Fender",
                "The Strokes",
                "The Doors",
                "Deftones", // Dupe
                "Kasabian",
                "Muse",
                "Misfits", // Dupe
                "Pink Floyd", // Dupe
                "Fontaines DC", // Dupe
                "The Verve",
                "Ocean Colour Scene", // Dupe
                "The Smashing Pumpkins", // Dupe
                "The Cranberries", // Dupe
                "Pulp", // Dupe
                "Inhaler",
                "The Stone Roses",
                "Arctic Monkeys",
                "Bob Dylan",
                "Jimi Hendrix",
                "Nine Inch Nails",
                "The Clash",
                "New Order", // Dupe
                "Ocean Colour Scene",
                "The Smashing Pumpkins",
                "The Cranberries",
                "Pulp",
                "The Smiths", // Dupe 
                "Stereophonics",
                "Led Zeppelin",
            };

            // Enter search criteria \\
            Console.Write("Search for: ");
            search = Console.ReadLine();

            // Sets found to false (0) \\
            found = false;

            // Iterate and search using a FOR loop \\
            for (int i = 0; i < bands.Count; i++)
            {
                // Searches for entry, sets found to true (1) if found \\
                if (search.ToLower() == bands[i].ToLower())
                {
                    found = true;
                    break;
                } 
            }

            // Band found \\
            if (found)
            {
                Console.WriteLine($"{search} found in list.");
            }

            // Band NOT found \\
            else
            {
                Console.WriteLine($"{search} not found in list.");
            }

            // Iterate using a FOREACH loops //
            match = 0;
            foreach (string band in bands)
            {
                // Searches for entry, sets found to true (1) if found \\
                if (search.ToLower() == band.ToLower())
                {
                    match = match + 1;
                }
            }

            // Checks if the entry is a duplicate \\
            if (match > 1)
            {
                Console.WriteLine($"{search} is a duplicate entry.");
            }

            // Checks how many times an entry occurs in the list \\
            Console.WriteLine($"{search} occurs {match} times in the list.");

            // Exit \\
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}
