using System;
using System.Collections.Generic;

namespace FamilyTies
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("big brother", new Dictionary<string, string>() { { "name", "Dillon" }, { "age", "24" } });
            myFamily.Add("little brother", new Dictionary<string, string>() { { "name", "Luke" }, { "age", "15" } });
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Susan" }, { "age", "55" } });
            myFamily.Add("dad", new Dictionary<string, string>() { { "name", "Don" }, { "age", "56" } });
            myFamily.Add("pup", new Dictionary<string, string>() { { "name", "Stormy" }, { "age", "4" } });

            //var familyMember = myFamily.Keys;

            foreach (var member in myFamily)
            {
                var printString = $"{member.Value["name"]} is my { member.Key } and is {member.Value["age"]} years old.";
                Console.WriteLine(printString);
            }
        }
    }
}
