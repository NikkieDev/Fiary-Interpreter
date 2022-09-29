using System;

namespace Fiary
{
    class Lexer
    {
        internal dynamic[] Interpret(String[] Data)
        {
            List<dynamic> InterpretedList = new List<dynamic>();

            for (int i = 0; i < Data.Length; i++)
            {
                switch (Data[i])
                {
                    case ("string"):
                        _String NewString = new _String();
                        NewString._Name = Data[i+1];
                        NewString._Value = Data[i+2];
                        InterpretedList.Add(NewString);
                        break;
                    case ("int"):
                        break;
                    case ("float"):
                        break;
                    case ("bool"):
                        break;
                }
            }
            dynamic[] InterpretedData = InterpretedList.ToArray();
            return InterpretedData;
        }
    }
}