﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Bold : TextInputDecorator, IBold
    {
        public Bold(ITextInput text) : base(text)
        {
            StartTag = "<b>";
            EndTag = "</b>";
        }
    }
}
