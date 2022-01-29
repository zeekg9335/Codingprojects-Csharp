using System;
namespace Project1
{
    public class Mergersorter
    {
        public static void Merge(String[] names)

        {
            if (names.Length >= 2)
            {
                String[] left = new String[names.Length / 2];
                String[] right = new String[names.Length - names.Length / 2];

                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = names[i];
                }

                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = names[i + names.Length / 2];
                }

                Merge(left);
                Merge(right);
                mergeSort(names, left, right);
              

            }
        }

        public static void mergeSort(String[] names, String[] left, String[] right)
        {
            int a = 0;
            int b = 0;
            int compare = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (b >= right.Length || (a < left.Length && left[a].CompareTo(right[b]) < 0))

                {
                    names[i] = left[a];
                    a++;

                }
                else
                {
                    names[i] = right[b];
                    b++;
                    compare += (i - a);
                }

            }



            long getCompares()
            {
                return compare;

            }

            //Console.WriteLine(getCompares());
        }
    }
}




