﻿using Factory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color WrapColor { get; set; }
        public Color RibbonColor { get; set; }
        public Toy CreateNew()
        {
            return new Present(WrapColor, RibbonColor);
        }
    }
}
