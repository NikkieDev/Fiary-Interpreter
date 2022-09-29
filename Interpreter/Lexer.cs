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
                        String Value = "";
                        String Name = ParserObj.ParseStringName(Data[i+1]);
                        _String NewString = new _String();

                        for (int j = 2; j < Data.Length; j++)
                        {
                            Value += Data[j] + " ";
                        }

                        String _Value = ParserObj.ParseStringValue(Value);

                        NewString._Name = Name;
                        NewString._Value = _Value;
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