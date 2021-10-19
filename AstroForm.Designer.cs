
namespace SprintOneFramework
{
    partial class AstroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonFill = new System.Windows.Forms.Button();
            this.ListBoxOutput = new System.Windows.Forms.ListBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonBubbleSort = new System.Windows.Forms.Button();
            this.ButtonBinarySearch = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.statusStripErrorMsg = new System.Windows.Forms.StatusStrip();
            this.StatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.rangeButton = new System.Windows.Forms.Button();
            this.sequentialButton = new System.Windows.Forms.Button();
            this.modeButton = new System.Windows.Forms.Button();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.MidExtremeButton = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.AverageTextBox = new System.Windows.Forms.TextBox();
            this.ModeTextBox = new System.Windows.Forms.TextBox();
            this.MidExtremeTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStripErrorMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonFill
            // 
            this.ButtonFill.BackColor = System.Drawing.Color.MistyRose;
            this.ButtonFill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonFill.Location = new System.Drawing.Point(138, 49);
            this.ButtonFill.Name = "ButtonFill";
            this.ButtonFill.Size = new System.Drawing.Size(78, 38);
            this.ButtonFill.TabIndex = 0;
            this.ButtonFill.Text = "Auto Fill";
            this.toolTip1.SetToolTip(this.ButtonFill, "Fills the array with 24 random values");
            this.ButtonFill.UseVisualStyleBackColor = false;
            this.ButtonFill.Click += new System.EventHandler(this.ButtonFill_Click);
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.ItemHeight = 16;
            this.ListBoxOutput.Location = new System.Drawing.Point(12, 49);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(120, 260);
            this.ListBoxOutput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.ListBoxOutput, "Array values will be displayed here");
            this.ListBoxOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxOutput_MouseClick);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(12, 23);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.ShortcutsEnabled = false;
            this.TextBoxInput.Size = new System.Drawing.Size(394, 20);
            this.TextBoxInput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TextBoxInput, "Enter a valid 2 digit integer");
            this.TextBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInput_KeyPress);
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Location = new System.Drawing.Point(138, 253);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(78, 38);
            this.ButtonBubbleSort.TabIndex = 3;
            this.ButtonBubbleSort.Text = "Bubble Sort";
            this.toolTip1.SetToolTip(this.ButtonBubbleSort, "Sort the array");
            this.ButtonBubbleSort.UseVisualStyleBackColor = true;
            this.ButtonBubbleSort.Click += new System.EventHandler(this.ButtonBubbleSort_Click);
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.Location = new System.Drawing.Point(138, 213);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(78, 38);
            this.ButtonBinarySearch.TabIndex = 4;
            this.ButtonBinarySearch.Text = "Binary Search";
            this.toolTip1.SetToolTip(this.ButtonBinarySearch, "Use a binary search to find a value in the array");
            this.ButtonBinarySearch.UseVisualStyleBackColor = true;
            this.ButtonBinarySearch.Click += new System.EventHandler(this.ButtonBinarySearch_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(138, 90);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(78, 38);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.ButtonAdd, "Add a value to the array");
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(138, 172);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(78, 38);
            this.ButtonEdit.TabIndex = 6;
            this.ButtonEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.ButtonEdit, "Edit a value in the array");
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(138, 131);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(78, 38);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.ButtonDelete, "Remove a value from the array");
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // statusStripErrorMsg
            // 
            this.statusStripErrorMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMessage});
            this.statusStripErrorMsg.Location = new System.Drawing.Point(0, 320);
            this.statusStripErrorMsg.Name = "statusStripErrorMsg";
            this.statusStripErrorMsg.Size = new System.Drawing.Size(437, 22);
            this.statusStripErrorMsg.TabIndex = 8;
            this.statusStripErrorMsg.Text = "statusStrip";
            // 
            // StatusMessage
            // 
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(10, 17);
            this.StatusMessage.Text = " ";
            // 
            // rangeButton
            // 
            this.rangeButton.Location = new System.Drawing.Point(222, 172);
            this.rangeButton.Name = "rangeButton";
            this.rangeButton.Size = new System.Drawing.Size(78, 38);
            this.rangeButton.TabIndex = 9;
            this.rangeButton.Text = "Range";
            this.toolTip1.SetToolTip(this.rangeButton, "Calculates the range");
            this.rangeButton.UseVisualStyleBackColor = true;
            this.rangeButton.Click += new System.EventHandler(this.RangeButton_Click);
            // 
            // sequentialButton
            // 
            this.sequentialButton.Location = new System.Drawing.Point(222, 213);
            this.sequentialButton.Name = "sequentialButton";
            this.sequentialButton.Size = new System.Drawing.Size(78, 38);
            this.sequentialButton.TabIndex = 10;
            this.sequentialButton.Text = "Sequential Search";
            this.toolTip1.SetToolTip(this.sequentialButton, "Use a sequential search to find a value in the array");
            this.sequentialButton.UseVisualStyleBackColor = true;
            this.sequentialButton.Click += new System.EventHandler(this.SequentialButton_Click);
            // 
            // modeButton
            // 
            this.modeButton.Location = new System.Drawing.Point(222, 90);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(78, 38);
            this.modeButton.TabIndex = 11;
            this.modeButton.Text = "Mode";
            this.toolTip1.SetToolTip(this.modeButton, "Calculates the mode");
            this.modeButton.UseVisualStyleBackColor = true;
            this.modeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Location = new System.Drawing.Point(302, 172);
            this.TextBoxRange.Multiline = true;
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.ReadOnly = true;
            this.TextBoxRange.Size = new System.Drawing.Size(104, 38);
            this.TextBoxRange.TabIndex = 12;
            // 
            // MidExtremeButton
            // 
            this.MidExtremeButton.Location = new System.Drawing.Point(222, 131);
            this.MidExtremeButton.Name = "MidExtremeButton";
            this.MidExtremeButton.Size = new System.Drawing.Size(78, 38);
            this.MidExtremeButton.TabIndex = 13;
            this.MidExtremeButton.Text = "Mid-extreme";
            this.toolTip1.SetToolTip(this.MidExtremeButton, "Calculates the mid-extreme");
            this.MidExtremeButton.UseVisualStyleBackColor = true;
            this.MidExtremeButton.Click += new System.EventHandler(this.MidExtremeButton_Click);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(222, 49);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(78, 38);
            this.ButtonAverage.TabIndex = 14;
            this.ButtonAverage.Text = "Average";
            this.toolTip1.SetToolTip(this.ButtonAverage, "Calculates the average");
            this.ButtonAverage.UseVisualStyleBackColor = true;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            // 
            // AverageTextBox
            // 
            this.AverageTextBox.Location = new System.Drawing.Point(302, 49);
            this.AverageTextBox.Multiline = true;
            this.AverageTextBox.Name = "AverageTextBox";
            this.AverageTextBox.ReadOnly = true;
            this.AverageTextBox.Size = new System.Drawing.Size(104, 38);
            this.AverageTextBox.TabIndex = 15;
            // 
            // ModeTextBox
            // 
            this.ModeTextBox.Location = new System.Drawing.Point(302, 90);
            this.ModeTextBox.Multiline = true;
            this.ModeTextBox.Name = "ModeTextBox";
            this.ModeTextBox.ReadOnly = true;
            this.ModeTextBox.Size = new System.Drawing.Size(104, 38);
            this.ModeTextBox.TabIndex = 16;
            // 
            // MidExtremeTextBox
            // 
            this.MidExtremeTextBox.Location = new System.Drawing.Point(302, 131);
            this.MidExtremeTextBox.Multiline = true;
            this.MidExtremeTextBox.Name = "MidExtremeTextBox";
            this.MidExtremeTextBox.ReadOnly = true;
            this.MidExtremeTextBox.Size = new System.Drawing.Size(104, 38);
            this.MidExtremeTextBox.TabIndex = 17;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // AstroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 342);
            this.Controls.Add(this.MidExtremeTextBox);
            this.Controls.Add(this.ModeTextBox);
            this.Controls.Add(this.AverageTextBox);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.MidExtremeButton);
            this.Controls.Add(this.TextBoxRange);
            this.Controls.Add(this.modeButton);
            this.Controls.Add(this.sequentialButton);
            this.Controls.Add(this.rangeButton);
            this.Controls.Add(this.statusStripErrorMsg);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonBinarySearch);
            this.Controls.Add(this.ButtonBubbleSort);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ListBoxOutput);
            this.Controls.Add(this.ButtonFill);
            this.Name = "AstroForm";
            this.Text = "Astro Processing";
            this.statusStripErrorMsg.ResumeLayout(false);
            this.statusStripErrorMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFill;
        private System.Windows.Forms.ListBox ListBoxOutput;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonBubbleSort;
        private System.Windows.Forms.Button ButtonBinarySearch;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.StatusStrip statusStripErrorMsg;
        private System.Windows.Forms.ToolStripStatusLabel StatusMessage;
        private System.Windows.Forms.Button rangeButton;
        private System.Windows.Forms.Button sequentialButton;
        private System.Windows.Forms.Button modeButton;
        private System.Windows.Forms.TextBox TextBoxRange;
        private System.Windows.Forms.Button MidExtremeButton;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.TextBox AverageTextBox;
        private System.Windows.Forms.TextBox ModeTextBox;
        private System.Windows.Forms.TextBox MidExtremeTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

