using System;
using System.Collections.Generic;
using System.Text;

namespace NetRPG.Runtime.Functions.BIF
{
    class TrimL : Function
    {
        public override object Execute(object[] Parameters)
        {
            if (Parameters[0] is string) {
                string Value = (Parameters[0] as string);
                return Value.TrimStart();
            } else {
                Error.ThrowRuntimeError("%Trim", "Only accepts string type.");
                return null;
            }
        }
    }
}
