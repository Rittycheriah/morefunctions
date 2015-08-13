using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFunctions
{
    public class CoolFunctions
    {
        public static int iterfactorial(int n)
        {
            int answer = 1;
            for (var i = n; i >= 1; i--)
            {
                answer *= i;
            }
            return answer;
        }

        public static int recurfactorial(int n)
        {
            if (n != 1)
            {
                return n*recurfactorial(n - 1);
            } else
            {
                // This is the base case
                return n;
            }
        }

        public int[] swapInPlace(int[] inputs, int left_most_index, int right_most_index)
        {
            return null;
        }

        public static bool isSorted(int[] inputs)
        {
            for (var i = 0; i < inputs.Length - 1; i++)
            {
                if (inputs[i] > inputs[i+1])
                {
                    return false;
                } 
            }
            return true;
        }

        public static int[] InsertionSort(int[] inputs)
        {
            var answer = new int[inputs.Length];
            var temp = new int[inputs.Length];
            // get a forreal clone of this array.
            int[] copy_of_inputs = inputs.Clone() as int[];
            var i = 0;
            var j = i + 1;
            var swapped = false;
            var end = false;
            while (!swapped && j != copy_of_inputs.Length - 1)
            {
                // what is the job of the outer loop
                // Answer: Tells us when to stop restting 'i' and return results
                swapped = false;
                while (i < copy_of_inputs.Length - 1)
                {
                    // what's the job of the inner loop
                    // answer: to iterate through the [i]
                    var second_item = copy_of_inputs[j];
                    var item = copy_of_inputs[i];
                    if (item > second_item)
                    {
                        // Swappin' son , seems useful
                        var tmpa = item;
                        var tmpb = second_item;
                        copy_of_inputs[i] = tmpb; // item located at j
                        copy_of_inputs[j] = tmpa;
                        // j++; keep an eye on it
                        swapped = true;
                    }

                    if (j == copy_of_inputs.Length - 1)
                    {
                        i = 0;
                    }
                    else if (CoolFunctions.isSorted(copy_of_inputs))
                    {
                        break;
                    }
                    else
                    {
                        i++;
                    }

                    j = i + 1; // same as j++

                } // end of inner while loop

                if (swapped == false)
                {
                    break; // if nothing swapped - then we are done done.
                }
            }

            // here's what we are trying to implement above:
            // 1. Compare item to second_item;
            // 2. if item > second item, swap
            //      else start over (increment)
            // 3. pick next 2 things
            // 4. Repeat steps 1 - 3
            // 5. Start over

            //for (var i = 0;i < inputs.Length; i++) {
            //    var item = inputs[i];
            //    var j = 0;

            //    while (j < temp.Length)
            //    {
            //        var second_item = inputs[j];
            //        if (j == temp.Length - 1)
            //        {
            //            answer[j - i] = item;
            //            j += 1;
            //            continue;
                        // start inner loop at current index +1
                    //}
                    //else if (item < second_item)
                    //{

                    //} else { 

                        //temp.Length - 1 
                        // leave it? 
                        /*
                          var tmp1 = item;
                          var tmp2 = second_item;
                          item = tmp2;
                          second_item = tmp1;
                        */
                //    }

                //    j += 1;
                //}

                //var item2 = inputs[i+1];
            //}
            return copy_of_inputs;
        }
    }
}
