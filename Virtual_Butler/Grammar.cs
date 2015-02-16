using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Butler
{
    public class ButlerGrammar
    {
        private static Grammar wolfram = new Grammar(new GrammarBuilder("wolfram"));

        private static Grammar open = new Grammar(new GrammarBuilder("open"));
        //GrammarBuilder _run = new GrammarBuilder("run");

        private static Grammar google = new Grammar(new GrammarBuilder("google"));
        //GrammarBuilder _search = new GrammarBuilder("search");

        private static Grammar delete = new Grammar(new GrammarBuilder("delete"));
        //GrammarBuilder _remove = new GrammarBuilder("remove");
        //GrammarBuilder _erase = new GrammarBuilder("erase");

        private static Grammar kill = new Grammar(new GrammarBuilder("kill"));
        //GrammarBuilder _quit = new GrammarBuilder("quit");

        private static Grammar wiki = new Grammar(new GrammarBuilder("wiki"));

        private static Grammar tweet = new Grammar(new GrammarBuilder("tweet"));

        private static Grammar recommend = new Grammar(new GrammarBuilder("recommend"));
        //GrammarBuilder _movie = new GrammarBuilder("movie");

        public static Grammar[] getGrammar()
        {
            Grammar[] grammar = new Grammar[] {wolfram, open, google, delete, kill, wiki, tweet, recommend};
            return grammar;
        }
    }
}
