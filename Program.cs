using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("wife", new Dictionary<string, string>(){
            {"name", "Janki"},
            {"age", "26"}
            });

            myFamily.Add("father", new Dictionary<string, string>(){
            {"name", "Ashvin"},
            {"age", "50"}
            });

            myFamily.Add("mother", new Dictionary<string, string>(){
            {"name", "Mamta"},
            {"age", "48"}
            });

            myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Chandni"},
            {"age", "26"}
            });


            myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Harsh"},
            {"age", "30"}
            });

            myFamily.Add("friend", new Dictionary<string, string>(){
            {"name", "Dan"},
            {"age", "29"}
            });



            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
            }
        }
    }
}
