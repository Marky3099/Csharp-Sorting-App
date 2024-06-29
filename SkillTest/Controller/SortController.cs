using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkillTest.Model;
using SkillTest.View;
using System;
using SkillTest.Model;
using SkillTest.View;

namespace SkillTest.Controller
{
    public class SortController
    {
        private SortingApplication mainForm;
        private SortModel sortModel;

        public SortController(SortingApplication mainForm)
        {
            this.mainForm = mainForm;
            this.sortModel = new SortModel();
        }

        public void Sort(string input, string sortingMethod)
        {
            string sortedResult;

            switch (sortingMethod)
            {
                case "Bubble Sort":
                    sortedResult = new string(sortModel.BubbleSort(input));
                    break;
                case "Quick Sort":
                    sortedResult = new string(sortModel.QuickSort(input));
                    break;
                case "Merge Sort":
                    sortedResult = new string(sortModel.MergeSort(input));
                    break;
                default:
                    throw new ArgumentException("Please select a valid sorting method.");
            }

            mainForm.DisplayResult(sortedResult);
        }
    }
}
