using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorter_Arzola
{
    public class NameSorting
    {
        private int first = 1;
        private int k = 0;
        private int n = 0;
        private int c;

        /// <summary>
        /// Return Sorted List of Names
        /// </summary>
        /// <param name="unsortedNames"></param>
        /// <param name="sortStyle">Sort by first or Last Name</param>
        /// <returns>List of Sorted Name</returns>
        public List<FullName> Sort(List<FullName> unsortedNames, SortingStyle sortStyle)
        {
            if (sortStyle == SortingStyle.FIRST)
            {
                return SortByFirstName(unsortedNames);
            }
            else
            {
                return SortByLastName(unsortedNames);
            }
        }

        private List<FullName> SortByLastName(List<FullName> unsortedNames)
        {
            var sortedNames = new List<FullName>();
            char firstLetter = 'A';
            char lastLetter = 'Z';
            while (firstLetter < lastLetter)
            {
                for (int i = 0; i < (k + 1); i++)
                {
                    if (unsortedNames[i].FirstName.ToCharArray()[0] == firstLetter)
                    {
                        /*printf("%s %s\n", names[i].firstName, names[i].lastName);*/ //prints names
                        sortedNames.Add(unsortedNames[i]);
                    }
                }
                firstLetter++;
            }
            return sortedNames;
        }

        private List<FullName> SortByFirstName(List<FullName> unsortedNames)
        {
            var sortedNames = new List<FullName>();
            char firstLetter = 'A';
            char lastLetter = 'Z';
            while (firstLetter < lastLetter)
            {
                for (int i = 0; i < (k + 1); i++)
                {
                    if (unsortedNames[i].LastName.ToCharArray()[0] == firstLetter)
                    {
                        /*printf("%s %s\n", names[i].firstName, names[i].lastName);*/ //prints names
                        sortedNames.Add(unsortedNames[i]);
                    }
                }
                firstLetter++;
            }
            return sortedNames;
        }
    }
}