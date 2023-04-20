using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            return contents.ToArray();
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            if (length1 + length2 + length3 != contents.Count) throw new ArgumentException("Number of elements in list must match array size");

            string[,,] output = new string[length1, length2, length3];

            checked
            {
                int l = 0;
                for (int i = 0; i < length1; i++)
                {

                    for (int j = 0; j < length2; j++)
                    {

                        for (int k = 0; k < length3; k++)
                        {
                            output[i, j, k] = contents[l];
                            l++;
                        }
                    }
                }
            }
            return output;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {

            if (countRow1 + countRow2 != contents.Count) throw new ArgumentException("Number of elements in list must match array size");

            string[][] output = new string[][]
            {
                new string[countRow1],
                new string[countRow2],
            };

            int[] countRowArray = { countRow1, countRow2 };

            checked
            {
                int l = 0;
                for (int i = 0; i < countRowArray.Length; i++)
                {
                    for (int j = 0; j < countRowArray[i]; j++)
                    {
                        output[i][j] = contents[l];
                        l++;

                    }
                }
            }
            return output;
        }
    }
}
