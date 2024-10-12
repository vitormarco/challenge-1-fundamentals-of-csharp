namespace Desafio1FudamentosCSharp;
public static class WordsOperations
{
    public static int WordsLength(string word)
    {
        int length = 0;
        foreach (var item in word)
        {
            if (!item.Equals(' '))
            {
                length++;
            }
        }

        return length;
    }
}
