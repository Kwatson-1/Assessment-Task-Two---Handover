    using System;
using System.Windows.Forms;
// Your Name, Team Name, Sprint Number
// Date:
// Version:
// Project description
namespace SprintOneFramework
{
    public partial class AstroForm : Form
    {
        #region Properties
        public AstroForm()
        {
            InitializeComponent();
        }
        static int ArraySize = 24;
        int[] DataArray = new int[ArraySize];
        bool Sorted = false;
        int ArrayElements = 0;
        #endregion
        #region Binary Search
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
        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
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
        private void ButtonFill_Click(object sender, EventArgs e)
        {
            StatusMessage.Text = "";
            Random rand = new Random();
            for (int x = 0; x < ArraySize; x++)
            {
                DataArray[x] = rand.Next(10, 100);
                ArrayElements++;
            }
            DisplayArray();
            StatusMessage.Text = "Array filled with Random Numbers";
        }
        #endregion
        #region Display Array
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
        private void rangeButton_Click(object sender, EventArgs e)
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
            Console.WriteLine("range is " + (highestNumber-lowestNumber));
            textBoxRange.Text = Convert.ToString(highestNumber - lowestNumber);

        }
        #endregion
        #region Sequencial Button
        private void sequentialButton_Click(object sender, EventArgs e)
        {
            int targetValue = int.Parse(TextBoxInput.Text);
            for (int i = 0; i < ArraySize; i++)
                if (DataArray[i] == targetValue)
                    Console.WriteLine("Value found at index " + i);
                return;

        }
        #endregion
        #region Mode Button
        private void modeButton_Click(object sender, EventArgs e)
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
                if (counter > frequency)
                {
                    frequency = counter;
                    mode = element;
                }
                // added 
                ModeTextBox.Text = element.ToString();
                StatusMessage.Text = "The frequency of elements in the list is: " + frequency;
            }
            Console.WriteLine("Mode is " + mode);
            //this is a github test
            //this is another github test
            // anotheeer test
        }
        #endregion
        #region Average Button
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
    }