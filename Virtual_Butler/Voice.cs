using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Butler
{
    class Voice
    {
        public static string confused = "I am very confused. May you repeat that, sir?";
        public static string finished = "Thank you, sir.";
        public static string more = "Would you like me to do anything else, sir?";
        public static string welcome = "How may I assist you today, sir?";


        public static SpeechSynthesizer Synth() 
        {
            //Trying to initialize a new instance of the Speech Synthesizer
            SpeechSynthesizer synth = new SpeechSynthesizer();
            //Add the voice of a male voice
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
            //Add Audio Device
            synth.SetOutputToDefaultAudioDevice();
            return synth;
        }

        public static void Speak(string message)
        {
            //Hello Prompt
            PromptBuilder prompt = new PromptBuilder();
            prompt.AppendText(message);
             
} 
