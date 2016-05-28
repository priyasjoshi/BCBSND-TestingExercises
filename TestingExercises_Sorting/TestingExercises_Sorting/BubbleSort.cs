using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExercises_Sorting
{
   public class BubbleSort
    {
        // Sorting Method for BubbleSort Algorithm
        public void Sort(List<ListElements> ele, SortMethods obj)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < ele.Count - 1; i++)
                {
                    if (obj.Compare(ele[i], ele[i + 1]) > 0)
                    {
                        var temp = ele[i];
                        ele[i] = ele[i + 1];
                        ele[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}
