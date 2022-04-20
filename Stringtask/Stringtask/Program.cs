using System;
using System.Text;

namespace Stringtask
{
    class Program
    {
        static void Main(string[] args)
        {
             string text = "ibrahim yaxsi oglandi";
            Console.WriteLine(ReverseText(text));
        }
        static StringBuilder ReverseText(string text)
        {
            int index = 0;
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' || i == text.Length - 1)
                {
                    if (i == text.Length - 1)
                    {
                        i += 1;
                    }
                    ReverseAndMerge(newText, text, i - 1, index);
                    AddSpace(newText, text, i);
                    index = i + 1;
                }
            }
            return newText;
        }

        static void ReverseAndMerge(StringBuilder result, string text, int endIndex, int initIndex)
        {
            for (int j = endIndex; j >= initIndex; j--)
            {
                result.Append(text[j]);
            }
        }

        static void AddSpace(StringBuilder result, string text, int index)
        {
            if (index != text.Length)
                result.Append(' ');
        
        }  
    }
}
    

