using System;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Butler
{
    public class Butler
    {
        static void Main(string[] args)
        {
            //Trying to initialize a new instance of the Speech Synthesizer
            SpeechSynthesizer synth = new SpeechSynthesizer();
            //Add the voice of a male voice
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
            //Add Audio Device
            synth.SetOutputToDefaultAudioDevice();

            //Hello Prompt
            PromptBuilder welcome = new PromptBuilder();
            welcome.appendText("How may I help you today?");
            //Understand Prompt
            PromptBuilder unserstand = new PromptBuilder();
            understand.appendText("I will get right on it.");
            //Confuson Prompt
            PromptBuilder confused = new PromptBuilder();
            confused.appendText("I am very confused. May you repeat that, sir?");
            //Anything Else Prompt
            PromptBuilder more = new PromptBuilder();
            more.appendText("Would you like anything else, sir?");
            //Finished Prompt
            PromptBuilder end = new PromptBuilder();
            end.appendText("Very good, sir. Have a nice day.");

            speechRE = new SpeechRecognitionEngine();
            speechRE.SetInputToDefaultAudioDevice();
            speechRE.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}