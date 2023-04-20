using Microsoft.AspNetCore.Mvc;
using SorterAlgorithm;

namespace SorterWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SorterController : ControllerBase
    {

        [HttpPost("intArraySorter")]
        public int[] IntArraySorter(int[] array)
        {
            Sorter.IntSort(array);
            return array;
        }

        [HttpPost("charArraySorter")]
        public char[] CharArraySorter(char[] array)
        {
            Sorter.CharSort(array);
            return array;

        }

        [HttpPost("doubleArraySorter")]
        public double[] DoubleArraySorter(double[] array)
        {
            Sorter.DoubleSort(array);
            return array;

        }

        [HttpPost("stringSorter")]

        public string stringSorter(string str)
        {
            str = Sorter.StringSort(str);
            return str;

        }
    }
}
