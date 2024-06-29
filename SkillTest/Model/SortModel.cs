using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest.Model
{
    public class SortModel
    {
        public char[] inputtedData;
        public SortModel() { 
        }
        public char[] BubbleSort(string input)
        {
            var sortData = input.ToCharArray();
            for (int i = 0; i < sortData.Length; i++) {
                for (int j = i + 1; j < sortData.Length; j++) {
                    if (sortData[i] > sortData[j]) {
                        char temp = sortData[j];
                        sortData[j] = sortData[i];
                        sortData[i] = temp;
                    }
                }
            }
            return sortData;
        }
        public char[] QuickSort(string input)
        {
            var sortData = input.ToCharArray();
            QuickSort(sortData, 0, sortData.Length - 1);
            return sortData;
        }

        private void QuickSort(char[] array, int min, int max)
        {
            if (min < max)
            {
                int pivot = Partition(array, min, max);

                if (pivot > min) 
                {
                    QuickSort(array, min, pivot - 1);
                }
                if (pivot < max) 
                {
                    QuickSort(array, pivot + 1, max);
                }
            }
        }

        private int Partition(char[] array, int min, int max)
        {
            int pivot = array[max]; 
            int i = min - 1; 

            for (int j = min; j < max; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    char temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            char temp1 = array[i + 1];
            array[i + 1] = array[max];
            array[max] = temp1;

            return (i + 1); 
        }


        public char[] MergeSort(string input)
        {
            var sortData = input.ToCharArray();
            MergeSort(sortData, 0, sortData.Length - 1);
            return sortData;
        }
        private void MergeSort(char[] array, int min, int max)
        {
            if (min < max)
            {
                int middle = (min + max)/ 2;
                MergeSort(array, min, middle);
                MergeSort(array, middle+1, max);
                Merge(array, min, middle, max);
            }
        }
        private void Merge(char[] array, int min, int middle, int max)
        {
            int sub1 = middle - min + 1;
            int sub2 = max - middle;

            var leftArray = new char[sub1];
            var rightArray = new char[sub2];

            Array.Copy(array,min, leftArray, 0, sub1);
            Array.Copy(array,middle+1, rightArray, 0, sub2);

            int i = 0, j = 0, k = min;

            while (i < sub1 && j < sub2) {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < sub1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < sub2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
