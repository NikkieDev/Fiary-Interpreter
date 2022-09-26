namespace Fiary
{
    class Lexer
    {
        internal String[] Interpret(String[] Data)
        {
            List<String> InterpretedList = new List<String>();

            String _char = "";

            for (int i = 0; i < InterpretedList.Count; i++)
            {
                _char = InterpretedList[i];    
            }

            String[] InterpretedData = InterpretedList.ToArray();
            return InterpretedData;
        }
    }
}