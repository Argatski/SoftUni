using System;
using System.Collections.Generic;

namespace _08.CompanyUser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            SortedDictionary<string, List<string>> CompaniesUser = new SortedDictionary<string, List<string>>();

            //Solution
            InputDataInList(CompaniesUser);

            //Print company user
            PrintCompaniesUsers(CompaniesUser);
          
        }

        static void PrintCompaniesUsers(SortedDictionary<string, List<string>> list)
        {
            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var user in kvp.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }

        static void InputDataInList(SortedDictionary<string, List<string>> dict)
        {

            while (true)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "End")
                {
                    break;
                }

                string company = cmdArgs[0];
                string userID = cmdArgs[1];

                if (dict.ContainsKey(company))
                {

                    if (dict[company].Contains(userID) == false)
                    {
                        dict[company].Add(userID);
                    }
                }
                else
                {
                    dict.Add(company, new List<string> { userID });
                }


            }
        }
    }
}
