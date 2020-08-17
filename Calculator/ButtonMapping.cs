using System;
using System.Collections.Generic;

namespace Calculator
{
    class ButtonMapping
    {
        public static Dictionary<string, string> NumberMapping = new Dictionary<string, string>()
        {
            { ".", "." },
            { "0", "0" },
            { "1", "1" },
            { "2", "2" },
            { "3", "3" },
            { "4", "4" },
            { "5", "5" },
            { "6", "6" },
            { "7", "7" },
            { "8", "8" },
            { "9", "9" },
        };
        public static Dictionary<string, string> OperatorMapping = new Dictionary<string, string>()
        {
            { "÷", "/" },
            { "X", "*" },
            { "+", "+" },
            { "-", "-" }
        };
    }
}
