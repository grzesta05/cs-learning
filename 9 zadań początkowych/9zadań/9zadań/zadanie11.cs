using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.JScript;

namespace _9zadań
{
    class zadanienr11
    {
        double Kalkulator(double a, char s, double b)
        {
            var engine = VsaEngine.CreateEngine();
            Eval.JScriptEvaluate(mySum, engine);
        }
        public static void z11()
        {
            
        }
    }
}
