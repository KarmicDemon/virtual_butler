using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Butler
{
    class Router
    {
        public const string delete = "delete";
        public const string google = "google";
        public const string kill = "kill";
        public const string recommend = "recommend";
        public const string run = "run";
        public const string tweet = "tweet";
        public const string wolfram = "wolfram";
        public const string wiki = "wiki";

        public bool route(string determinant)
        {
            switch(determinant) 
            {
                case delete: return Actions.delete();
                case google: return Actions.google();
                case kill: return Actions.kill();
                case recommend: return Actions.recommend();
                case run: return Actions.run();
                case tweet: return Actions.tweet();
                case wolfram: return Actions.wolfram();
                case wiki: return Actions.wiki();
                default: return false;
            }
        } 
    }
}
