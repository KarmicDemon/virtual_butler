using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Butler
{
    class Command
    {
        //private bool isInitialized = false;
        private string action;
        private string command;


        public Command(string action, string command)
        {
            //this.isInitialized = true; 
            this.action = action; this.command = command;
        }
    }
}
