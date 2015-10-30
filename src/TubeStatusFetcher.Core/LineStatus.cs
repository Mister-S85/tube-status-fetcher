﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubeStatusFetcher.Core
{
    public class LineStatus
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public CMYK TextColour { get; set; }
        public string ImagePath { get; set; }
    }
}