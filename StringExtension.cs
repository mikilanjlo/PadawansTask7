using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length <= 0)
                throw new ArgumentException();

            StringLengthSort(array);
        }

        private static void StringLengthSort(string[] A)
        {
            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j].Length > A[j + 1].Length)
                    {
                        string temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
        }
    }
}
