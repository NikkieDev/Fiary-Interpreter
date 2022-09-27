namespace Fiary
{
    class Lexer
    {
        internal static List<String> mem = new List<String>();
        internal String[] Interpret(String[] Data)
        {
            List<String> InterpretedList = new List<String>();

            String _char = "";

            for (int i = 0; i < InterpretedList.Count; i++)
            {
                switch (_char)
                {
                    case "\"":
                        int QuoteAmount = 0;

                        for (int i = 0; i < mem.Count; i++)
                        {
                            if (mem[i])
                                QuoteAmount++;
                        }

                        int _QuoteAmountResult = QuoteAmount / 2;
                        String QuoteAmountResult = _QuoteAmountResult.ToString();

                        if (QuoteAmountResult.EndsWith(".5"))
                        {
                            
                        }
                }
            }

            String[] InterpretedData = InterpretedList.ToArray();
            return InterpretedData;
        }
    }
}