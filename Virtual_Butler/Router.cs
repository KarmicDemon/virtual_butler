using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Butler
{
    class Router
    {
        private const string delete = "delete";
        private const string google = "google";
        private const string kill = "kill";
        private const string recommend = "recommend";
        private const string run = "run";
        private const string tweet = "tweet";
        private const string wolfram = "wolfram";
        private const string wiki = "wiki";

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
