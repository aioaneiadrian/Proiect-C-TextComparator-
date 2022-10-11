/**************************************************************************
 *                                                                        *
 *  File:        DifferenceF.cs                                            *
 *  Copyright:   (c) 2022, Aioanei A., Burechita C., Sprinceana R, Chirila *
 *  Description: Text Comparator                                          *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference
{
    public static class Difference
    {
        /// <summary>
        /// Metoda ce returneaza un string ce contine cuvintele diferite din cele 2 texte
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="diff"></param>
        /// <returns>string ce contine cuvintele diferite din cele 2 texte</returns>
        public static string DifferenceF(string str1, string str2, ref List<string> diff )
        {
            if (str1 == null && str2 == null)
            {
                throw new Exception(" Nu pot fi amblee string-uri nulle /n");
            }

            if (str1 == null)
            {
                throw new Exception(" String-ul 1 este null /n");
            }

            if (str2 == null)
            {
                throw new Exception(" String-ul 2 este null /n");
            }
            
            


            List<string> set1 = str1.Split(new char[] { ' ', '\t' }).ToList();//Separarea in cuvinte fie cu spatii, fie cu tab-uri
            List<string> set2 = str2.Split(new char[] { ' ', '\t' }).ToList();
            int c = 0;
            

            if (set2.Count() > set1.Count())
            {

                diff = set2.Except(set1).ToList();

                foreach (string str in set2)
                {
                    if (set1.Contains(str) == true)
                        continue;
                    else
                    {
                        c++;
                    }
                }

            }
            else if (set2.Count() < set1.Count())
            {
                diff = set1.Except(set2).ToList();

                foreach (string str in set2)
                {
                    if (set1.Contains(str) == true)
                        continue;
                    else
                    {
                        c++;
                    }
                }

            }
            else
            {
                foreach (string str in set1)
                {
                    if (set2.Contains(str) == true)
                        continue;
                    else
                    {
                        c++;
                        diff.Add(str);
                    }
                }

            }

            diff.Add(c.ToString());
            return string.Join(" ", diff);
        }
    }
}
