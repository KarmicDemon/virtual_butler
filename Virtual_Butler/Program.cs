using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Virtual_Butler
{
    public class Butler
    {
        static bool completed;

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
            welcome.AppendText("How may I help you today?");
            //Understand Prompt
            PromptBuilder understand = new PromptBuilder();
            understand.AppendText("I will get right on it.");
            //Confuson Prompt
            PromptBuilder confused = new PromptBuilder();
            confused.AppendText("I am very confused. May you repeat that, sir?");
            //Anything Else Prompt
            PromptBuilder more = new PromptBuilder();
            more.AppendText("Would you like anything else, sir?");
            //Finished Prompt
            PromptBuilder end = new PromptBuilder();
            end.AppendText("Very good, sir. Have a nice day.");

            //Grammar[] grammers = ButlerGrammar.getGrammar();

                using (SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US")))
                {
                    //Load Grammar
                    recognizer.LoadGrammar(new DictationGrammar());

                    //Attach speech detected handler
                    recognizer.SpeechDetected +=
                        new EventHandler<SpeechDetectedEventArgs>(SpeechDetectedHandler);

                    //Attach speech recognized handler
                    recognizer.SpeechHypothesized +=
                        new EventHandler<SpeechHypothesizedEventArgs>(SpeechHypothesizedHandler);

                    //Attach speech recognition rejected handler
                    recognizer.SpeechRecognitionRejected +=
                        new EventHandler<SpeechRecognitionRejectedEventArgs>(SpeechRecognitionRejectedHandler);

                    //Attach speech recognized handler
                    recognizer.SpeechRecognized +=
                        new EventHandler<SpeechRecognizedEventArgs>(SpeechRecognizedHandler);

                    //Attach recognize completed handler
                    recognizer.RecognizeCompleted +=
                        new EventHandler<RecognizeCompletedEventArgs>(RecognizeCompletedHandler);


                    //set input to audio device
                    recognizer.SetInputToDefaultAudioDevice();

                    completed = false;

                    Console.WriteLine("Starting asynchronous voice recognition....");

                    //where all the magic happens
                    recognizer.RecognizeAsync(RecognizeMode.Multiple);

                    //Wait fifteen seconds before cancelling recognition
                    Thread.Sleep(TimeSpan.FromSeconds(15));
                    recognizer.RecognizeAsyncCancel();

                    //Wait for operation to complete
                    while (!completed) Thread.Sleep(250);
                    Console.WriteLine("Done. :)");
                }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        //event in which speech is detected
        static void SpeechDetectedHandler(object sender, SpeechDetectedEventArgs e)
        {
            Console.WriteLine("In Speech Detected Handler: ");
            Console.WriteLine(" - AudioPosition = {0}", e.AudioPosition);
        }

        //event in which speech is hypothesized
        static void SpeechHypothesizedHandler(object sender, SpeechHypothesizedEventArgs e)
        {
            Console.WriteLine("In Speech Hypothesized Handler: ");

            string grammerName = "<not available>";
            string resultText = "<not available>";

            if (e.Result != null)
            {
                if (e.Result.Grammar != null) grammerName = e.Result.Grammar.Name;
                resultText = e.Result.Text;
            }

            Console.WriteLine(" - Grammer Name = {0}; Result Text = {1}", grammerName, resultText);
        }

        //event in which speech is recognized
        static void SpeechRecognitionRejectedHandler(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            Console.WriteLine("In Speech Recogniiton Rejected Handler: ");

            string grammerName = "<not available>";
            string resultText = "<not available>";

            if (e.Result != null)
            {
                if (e.Result.Grammar != null) grammerName = e.Result.Grammar.Name;
                resultText = e.Result.Text;
            }

            Console.WriteLine(" - Grammer Name = {0}; Result Text = {1}", grammerName, resultText);
        }

        //event in which speech is recognized
        static void SpeechRecognizedHandler(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("In Speech Recognized Handler: ");

            string grammerName = "<not available>";
            string resultText = "<not available>";

            if (e.Result != null)
            {
                if (e.Result.Grammar != null) grammerName = e.Result.Grammar.Name;
                resultText = e.Result.Text;
            }

            Console.WriteLine(" - Grammer Name = {0}; Result Text = {1}", grammerName, resultText);
        }

        //event in which recognition is completed
        static void RecognizeCompletedHandler(object sender, RecognizeCompletedEventArgs e)
        {
            Console.WriteLine("In Recognize Completed Handler: ");

            if (e.Error != null)
            {
                Console.WriteLine("Error occured during recognition {0}", e.Error);
                return;
            }

            if (e.InitialSilenceTimeout || e.BabbleTimeout)
            {
                Console.WriteLine(" - BabbleTimeout = {0}, InitialSilenceTimeout = {1}", e.BabbleTimeout, e.InitialSilenceTimeout);
                return;
            }

            if (e.InputStreamEnded)
            {
                Console.WriteLine(" - AudioPosition = {0}; InputStreamEnded = {1}", e.AudioPosition, e.InputStreamEnded);
            }

            if (e.Result != null)
            {
                Console.WriteLine(" - Grammar = {0}; Text = {1}; Confidence = {2}",
                    e.Result.Grammar.Name, e.Result.Text, e.Result.Confidence);
                Console.WriteLine(" - AudioPosition = {0}", e.AudioPosition);
            }
            else Console.WriteLine("- No result.");

            completed = true;
        }
    }

}
