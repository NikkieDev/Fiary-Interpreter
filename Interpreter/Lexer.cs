namespace Fiary
{
    class Lexer
    {
        private enum TokenType
        {
            STRING_START,
            SPACE,
            STRING_END,
            VALUE_DECLARE,
            VALUE,
            VALUE_NAME
        }
        internal String[] Interpret(String[] Data)
        {
            List<String> InterpretedList = new List<String>();

            String _char = "";
            TokenType Token = new TokenType();

            for (int i = 0; i < InterpretedList.Count; i++)
            {
                _char = InterpretedList[i];

                switch (_char)
                {
                    case "\"":
                        Token = TokenType.STRING_START;
                        break;
                    case " ":
                        Token = TokenType.SPACE;
                        break;
                }

                
            }

            String[] InterpretedData = InterpretedList.ToArray();
            return InterpretedData;
        }
    }
}