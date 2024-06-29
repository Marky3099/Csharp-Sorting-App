using SkillTest.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillTest.View
{
    public partial class SortingApplication : Form
    {
        private SortController sortController;
        public SortingApplication()
        {
            InitializeComponent();
            sortController = new SortController(this);
            InitializeComboBox();
            buttonSort.Click += ButtonSort_Click;
        }
        private void InitializeComboBox()
        {
            comboBoxSort.Items.Add("Bubble Sort");
            comboBoxSort.Items.Add("Quick Sort");
            comboBoxSort.Items.Add("Merge Sort");

            comboBoxSort.SelectedIndex = 0;
        }
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            string selectedMethod = comboBoxSort.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(input))
            {
                DisplayError("Input string cannot be empty.");
                return;
            }
            try
            {
                sortController.Sort(input, selectedMethod);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string InputText => textBoxInput.Text;
        public string SelectedSortingMethod => comboBoxSort.SelectedItem.ToString();
        public void DisplayResult(string result)
        {
            textBoxResult.Text = result;
        }
        public void DisplayError(string error)
        {
            MessageBox.Show(error);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
