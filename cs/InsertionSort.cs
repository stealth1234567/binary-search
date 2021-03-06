using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace InsertionSortProject
{
  class Program
  {
    public static void InsertionSort(int[] array)
    {
      // loop through from 1 to end
      for(int i = 1; i < array.Length; i++) {
        int currentElement = array[i];
        // use currentElement because array values change while array is being sorted
        int j = i - 1;
        while(j >= 0 && (array[j] > currentElement)) {
          array[j + 1] = array[j];
          j--;
        }
        array[j + 1] = currentElement;
      }
    }

    public static void Main(string[] args)
    {
      int[] array = { 26, 54, 93, 17, 77, 31, 44, 55, 20 };
    }
  }
}
