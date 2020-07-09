﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LightScout.Models
{
    public class LSConfiguration
    {
        public int NumberOfMatches { get; set; }
        public string TabletIdentifier { get; set; }
        public int MaxMatches { get; set; }
        public int SubmitOffset { get; set; }
        public int BluetoothFailureStage { get; set; }
    }
}
