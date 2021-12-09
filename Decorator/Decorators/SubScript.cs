﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class SubScript : TextInputDecorator, ISubScript
    {
        public SubScript(ITextInput text) : base(text)
        {
            StartTag = "<sub>";
            EndTag = "</sub>";
        }
    }
}
