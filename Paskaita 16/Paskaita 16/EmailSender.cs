﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_16
{
    internal class EmailSender
    {
        public void SendMessage(object sender,string message)
        {
            Console.WriteLine(message);
        }
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
