using System;

namespace Fiary
{
    class Lexer
    {
        internal dynamic[] Interpret(String[] Data)
        {
            Parser ParserObj = new Parser();
            List<dynamic> InterpretedList = new List<dynamic>();

            for (int i = 0; i < Data.Length; i++)
            {
                switch (Data[i])
                {
                    case ("string"):
                        String Name = ParserObj.ParseStringName(Data[i+1]);
                        String Value = ParserObj.ParseStringValue(Data[i+2]);

                        _String NewString = new _String();
                        NewString._Name = Name;
                        NewString._Value = Value;
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