﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatInternationalAirportSystem.Models
{
    internal class Terminal
    {
        public int TerminalId { get; set; }
        public string TerminalName { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
    }
}
