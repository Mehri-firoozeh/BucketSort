using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static float[] BucketSort(float[] unsortedInput)
        {
            List<List<float>> buckets = new List<List<float>>(unsortedInput.Length);
            
            for(int i = 0; i<unsortedInput.Length; i++)
            {
                buckets.Add(new List<float>());
            }
            
            for (int i = 0; i < unsortedInput.Length; i++)
            {
                int index = (int)(unsortedInput[i] * unsortedInput.Length);
                buckets[index].Add(unsortedInput[i]);
            }
            
            for (int i = 0; i < buckets.Count; i++)
            {
                buckets[i].Sort();
            }

            float[] output = new float[unsortedInput.Length];

            int j = 0;

            foreach (var item in buckets)
                foreach (var i in item)
                {
                    output[j] = i;
                    j++;
                }


            return output;
        }


        static void Main(string[] args)
        {

            float[] input = new float[] { 0.76F, 0.52F, 0.10F, 0.12F, 0.24F, };

            var output = BucketSort(input);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
            Console.ReadLine();
        }
    }
}
