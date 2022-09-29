using System;

namespace Fiary
{
    class Lexer
    {
        internal List<KeyValuePair<dynamic,dynamic>> Interpret(String[] Data)
        {
            List<KeyValuePair<dynamic, dynamic>> InterpretedData = new List<KeyValuePair<dynamic, dynamic>>();
            
            // foreach (String word in Data)
            // {
            //     switch (word)
            //     {
            //         case ("string"):

            //             break;
            //         case ("int"):
            //             break;
            //         case ("float"):
            //             break;
            //         case ("bool"):
            //             break;
            //     }
            // }
            for (int i = 0; i < Data.Length; i++)
            {
                switch (Data[i])
                {
                    case ("string"):
                        KeyValuePair<dynamic, dynamic> StringPair = new KeyValuePair<dynamic, dynamic>(Data[i+1], Data[i+2]);
                        InterpretedData.Add(StringPair);
                        break;
                    case ("int"):
                        break;
                    case ("float"):
                        break;
                    case ("bool"):
                        break;
                }
            }

            return InterpretedData;
        }
    }
}