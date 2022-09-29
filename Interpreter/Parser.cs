using System;

namespace Fiary
{
    class Parser
    {
        internal String ParseStringName(String Data)
        {
            String Name = Data.Remove(Data.Length-1);
            return Name;
        }
        internal String ParseStringValue(String Data)
        {
            String Value = Data.Remove(Data.IndexOf(";"));
            return Value;
        }
    }
}