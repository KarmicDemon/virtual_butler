using System;
using System.Speech.SrgsGrammar;
using System.Speeech.Recognition;

public class ButlerGrammar
{
    private Grammar wolfram = new Grammar(new GrammarBuilder("wolfram"));

    private Grammar open = new Grammar(new GrammarBuilder("open"));
    //GrammarBuilder _run = new GrammarBuilder("run");

    private Grammar google = new Grammar(new GrammarBuilder("google"));
    //GrammarBuilder _search = new GrammarBuilder("search");

    private Grammar delete = new Grammar(new GrammarBuilder("delete"));
    //GrammarBuilder _remove = new GrammarBuilder("remove");
    //GrammarBuilder _erase = new GrammarBuilder("erase");

    private Grammar kill = new Grammar(new GrammarBuilder("kill"));
    //GrammarBuilder _quit = new GrammarBuilder("quit");

    private Grammar wiki = new Grammar(new GrammarBuilder("wiki"));

    private Grammar tweet = new Grammar(new GrammarBuilder("tweet"));

    private Grammar recommend = new Grammar(new GrammarBuilder("recommend"));
    //GrammarBuilder _movie = new GrammarBuilder("movie");

    public static Grammar[] getGrammar()
    {
        Grammar grammar = { wolfram, open, google, delete, kill, wiki, tweet, recommend };
        return grammar;
    }
}
