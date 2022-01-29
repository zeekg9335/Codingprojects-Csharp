using System;
namespace Project1
{
    public class bubbleSort
    {
        public bubbleSort()
        { 


        }

        public static void sort(string[] array)
        {
            int i;
            int j;
            String temp;
            Boolean hmm = true;
            while (hmm)
            

                for (i = 0; i < array.Length - 1; i++)
                {
                    

                        if (array[i].CompareTo(array[i+1]) >0)
                        {
                         temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        hmm = false;

                }
            }
        }

        private static void swap(string[] array, int i, int j)
        {
            String temp = array[i];
            array[j] = array[i];
            temp=array[j];
        }
    }
}
