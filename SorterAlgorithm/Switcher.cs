using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorterAlgorithm
{
    public static class Switcher
    {
        public static object[] Switch(object[] array, int i, int j)
        {
            var a = array[i];
            array[i] = array[j];
            array[j] = a;
            return array;
        }

        public static int[] IntSwitch(int[] array, int i, int j)
        {
            int a = array[i];
            array[i] = array[j];
            array[j] = a;
            return array;
        }
        public static char[] CharSwitch(char[] array, int i, int j)
        {
            char a = array[i];
            array[i] = array[j];
            array[j] = a;
            return array;
        }
        public static string StringSwitch(string str, int i, int j)
        {
            char[] strCharArray = str.ToCharArray();
            Switcher.CharSwitch(strCharArray, i, j);
            str = strCharArray.ToString();
            return str;
        }
        public static double[] DoubleSwitch(double[] array, int i, int j)
        {
            double a = array[i];
            array[i] = array[j];
            array[j] = a;
            return array;
        }
    }
}
