using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Butler
{
    public class Algorithm
    {
        const char[] string_limiters = { ' ' , ',' , '.' , '\t' , ';' , ':' , '?' };
        const string[] actions = { Router.delete, Router.google, Router.kill, 
                                     Router.recommend, Router.run, Router.tweet, Router.wiki, Router.wolfram };

        public string getAction(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1) return list[i];
                if ((list[i].Split(string_limiters).Count()) < 
                    (list[i + 1].Split(string_limiters).Count())) return list[i];
            }
            return "No Action";
        }

        public string getDeterminant(string action)
        {

        }
    }
}
