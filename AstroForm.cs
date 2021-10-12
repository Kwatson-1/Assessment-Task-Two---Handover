using System;
using System.Windows.Forms;
// Kyle Watson and Kristiin Tribbeck, Team Fast Koalas, Sprint 2
// Date: 12/10/2021
// Version: 3
// Project description: Application for recording neutrino interactions per hour over a day.
// Processes include 4 mathematical functions and sequential search button. Values are displayed in a read only textbox.
namespace SprintOneFramework
{
    public partial class AstroForm : Form
    {
        #region Properties
        public AstroForm()
        {
            InitializeComponent();
        }
        // Declare variable for max array size.
        // Initialisation for array.
        // Initialisation for the empty pointer.
        static int ArraySize = 24;
        int[] DataArray = new int[ArraySize];
        bool Sorted = false;
        int ArrayElements = 0;
        #endregion
        #region Binary Search
        // Requires the array to be sorted.
        // Searches for a desired value in the array and if found returns its index otherwise displays not found in the status strip.
        private void ButtonBinarySearch_Click(object sender, EventArgs e)
        {
            StatusMessage.Text = "";
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && (Sorted == true))
            {
                int key = int.Parse(TextBoxInput.Text);
                int min = 0;
                int max = ArraySize - 1;
                int mid = 0;
                bool found = false;

                while (min <= max)
                {
                    mid = (min + max) / 2;
                    if (key == DataArray[mid])
                    {
                        found = true;
                        break;
                    }
                    else if (key < DataArray[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                if (found)
                {
                    StatusMessage.Text = "Found at element [" + mid + "]";
                    TextBoxInput.Clear();
                    TextBoxInput.Focus();
                }
                else
                {
                    StatusMessage.Text = "Not Found";
                    TextBoxInput.Clear();
                    TextBoxInput.Focus();
                }
            }
            else
            {
                StatusMessage.Text = "ERROR: Array not Sorted or Input not entered";
            }
        }
        #endregion
        #region Bubble Sort
        // Functionality for the bubble sort button.
        private void ButtonBubbleSort_Click(object sender, EventArgs e)
        {
            StatusMessage.Text = "";
            for (int x = 0; x <= ArraySize; x++)
            {
                for (int y = 0; y <= ArraySize - 2; y++)
                {
                    if (DataArray[y] > DataArray[y + 1])
                    {
                        int temp = DataArray[y + 1];
                        DataArray[y + 1] = DataArray[y];
                        DataArray[y] = temp;
                    }
                }
            }
            Sorted = true;
            StatusMessage.Text = "Array is sorted";
            DisplayArray();
        }
        #endregion
        #region TextBox and ListBox
        // Displays the user selected item from the display box into the text box.
        private void ListBoxOutput_MouseClick(object sender, MouseEventArgs e)
        {
            StatusMessage.Text = "";
            if (ListBoxOutput.SelectedIndex != -1)
            {
                string dataItem = ListBoxOutput.SelectedItem.ToString();
                int dataItemIndex = ListBoxOutput.FindString(dataItem);
                TextBoxInput.Text = DataArray[dataItemIndex].ToString();
                TextBoxInput.Focus();
            }
            else
            {
                StatusMessage.Text = "ERROR: Please select from the List Box";
            }
        }
        #endregion
        #region Fill Button
        // Method for filling the array with random integers and displaying the values in the list box.
        private void ButtonFill_Click(object sender, EventArgs e)
        {
            StatusMessage.Text = "";
            Random rand = new Random();
            for (int x = 0; x < ArraySize; x++)
            {
                DataArray[x] = rand.Next(10, 100);
                ArrayElements++;
            }
            AverageTextBox.Clear();
            MidExtremeTextBox.Clear();
            TextBoxRange.Clear();
            ModeTextBox.Clear();
            DisplayArray();
            StatusMessage.Text = "Array filled with Random Numbers";
        }
        #endregion
        #region Display Array
        // Method for displaying the array inside of the list box.
        private void DisplayArray()
        {
            ListBoxOutput.Items.Clear();
            for (int x = 0; x < ArraySize; x++)
            {
                if (DataArray[x] != 0)

                    ListBoxOutput.Items.Add("  " + DataArray[x]);
            }
        }
        #endregion
        #region Add Button
        // Functionality for the button which allows the user to add data.
        // Exception handling for invalid user input.
        // Exception handling for if the array is full already.
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            StatusMessage.Text = "";
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && (ArrayElements < 24))
            {
                int key = int.Parse(TextBoxInput.Text);
                for (int j = 0; j < ArraySize; j++)
                {
                    if (DataArray[j] == 0)
                    {
                        DataArray[j] = key;
                        ArrayElements++;
                        break;
                    }
                }
                TextBoxInput.Clear();
                DisplayArray();
            }
            else
            {
                StatusMessage.Text = "ERROR: Array full or Number not entered";
            }
        }
        #endregion
        #region Edit Button
        // Functionality for editing data values inside of the array.
        // Error handling for incorrect user input.
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            StatusMessage.Text = "";
            if (ListBoxOutput.SelectedIndex != -1)
            {
                string dataItem = ListBoxOutput.SelectedItem.ToString();
                int dataItemIndex = ListBoxOutput.FindString(dataItem);
                DataArray[dataItemIndex] = int.Parse(TextBoxInput.Text);
                TextBoxInput.Clear();
                Sorted = false;
                DisplayArray();
            }
            else
            {
                StatusMessage.Text = "ERROR: Please select from the List Box";
            }
        }
        #endregion
        #region Delete Button
        // Functionality for the button which allows the user to delete data.
        // Exception handling for if the user has not selected a value to delete.
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            StatusMessage.Text = "";
            if (!string.IsNullOrEmpty(TextBoxInput.Text))
            {
                int key = int.Parse(TextBoxInput.Text);
                for (int j = 0; j < ArraySize; j++)
                {
                    if (DataArray[j] == key)
                    {
                        DataArray[j] = 0;
                        ArrayElements--;
                        break;
                    }
                }
                TextBoxInput.Clear();
                DisplayArray();
            }
            else
            {
                StatusMessage.Text = "ERROR: Number not entered";
            }
        }
        #endregion
        #region Range Button
        //Functionality for the range button which displays the difference between the highest and the lowest values in the array into a read only text box.
        private void RangeButton_Click(object sender, EventArgs e)
        {
            int lowestNumber = DataArray[0];
            int highestNumber = DataArray[0];
            for (int i = 0; i < ArraySize; i++)
            {
                if (DataArray[i] < lowestNumber)
                {
                    lowestNumber = DataArray[i];
                }
                else if (DataArray[i] > highestNumber)
                {
                    highestNumber = DataArray[i];
                }
            }
            TextBoxRange.Text = Convert.ToString(highestNumber - lowestNumber);
        }
        #endregion
        #region Sequential Button
        // Functionality for the sequential search button.
        // Will loop through the data set starting from index 0 until it finds either the target value or the final index of the array.
        private void SequentialButton_Click(object sender, EventArgs e)
        {
            try
            {
                int targetValue = int.Parse(TextBoxInput.Text);
                for (int i = 0; i < ArraySize; i++)
                    if (DataArray[i] == targetValue)
                    {
                        StatusMessage.Text = "Value found at index " + i;
                        return;
                    }
                    else
                        StatusMessage.Text = "Value not found";
            }
            catch (System.FormatException)
            {
                StatusMessage.Text = "ERROR: Please enter a valid integer to search";
            }

        }
        #endregion
        #region Mode Button
        // Functionality for the mode button which displays the value that appears most often in the array.
        // If the mode of the data set is shared between two values, only the highest value will be displayed in the text box.
        private void ModeButton_Click(object sender, EventArgs e)
        {
            int element;
            int frequency = 1;
            int mode = 0;
            int counter;
            for (int i = 0; i < ArraySize; i++)
            {
                counter = 0;
                element = DataArray[i];
                for (int j = 0; j < ArraySize; j++)
                {
                    if (element == DataArray[j])
                    {
                        counter++;
                    }
                }
                if (counter >= frequency)
                {
                    frequency = counter;
                    mode = element;
                }
                ModeTextBox.Text = mode.ToString();
                StatusMessage.Text = "The frequency of elements in the list is: " + frequency;
            }
        }
        #endregion
        #region Average Button
        // Functionality for the average button which displays into a read only text box.
        // The average is the total of all values in the array divided by the total number of values.
        private void ButtonAverage_Click(object sender, EventArgs e)
        {

            int sum = 0;
            int average = 0;

            for (int x = 0; x < DataArray.Length; x++)
            {
                sum += DataArray[x];
            }
            average = sum / DataArray.Length;
            AverageTextBox.Text = average.ToString();
            StatusMessage.Text = "The sum of elements in the list is: " + sum;
        }
        #endregion
        #region Mid-Extreme Button
        // Functionality for the mid extreme button which displays into a read only text box.
        // The mid-extreme demonstrates the the means of the lowest and highest values.
        private void MidExtremeButton_Click(object sender, EventArgs e)
        {
            int minRange = DataArray[0];
            int maxRange = DataArray[0];

            int midExtreme = (minRange + maxRange) / 2;

            for (int i = 0; i < ArraySize; i++)
            {
                if (DataArray[i] > maxRange)
                {
                    maxRange = DataArray[i];
                }
                else if (DataArray[i] < minRange)
                {
                    minRange = DataArray[i];
                }
                midExtreme = (minRange + maxRange) / 2;
                MidExtremeTextBox.Text = midExtreme.ToString();
                StatusMessage.Text = "The mid-extreme of this array is: " + midExtreme;
            }
        }
        #endregion
        #region Input Handling
        // Handling of invalid user input into the text box.
        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}