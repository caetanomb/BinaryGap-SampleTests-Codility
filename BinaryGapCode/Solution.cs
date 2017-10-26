using System;

namespace BinaryGapCode
{
    public class Solution
    {

        public int N { get; set; }
        public string BinaryContent { get; set; }

        public int solution(int n)
        {
            N = n;
            ConvertToBase2();
            int count = 0;

            for (int i = 0; i < BinaryContent.Length; i++)
            {
                if (IsIndexValueZero(i))
                    continue;
                else
                {
                    if (i + 1 >= BinaryContent.Length)
                        break;

                    var aux = ReturnNumberOfCharacteres(ref i);

                    if (aux > count)
                        count = aux;

                    i--; //offset
                }
            }

           return count;
        }

        public bool IsIndexValueZero(int i)
        {
            if (BinaryContent[i] == '0')
                return true;

            return false;
        }

        public void ConvertToBase2()
        {
            BinaryContent = Convert.ToString(N, 2);
        }

        public int ReturnNumberOfCharacteres(ref int index)
        {
            int initialMarkIndex = index;
            int endingMarkIndex = BinaryContent.IndexOf('1', initialMarkIndex + 1);

            if (endingMarkIndex < 0)
            {
                index = BinaryContent.Length;
                return 0;                
            }

            //Setup new position for the main index
            index = endingMarkIndex;

            int startIndexContent = initialMarkIndex + 1;
            int numberOfCharacteres = (endingMarkIndex - initialMarkIndex) - 1;

            string subContent = BinaryContent.Substring(startIndexContent, numberOfCharacteres);

            return subContent?.Length ?? 0;
        }
    }
}