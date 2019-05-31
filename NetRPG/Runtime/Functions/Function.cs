﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetRPG.Runtime.Functions
{
    class Function
    {
        //TODO: only add items to this list if it's used
        private static Dictionary<string, Function> List = new Dictionary<string, Function>
        {
            { "DSPLY", new Operation.Dsply() },

            { "OPEN", new Operation.Open() },
            { "READ", new Operation.Read() },
            { "READP", new Operation.ReadPrevious() },

            { "%ABS", new BIF.Abs() },
            { "%CHAR", new BIF.Char() },
            { "%DEC", new BIF.Dec() },
            { "%DECH", new BIF.Dec() },
            { "%DECPOS", new BIF.DecPos() },
            { "%EDITC", new BIF.EditC() },
            { "%ELEM", new BIF.Elem() },
            { "%FLOAT", new BIF.Float() },
            { "%INT", new BIF.Int() },
            { "%LEN", new BIF.Len() },
            { "%LOOKUP", new BIF.Lookup() },
            { "%TRIM", new BIF.Trim() },
            { "%TRIMR", new BIF.TrimR() },
            { "%TRIML", new BIF.TrimL() },

            { "%TIMESTAMP", new BIF.Timestamp() }
        };

        public static bool IsFunction(string Name)
        {
            return List.ContainsKey(Name.ToUpper());
        }

        public static Function GetFunction(string Name)
        {
            Name = Name.ToUpper();

            if (List.ContainsKey(Name))
                return List[Name];
            else
                return null; //TODO: throw error
        }
        
        public virtual object Execute(object[] Parameters)
        {
            return null;
        }
    }
}
