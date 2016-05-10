using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CToets
{
    public class Analyser
    {
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitleg!! <<<<<<<<<<
        //public List<string> splitter(string str)
        //{
        //    string top = str;

        //    int count = str.Split('(').Length - 1;

        //    List<string> finalList = new List<string>();
        //    finalList.Add(removeSpace(top));

        //    List<string> list = new List<string>();
        //    List<string> list2 = new List<string>();
        //    List<string> list3 = new List<string>();
        //    List<string> list4 = new List<string>();

        //    list = getNestedString(top);
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        list4.Add(list[i]);

        //        if (containsBrackets(list[i]))
        //        {
        //            list2 = getNestedString(list[i]);

        //            for (int c = 0; c < list2.Count; c++)
        //            {
        //                list4.Add(list2[c]);

        //                if (containsBrackets(list[i]))
        //                {
        //                    list3 = getNestedString(list2[c]);

        //                    for (int g = 0; g < list3.Count; g++)
        //                    {
        //                        list4.Add(list3[g]);
        //                    }
        //                }
        //            }         
        //        }
        //    }

        //    for (int i = 0; i < list4.Count; i++)
        //    {
        //        //string input;
        //        //input = list3[i].Replace("(", "").Replace(")", ""); 
        //        //finalList.Add(removeSpace(list4[i]));
        //    }

        //    return finalList;
        //}        

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Title <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        // uitleg!! <<<<<<<<<<
        public List<string> getNestedString(string str)
        {           

            List<string> list = new List<string>();            
            var input = str;
            input = Regex.Replace(input, @"\((?! |$)", "( ");
            input = Regex.Replace(input, @"\)(?! |$)", ") ");

            var regex = new Regex(@"
                    \(                    # Match (
                    (
                        [^()]+            # all chars except ()
                        | (?<Level>\()    # or if ( then Level += 1
                        | (?<-Level>\))   # or if ) then Level -= 1
                    )+                    # Repeat (to go from inside to outside)
                    (?(Level)(?!))        # zero-width negative lookahead assertion
                    \)                    # Match )",
                System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace);

            foreach (Match c in regex.Matches(input))
            {              
                list.Add(c.Value.Trim('(', ')'));
            }

            return list;
        }

       

       


     

    }
}
