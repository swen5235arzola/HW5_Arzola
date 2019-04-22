using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorter_Arzola
{
    public class NamesParser
    {
        public string Path { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path"></param>
        public NamesParser(string path)
        {
            this.Path = path;
        }

        /// <summary>
        /// Return unsorted List of full names
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<FullName> Parse()
        {
            var names = new List<FullName>();
            try
            {
                using (StreamReader sr = new StreamReader(this.Path))
                {
                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine();
                        if (line.Contains(','))
                        {
                            var words = line.Split(',');
                            if(words.Length > 1)
                            {
                                var fullName = new FullName();
                                fullName.FirstName = words[0].Trim();
                                fullName.LastName = words[1].Trim();
                                Console.WriteLine(fullName.FirstName + " " + fullName.LastName);
                                names.Add(fullName);
                            }
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return names;
        }
    }
}