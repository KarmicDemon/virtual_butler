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
        public static bool completed;

        static void Main(string[] args)
        {
            using (SpeechRecognitionEngine recognizer = Recognition.Recognizer())
            {
                completed = false;
                
                //Speak welcome
                //Voice.Speak(Voice.welcome);

                //Where all the magic happens
                Console.WriteLine("Starting asynchronous voice recognition....");
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
    }
}
