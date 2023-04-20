using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorterAlgorithm
{
    public class Sorter
    {
        public static int[] IntSort(int[] intArray)
        {

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        intArray = Switcher.IntSwitch(intArray, i, j);
                    }
                }
            }

            return intArray;
        }

        public static char[] CharSort(char[] charArray)
        {

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = i + 1; j < charArray.Length; j++)
                {
                    if (Convert.ToInt16(Char.ToUpper(charArray[i])) > Convert.ToInt16(Char.ToUpper(charArray[j])))
                    {
                        charArray = Switcher.CharSwitch(charArray, i, j);
                    }
                    else if (Convert.ToInt16(Char.ToUpper(charArray[i])) == Convert.ToInt16(Char.ToUpper(charArray[j])))
                    {
                        if (Convert.ToInt16(charArray[i]) > Convert.ToInt16(charArray[j]))
                        {
                            charArray = Switcher.CharSwitch(charArray, i, j);
                        }

                    }
                }
            }

            return charArray;
        }

        public static double[] DoubleSort(double[] doubleArray)
        {
            for (int i = 0; i < doubleArray.Length; i++)
            {
                for (int j = i + 1; j < doubleArray.Length; j++)
                {
                    if (doubleArray[i] > doubleArray[j])
                    {
                        doubleArray = Switcher.DoubleSwitch(doubleArray, i, j);
                    }
                }
            }

            return doubleArray;
        }

        public static string StringSort(string str)
        {
            char[] strCharArray = str.ToCharArray();
            strCharArray = Sorter.CharSort(strCharArray);
            str = "";
            for (int i = 0; i < strCharArray.Length; i++)
            {
                str += strCharArray[i];
            }

            return str;
        }

    }
}
