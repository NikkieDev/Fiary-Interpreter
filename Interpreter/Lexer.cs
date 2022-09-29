using System;

namespace Fiary
{
    class Lexer
    {
        internal List<String> Interpret(String[] Data)
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
                        InterpretedData.Add(Data[i]+1, Data[i]+2);
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