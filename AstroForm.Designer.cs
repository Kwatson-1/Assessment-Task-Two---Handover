
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
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.statusStripErrorMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonFill
            // 
            this.ButtonFill.BackColor = System.Drawing.Color.MistyRose;
            this.ButtonFill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonFill.Location = new System.Drawing.Point(139, 378);
            this.ButtonFill.Name = "ButtonFill";
            this.ButtonFill.Size = new System.Drawing.Size(100, 23);
            this.ButtonFill.TabIndex = 0;
            this.ButtonFill.Text = "Auto Fill";
            this.ButtonFill.UseVisualStyleBackColor = false;
            this.ButtonFill.Click += new System.EventHandler(this.ButtonFill_Click);
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.ItemHeight = 16;
            this.ListBoxOutput.Location = new System.Drawing.Point(13, 13);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(97, 388);
            this.ListBoxOutput.TabIndex = 1;
            this.ListBoxOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxOutput_MouseClick);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(139, 13);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.ShortcutsEnabled = false;
            this.TextBoxInput.Size = new System.Drawing.Size(100, 20);
            this.TextBoxInput.TabIndex = 2;
            this.TextBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInput_KeyPress);
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Location = new System.Drawing.Point(140, 40);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(99, 23);
            this.ButtonBubbleSort.TabIndex = 3;
            this.ButtonBubbleSort.Text = "Bubble Sort";
            this.ButtonBubbleSort.UseVisualStyleBackColor = true;
            this.ButtonBubbleSort.Click += new System.EventHandler(this.ButtonBubbleSort_Click);
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.Location = new System.Drawing.Point(140, 70);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(99, 23);
            this.ButtonBinarySearch.TabIndex = 4;
            this.ButtonBinarySearch.Text = "Binary Search";
            this.ButtonBinarySearch.UseVisualStyleBackColor = true;
            this.ButtonBinarySearch.Click += new System.EventHandler(this.ButtonBinarySearch_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(140, 124);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(99, 23);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(139, 154);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(100, 23);
            this.ButtonEdit.TabIndex = 6;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(139, 184);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(100, 23);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // statusStripErrorMsg
            // 
            this.statusStripErrorMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMessage});
            this.statusStripErrorMsg.Location = new System.Drawing.Point(0, 423);
            this.statusStripErrorMsg.Name = "statusStripErrorMsg";
            this.statusStripErrorMsg.Size = new System.Drawing.Size(279, 22);
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
            this.rangeButton.Location = new System.Drawing.Point(140, 213);
            this.rangeButton.Name = "rangeButton";
            this.rangeButton.Size = new System.Drawing.Size(100, 23);
            this.rangeButton.TabIndex = 9;
            this.rangeButton.Text = "Range";
            this.rangeButton.UseVisualStyleBackColor = true;
            this.rangeButton.Click += new System.EventHandler(this.rangeButton_Click);
            // 
            // sequentialButton
            // 
            this.sequentialButton.Location = new System.Drawing.Point(139, 242);
            this.sequentialButton.Name = "sequentialButton";
            this.sequentialButton.Size = new System.Drawing.Size(100, 37);
            this.sequentialButton.TabIndex = 10;
            this.sequentialButton.Text = "Sequential Search";
            this.sequentialButton.UseVisualStyleBackColor = true;
            this.sequentialButton.Click += new System.EventHandler(this.sequentialButton_Click);
            // 
            // modeButton
            // 
            this.modeButton.Location = new System.Drawing.Point(139, 285);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(100, 23);
            this.modeButton.TabIndex = 11;
            this.modeButton.Text = "Mode";
            this.modeButton.UseVisualStyleBackColor = true;
            this.modeButton.Click += new System.EventHandler(this.modeButton_Click);
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(139, 330);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.ReadOnly = true;
            this.textBoxRange.Size = new System.Drawing.Size(100, 20);
            this.textBoxRange.TabIndex = 12;
            // 
            // AstroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 445);
            this.Controls.Add(this.textBoxRange);
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
        private System.Windows.Forms.TextBox textBoxRange;
    }
}

