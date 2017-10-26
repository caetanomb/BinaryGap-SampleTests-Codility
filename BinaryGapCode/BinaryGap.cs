using System;

namespace BinaryGapCode
{
    public class BinaryGap
    {        
        public int N { get; private set; }                
        public string BinaryContent { get; private set; }        

        public BinaryGap(int n)
        {
            N = n;
            BinaryContent = Convert.ToString(N, 2);
        }

        public int GetLongestBinaryLength()
        {
            int count = 0;            

            for (int i = 0; i < BinaryContent.Length - 1; i++)
            {
                if (IsIndexValueZero(i))
                    continue;
                else
                {
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

        public int ReturnNumberOfCharacteres(ref int index)
        {
            int initialMarkIndex = index;
            int endingMarkIndex = BinaryContent.IndexOf('1', initialMarkIndex + 1);

            //Setup new position for the main index
            index = endingMarkIndex;

            int startIndexContent = initialMarkIndex + 1;
            int numberOfCharacteres = (endingMarkIndex - initialMarkIndex) - 1;

            string subContent = BinaryContent.Substring(startIndexContent, numberOfCharacteres);

            return subContent.Length;
        }
    }
}
