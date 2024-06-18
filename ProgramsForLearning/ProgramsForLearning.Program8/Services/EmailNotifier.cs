﻿using ProgramsForLearning.Program8.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsForLearning.Program8.Services
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("tu mensaje por email fue mandado: " + message);
        }
    }
}
