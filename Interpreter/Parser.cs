using System;

namespace Fiary
{
    class Parser
    {
        internal String ParseStringName(String Data)
        {
            String Name = Data.Remove(Data.Length);
            return Name;
        }
        internal String ParseStringValue(String Data)
        {
            String Value = Data.Remove(Data.Length);
            return Value;
        }
    }
}