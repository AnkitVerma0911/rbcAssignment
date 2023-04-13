using System;

namespace rbcAssignment
{
    class cSharpProgram
    {
       public static void Main(string[] args)
        {

            Console.WriteLine(generatePattern(5));
        }
        public static String generatePattern(int patternSize)
        {

            String str = "";
            char c;
            for (int i = 0; i < patternSize; i++)
            {
                for (int j = 0; j < patternSize; j++)
                {
                    if (i == j || i + j == patternSize - 1)
                    {
                        c = '!';
                    }
                    else
                    {
                        c = '*';
                    }
                    str = str + c;
                }
                str = str + "\n";
            }
            return str;
        }

    }

}

