﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace ScrawnyLogger
{
    public partial class LogEntry
    {
        private string GetCaller()
        {
            string output = string.Empty;
            if (!CallerRequest)
            {
                return output;
            }

            List<string> names = [];
            int i = SkipStack;
            while (true)
            {
                StackFrame stackFrame = new(i++);
                MethodBase methodBase = stackFrame.GetMethod();
                if (methodBase == null)
                {
                    break;
                }
                System.Type declaringType = methodBase.DeclaringType;
                if (declaringType == null)
                {
                    break;
                }
                names.Add(methodBase.Name);
            }

            if (names.Count > 0)
            {
                names.Reverse();
                string[] names2 = names.ToArray();
                string names3 = string.Join(";", names2);
                output = $"[{names3}] ";
            }
            return output;
        }
    }
}